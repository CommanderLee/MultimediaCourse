using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ImageRetrieval
{
    public partial class FormMain : Form
    {
        /** Tab 1: Training **/

        string          datasetFolder;
        string[]        imgNames, queryNames;

        const string    defaultFileName = "defaultFile.txt";

        /** Tab 2: Testing **/

        List<MyImage>   myImages;

        int             colorPartB, colorPartG, colorPartR;
        int             returnImgNum;
        const string    textBtnTestPrefix = "Test No.             ";
        int             currTestIndex;

        DistanceMetrics currMetric;

        List<KeyValuePair<MyImage, double>> resultPair;
        string          precisionStr;
        double          overallPrecision;
        double          currMaxDist = -1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxMetrics.SelectedIndex = 0;

            myImages = new List<MyImage>();

            resultPair = new List<KeyValuePair<MyImage, double>>();
        }

        /** Tab 1: Training **/

        private void buttonLoadDataset_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.SelectedPath = Directory.GetCurrentDirectory();
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                datasetFolder = openFolder.SelectedPath;
                labelLoadDataset.Text = "Load dataset from: " + datasetFolder;
            }

            File.WriteAllText(defaultFileName, datasetFolder + '\n');
        }

        private void buttonLoadImgList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (datasetFolder != null)
            {
                openFile.InitialDirectory = datasetFolder;
            }

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgNames = File.ReadAllLines(openFile.FileName);
                labelLoadImgList.Text = "Load image list from: " + openFile.FileName;
                
                string listStr = String.Join("\n", imgNames);
                labelShowImgList.Text = listStr;
            }

            File.AppendAllText(defaultFileName, openFile.FileName + '\n');
        }

        private void buttonLoadQueryList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (datasetFolder != null)
            {
                openFile.InitialDirectory = datasetFolder;
            }

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                queryNames = File.ReadAllLines(openFile.FileName);
                labelLoadQueryList.Text = "Load image list from: " + openFile.FileName;

                string listStr = String.Join("\n", queryNames);
                labelShowQueryList.Text = listStr;
            }

            File.AppendAllText(defaultFileName, openFile.FileName + '\n');
        }

        private void buttonQuickStart_Click(object sender, EventArgs e)
        {
            // Use default settings
            if (File.Exists(defaultFileName))
            {
                string[] fileNames = File.ReadAllLines(defaultFileName);

                if (fileNames.Length >= 3)
                {
                    // Button 1
                    datasetFolder = fileNames[0];
                    labelLoadDataset.Text = "Load dataset from: " + datasetFolder;

                    // Button 2
                    imgNames = File.ReadAllLines(fileNames[1]);
                    labelLoadImgList.Text = "Load image list from: " + fileNames[1];

                    string listStr = String.Join("\n", imgNames);
                    labelShowImgList.Text = listStr;

                    // Button 3
                    queryNames = File.ReadAllLines(fileNames[2]);
                    labelLoadQueryList.Text = "Load image list from: " + fileNames[2];

                    listStr = String.Join("\n", queryNames);
                    labelShowQueryList.Text = listStr;
                }
                else
                {
                    MessageBox.Show("Wrong Format");
                }
            }
            else
            {
                MessageBox.Show("Default setting not found.");
            }
        }

        /** Tab 2: Testing **/

        private void buttonPreProcess_Click(object sender, EventArgs e)
        {
            // Check parameters
            try
            {
                colorPartB = Convert.ToInt32(textBoxColorB.Text);
                colorPartG = Convert.ToInt32(textBoxColorG.Text);
                colorPartR = Convert.ToInt32(textBoxColorR.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Source);
                MessageBox.Show("Please input NUMBERS in the text box.");
                return;
            }

            // Load images
            List<string> validImgNames, validQueryNames;
            validImgNames = new List<string>();
            validQueryNames = new List<string>();

            foreach (string imgNameStr in imgNames)
            {
                if (imgNameStr.Length > 1)
                {
                    string[] imgNameParam = imgNameStr.Split(' ');
                    if (imgNameParam.Length == 3)
                    {
                        string imgName = imgNameParam[0];
                        int width = Convert.ToInt32(imgNameParam[1]);
                        int height = Convert.ToInt32(imgNameParam[2]);

                        validImgNames.Add(imgName);

                        string fullFileName = datasetFolder + '\\' + imgName.Replace('/', '\\');
                        //Console.WriteLine(fullFileName + "   " + width + "   " + height);

                        MyImage myImage = new MyImage(fullFileName, imgName, width, height);
                        myImage.hash(colorPartB, colorPartG, colorPartR);
                        myImages.Add(myImage);
                    }
                }
            }
            imgNames = validImgNames.ToArray();

            foreach (string queryNameStr in queryNames)
            {
                if (queryNameStr.Length > 1)
                {
                    string[] queryNameParam = queryNameStr.Split(' ');
                    if (queryNameParam.Length == 3)
                    {
                        validQueryNames.Add(queryNameParam[0]);
                    }
                }
            }
            queryNames = validQueryNames.ToArray();
            buttonTest.Text = textBtnTestPrefix + "/" + queryNames.Length;
            
            labelTestResult.Text = "Pre-Process finished.";
            pictureBoxShowImg.Image = myImages[0].image.ToBitmap();
            Console.WriteLine("Load " + myImages.Count + " images.");
        }

        private MyImage findImage(string imgName)
        {
            MyImage resultImg = null;
            foreach (MyImage myImage in myImages)
            {
                if (myImage.isEqual(imgName))
                {
                    resultImg = myImage;
                }
            }
            return resultImg;
        }

        private void addToList(MyImage myImage, double dist)
        {
            if (resultPair.Count < returnImgNum)
            {
                // Not enough
                resultPair.Add(new KeyValuePair<MyImage, double>(myImage, dist));
                if (dist > currMaxDist)
                    currMaxDist = dist;
            }
            else if (dist < currMaxDist)
            {
                KeyValuePair<MyImage, double> removePair = new KeyValuePair<MyImage, double>();
                bool removed = false;
                currMaxDist = dist;
                // Remove the currMaxDist, and add this image
                foreach (KeyValuePair<MyImage, double> pair in resultPair)
                {
                    if (pair.Value >= currMaxDist && removed == false)
                    {
                        //resultPair.Remove(pair);
                        removePair = pair;
                        removed = true;
                    }
                    else if (pair.Value > currMaxDist)
                    {
                        currMaxDist = pair.Value;
                    }
                }

                if (removed)
                {
                    resultPair.Remove(removePair);
                    resultPair.Add(new KeyValuePair<MyImage,double>(myImage, dist));
                }
                else
                {
                    Console.WriteLine("Error: Remove pair not found.");
                }
            }
        }

        private static int MyCompare(KeyValuePair<MyImage, double> kvp1, KeyValuePair<MyImage, double> kvp2)
        {
            return kvp1.Value.CompareTo(kvp2.Value);
        }

        private bool checkTestParam()
        {
            bool checkResult = true;
            // Check parameters
            try
            {
                returnImgNum = Convert.ToInt32(textBoxReturnImgNum.Text);

                if (textBoxTestNum.Text.ToLower() == "all")
                    currTestIndex = -1;
                else
                    currTestIndex = Convert.ToInt32(textBoxTestNum.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Source);
                MessageBox.Show("Please input NUMBERS in the text box.");
                checkResult = false;
            }

            if (checkResult)
            {
                string selected = comboBoxMetrics.GetItemText(comboBoxMetrics.SelectedItem);
                if (selected == "Euclidean (L2)")
                {
                    currMetric = DistanceMetrics.L2;
                }
                else if (selected == "Histogram Intersection (HI)")
                {
                    currMetric = DistanceMetrics.HI;
                }
                else if (selected == "Bhattacharyya (Bh)")
                {
                    currMetric = DistanceMetrics.Bh;
                }
                else
                {
                    Console.WriteLine("Please select a distance metric");
                    checkResult = false;
                }
            }

            return checkResult;
        }

        private void saveSingleQuery(string queryName, string result)
        {
            using (StreamWriter sw = new StreamWriter(String.Format("res_{0}.txt", queryName.Substring(0, queryName.Length - 4).Replace('/', '_'))))
            {
                sw.Write(result);
            }
        }

        private void saveAllQuery(string result)
        {
            using (StreamWriter sw = new StreamWriter("res_overall.txt"))
            {
                sw.Write(precisionStr);
                overallPrecision = overallPrecision / returnImgNum;
                sw.WriteLine(overallPrecision);
            }
        }

        /// <summary>
        /// Do Image Retrieval Test of 'index'. Assume that the index is valid.
        /// </summary>
        /// <param name="index"></param>
        private void doTest(int index)
        {
            // Start testing
            //Console.WriteLine("Start testing. No." + textBoxTestNum);
            resultPair.Clear();
            string resultStr = "";
            int matchCnt = 0;

            string queryName = queryNames[index];
            string folderName = queryName.Split('/')[0];
            MyImage queryImg = findImage(queryName);
            if (queryImg != null)
            {
                pictureBoxShowImg.Image = queryImg.image.ToBitmap();

                // Calculate distance
                foreach (MyImage myImage in myImages)
                {
                    double distance = queryImg.getDistance(myImage, currMetric);
                    addToList(myImage, distance);
                }

                // Sort
                resultPair.Sort(MyCompare);

                foreach (KeyValuePair<MyImage, double> pair in resultPair)
                {
                    resultStr += pair.Key.getImgName() + " " + pair.Value + "\r\n";
                    if (folderName == pair.Key.getImgName().Split('/')[0])
                        ++matchCnt;
                }

                double precision = (double)(matchCnt) / returnImgNum;
                overallPrecision += precision;
                precisionStr += queryName + " " + precision + "\r\n";
                labelTestResult.Text =  String.Format("Query: {0}\nResult {1}({2}/{3}):\n", queryName, precision, matchCnt, returnImgNum) + resultStr;
            }
            else
            {
                Console.WriteLine("Error: query image not found. (" + queryName + ")");
            }
            
            Console.WriteLine("Done. No." + index);
            
            // Save to file
            saveSingleQuery(queryName, resultStr);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (checkTestParam())
            {
                if (currTestIndex == -1)
                {
                    // Test all
                    precisionStr = "";
                    overallPrecision = 0;
                    for (var i = 0; i < queryNames.Length; ++i)
                    {
                        doTest(i);
                    }
                    saveAllQuery(precisionStr);
                }
                else
                {
                    if (currTestIndex >= 0 && currTestIndex < queryNames.Length)
                    {
                        doTest(currTestIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid TestNo.");
                    }
                }
            }
        }

        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            labelTestResult.Text = precisionStr + overallPrecision;
        }

        private void buttonTestBackward_Click(object sender, EventArgs e)
        {
            if (currTestIndex > 0)
            {
                --currTestIndex;
                textBoxTestNum.Text = currTestIndex.ToString();
            }
        }

        private void buttonTestForward_Click(object sender, EventArgs e)
        {
            if (currTestIndex >= 0 && currTestIndex < queryNames.Length)
            {
                ++currTestIndex;
                textBoxTestNum.Text = currTestIndex.ToString();
            }
        }

        private void buttonThumbnail_Click(object sender, EventArgs e)
        {

        }

        private void buttonOriginalImg_Click(object sender, EventArgs e)
        {

        }

        private void buttonImgBackward_Click(object sender, EventArgs e)
        {

        }

        private void buttonImgForward_Click(object sender, EventArgs e)
        {

        }

    }
}
