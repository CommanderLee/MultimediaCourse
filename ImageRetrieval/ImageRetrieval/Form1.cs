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
        int             currTextIndex;

        DistanceMetrics currMetrics;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            myImages = new List<MyImage>();
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
            for (var i = 0; i < imgNames.Length; ++i)
            {
                if (imgNames[i].Length > 1)
                {
                    string[] imgNameParam = imgNames[i].Split(' ');
                    if (imgNameParam.Length == 3)
                    {
                        string imgName = imgNameParam[0];
                        int width = Convert.ToInt32(imgNameParam[1]);
                        int height = Convert.ToInt32(imgNameParam[2]);

                        string fullFileName = datasetFolder + '\\' + imgName.Replace('/', '\\');
                        //Console.WriteLine(fullFileName + "   " + width + "   " + height);

                        MyImage myImage = new MyImage(fullFileName, imgName, width, height);
                        myImage.hash(colorPartB, colorPartG, colorPartR);
                        myImages.Add(myImage);
                    }
                }
            }

            labelTestResult.Text = "Pre-Process finished.";
            pictureBoxShowImg.Image = myImages[0].image.ToBitmap();
            Console.WriteLine("Load " + myImages.Count + " images.");
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            // Check parameters
            try
            {
                returnImgNum = Convert.ToInt32(textBoxReturnImgNum.Text);

                currTextIndex = Convert.ToInt32(textBoxTestNum.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Source);
                MessageBox.Show("Please input NUMBERS in the text box.");
                return ;
            }

            string selected = comboBoxMetrics.GetItemText(comboBoxMetrics.SelectedItem);
            if (selected == "Euclidean (L2)")
            {
                currMetrics = DistanceMetrics.L2
            }
            else if (selected == "Histogram Intersection (HI)")
            {
                currMetrics = DistanceMetrics.HI;
            }
            else if (selected == "Bhattacharyya (Bh)")
            {
                currMetrics = DistanceMetrics.Bh;
            }
            else
            {
                Console.WriteLine("Please select a distance metric");
                return;
            }

            // Start testing

        }

        private void buttonTestBackward_Click(object sender, EventArgs e)
        {

        }

        private void buttonTestForward_Click(object sender, EventArgs e)
        {

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
