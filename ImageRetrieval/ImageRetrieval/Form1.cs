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

        string      datasetFolder;
        string[]    imgNames, queryNames;

        /** Tab 2: Testing **/


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        /** Tab 1: Training **/

        private void buttonLoadDataset_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                datasetFolder = openFolder.SelectedPath;
                labelLoadDataset.Text = "Load dataset from: " + datasetFolder;
            }
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
        }

        private void buttonQuickStart_Click(object sender, EventArgs e)
        {

        }

        /** Tab 2: Testing **/

        private void buttonPreProcess_Click(object sender, EventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

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
