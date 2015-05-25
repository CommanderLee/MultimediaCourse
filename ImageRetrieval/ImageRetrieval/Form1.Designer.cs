namespace ImageRetrieval
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTraining = new System.Windows.Forms.TabPage();
            this.panelTrainOther = new System.Windows.Forms.Panel();
            this.buttonQuickStart = new System.Windows.Forms.Button();
            this.panelTrainQuery = new System.Windows.Forms.Panel();
            this.panelShowQueryList = new System.Windows.Forms.Panel();
            this.labelShowQueryList = new System.Windows.Forms.Label();
            this.labelLoadQueryList = new System.Windows.Forms.Label();
            this.buttonLoadQueryList = new System.Windows.Forms.Button();
            this.panelTrainImgList = new System.Windows.Forms.Panel();
            this.panelShowImgList = new System.Windows.Forms.Panel();
            this.labelShowImgList = new System.Windows.Forms.Label();
            this.labelLoadImgList = new System.Windows.Forms.Label();
            this.buttonLoadImgList = new System.Windows.Forms.Button();
            this.panelTrainDataset = new System.Windows.Forms.Panel();
            this.labelLoadDataset = new System.Windows.Forms.Label();
            this.buttonLoadDataset = new System.Windows.Forms.Button();
            this.tabPageTesting = new System.Windows.Forms.TabPage();
            this.panelShowImg = new System.Windows.Forms.Panel();
            this.pictureBoxShowImg = new System.Windows.Forms.PictureBox();
            this.panelTestButtons = new System.Windows.Forms.Panel();
            this.labelMetrics = new System.Windows.Forms.Label();
            this.textBoxColorB = new System.Windows.Forms.TextBox();
            this.textBoxColorG = new System.Windows.Forms.TextBox();
            this.textBoxColorR = new System.Windows.Forms.TextBox();
            this.labelColorSpace = new System.Windows.Forms.Label();
            this.textBoxTestNum = new System.Windows.Forms.TextBox();
            this.buttonTestForward = new System.Windows.Forms.Button();
            this.buttonTestBackward = new System.Windows.Forms.Button();
            this.buttonImgForward = new System.Windows.Forms.Button();
            this.buttonImgBackward = new System.Windows.Forms.Button();
            this.buttonOriginalImg = new System.Windows.Forms.Button();
            this.buttonThumbnailImg = new System.Windows.Forms.Button();
            this.labelTestResult = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxReturnImgNum = new System.Windows.Forms.TextBox();
            this.labelReturnImgNum = new System.Windows.Forms.Label();
            this.buttonPreProcess = new System.Windows.Forms.Button();
            this.comboBoxMetrics = new System.Windows.Forms.ComboBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageTraining.SuspendLayout();
            this.panelTrainOther.SuspendLayout();
            this.panelTrainQuery.SuspendLayout();
            this.panelShowQueryList.SuspendLayout();
            this.panelTrainImgList.SuspendLayout();
            this.panelShowImgList.SuspendLayout();
            this.panelTrainDataset.SuspendLayout();
            this.tabPageTesting.SuspendLayout();
            this.panelShowImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImg)).BeginInit();
            this.panelTestButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTraining);
            this.tabControlMain.Controls.Add(this.tabPageTesting);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlMain.Location = new System.Drawing.Point(13, 12);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1560, 830);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageTraining
            // 
            this.tabPageTraining.Controls.Add(this.panelTrainOther);
            this.tabPageTraining.Controls.Add(this.panelTrainQuery);
            this.tabPageTraining.Controls.Add(this.panelTrainImgList);
            this.tabPageTraining.Controls.Add(this.panelTrainDataset);
            this.tabPageTraining.Location = new System.Drawing.Point(4, 34);
            this.tabPageTraining.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTraining.Name = "tabPageTraining";
            this.tabPageTraining.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTraining.Size = new System.Drawing.Size(1552, 792);
            this.tabPageTraining.TabIndex = 0;
            this.tabPageTraining.Text = "Training";
            this.tabPageTraining.UseVisualStyleBackColor = true;
            // 
            // panelTrainOther
            // 
            this.panelTrainOther.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panelTrainOther.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrainOther.Controls.Add(this.buttonQuickStart);
            this.panelTrainOther.Location = new System.Drawing.Point(1165, 10);
            this.panelTrainOther.Margin = new System.Windows.Forms.Padding(4);
            this.panelTrainOther.Name = "panelTrainOther";
            this.panelTrainOther.Size = new System.Drawing.Size(375, 770);
            this.panelTrainOther.TabIndex = 3;
            // 
            // buttonQuickStart
            // 
            this.buttonQuickStart.BackColor = System.Drawing.Color.LightCyan;
            this.buttonQuickStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonQuickStart.Location = new System.Drawing.Point(10, 10);
            this.buttonQuickStart.Name = "buttonQuickStart";
            this.buttonQuickStart.Size = new System.Drawing.Size(350, 50);
            this.buttonQuickStart.TabIndex = 3;
            this.buttonQuickStart.Text = "Quick Start";
            this.buttonQuickStart.UseVisualStyleBackColor = false;
            this.buttonQuickStart.Click += new System.EventHandler(this.buttonQuickStart_Click);
            // 
            // panelTrainQuery
            // 
            this.panelTrainQuery.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelTrainQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrainQuery.Controls.Add(this.panelShowQueryList);
            this.panelTrainQuery.Controls.Add(this.labelLoadQueryList);
            this.panelTrainQuery.Controls.Add(this.buttonLoadQueryList);
            this.panelTrainQuery.Location = new System.Drawing.Point(780, 10);
            this.panelTrainQuery.Margin = new System.Windows.Forms.Padding(4);
            this.panelTrainQuery.Name = "panelTrainQuery";
            this.panelTrainQuery.Size = new System.Drawing.Size(375, 770);
            this.panelTrainQuery.TabIndex = 2;
            // 
            // panelShowQueryList
            // 
            this.panelShowQueryList.AutoScroll = true;
            this.panelShowQueryList.Controls.Add(this.labelShowQueryList);
            this.panelShowQueryList.Location = new System.Drawing.Point(10, 250);
            this.panelShowQueryList.Name = "panelShowQueryList";
            this.panelShowQueryList.Size = new System.Drawing.Size(350, 500);
            this.panelShowQueryList.TabIndex = 4;
            // 
            // labelShowQueryList
            // 
            this.labelShowQueryList.AutoSize = true;
            this.labelShowQueryList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelShowQueryList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowQueryList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowQueryList.Location = new System.Drawing.Point(5, 5);
            this.labelShowQueryList.MinimumSize = new System.Drawing.Size(340, 480);
            this.labelShowQueryList.Name = "labelShowQueryList";
            this.labelShowQueryList.Size = new System.Drawing.Size(340, 480);
            this.labelShowQueryList.TabIndex = 3;
            // 
            // labelLoadQueryList
            // 
            this.labelLoadQueryList.BackColor = System.Drawing.Color.Lavender;
            this.labelLoadQueryList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoadQueryList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadQueryList.Location = new System.Drawing.Point(10, 80);
            this.labelLoadQueryList.Name = "labelLoadQueryList";
            this.labelLoadQueryList.Size = new System.Drawing.Size(350, 150);
            this.labelLoadQueryList.TabIndex = 3;
            this.labelLoadQueryList.Text = "Please load the query list (\'txt\' file).";
            // 
            // buttonLoadQueryList
            // 
            this.buttonLoadQueryList.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLoadQueryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLoadQueryList.Location = new System.Drawing.Point(10, 10);
            this.buttonLoadQueryList.Name = "buttonLoadQueryList";
            this.buttonLoadQueryList.Size = new System.Drawing.Size(350, 50);
            this.buttonLoadQueryList.TabIndex = 2;
            this.buttonLoadQueryList.Text = "Load Query List";
            this.buttonLoadQueryList.UseVisualStyleBackColor = false;
            this.buttonLoadQueryList.Click += new System.EventHandler(this.buttonLoadQueryList_Click);
            // 
            // panelTrainImgList
            // 
            this.panelTrainImgList.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTrainImgList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrainImgList.Controls.Add(this.panelShowImgList);
            this.panelTrainImgList.Controls.Add(this.labelLoadImgList);
            this.panelTrainImgList.Controls.Add(this.buttonLoadImgList);
            this.panelTrainImgList.Location = new System.Drawing.Point(395, 10);
            this.panelTrainImgList.Margin = new System.Windows.Forms.Padding(4);
            this.panelTrainImgList.Name = "panelTrainImgList";
            this.panelTrainImgList.Size = new System.Drawing.Size(375, 770);
            this.panelTrainImgList.TabIndex = 1;
            // 
            // panelShowImgList
            // 
            this.panelShowImgList.AutoScroll = true;
            this.panelShowImgList.Controls.Add(this.labelShowImgList);
            this.panelShowImgList.Location = new System.Drawing.Point(10, 250);
            this.panelShowImgList.Name = "panelShowImgList";
            this.panelShowImgList.Size = new System.Drawing.Size(350, 500);
            this.panelShowImgList.TabIndex = 3;
            // 
            // labelShowImgList
            // 
            this.labelShowImgList.AutoSize = true;
            this.labelShowImgList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelShowImgList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowImgList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowImgList.Location = new System.Drawing.Point(5, 5);
            this.labelShowImgList.MinimumSize = new System.Drawing.Size(340, 480);
            this.labelShowImgList.Name = "labelShowImgList";
            this.labelShowImgList.Size = new System.Drawing.Size(340, 480);
            this.labelShowImgList.TabIndex = 3;
            // 
            // labelLoadImgList
            // 
            this.labelLoadImgList.BackColor = System.Drawing.Color.Lavender;
            this.labelLoadImgList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoadImgList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadImgList.Location = new System.Drawing.Point(10, 80);
            this.labelLoadImgList.Name = "labelLoadImgList";
            this.labelLoadImgList.Size = new System.Drawing.Size(350, 150);
            this.labelLoadImgList.TabIndex = 2;
            this.labelLoadImgList.Text = "Please load the image list (\'txt\' file).";
            // 
            // buttonLoadImgList
            // 
            this.buttonLoadImgList.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLoadImgList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLoadImgList.Location = new System.Drawing.Point(10, 10);
            this.buttonLoadImgList.Name = "buttonLoadImgList";
            this.buttonLoadImgList.Size = new System.Drawing.Size(350, 50);
            this.buttonLoadImgList.TabIndex = 1;
            this.buttonLoadImgList.Text = "Load Image List";
            this.buttonLoadImgList.UseVisualStyleBackColor = false;
            this.buttonLoadImgList.Click += new System.EventHandler(this.buttonLoadImgList_Click);
            // 
            // panelTrainDataset
            // 
            this.panelTrainDataset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTrainDataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrainDataset.Controls.Add(this.labelLoadDataset);
            this.panelTrainDataset.Controls.Add(this.buttonLoadDataset);
            this.panelTrainDataset.Location = new System.Drawing.Point(10, 10);
            this.panelTrainDataset.Margin = new System.Windows.Forms.Padding(4);
            this.panelTrainDataset.Name = "panelTrainDataset";
            this.panelTrainDataset.Size = new System.Drawing.Size(375, 770);
            this.panelTrainDataset.TabIndex = 0;
            // 
            // labelLoadDataset
            // 
            this.labelLoadDataset.BackColor = System.Drawing.Color.Lavender;
            this.labelLoadDataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoadDataset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadDataset.Location = new System.Drawing.Point(10, 80);
            this.labelLoadDataset.Name = "labelLoadDataset";
            this.labelLoadDataset.Size = new System.Drawing.Size(350, 150);
            this.labelLoadDataset.TabIndex = 1;
            this.labelLoadDataset.Text = "Please load the classified image dataset.";
            // 
            // buttonLoadDataset
            // 
            this.buttonLoadDataset.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLoadDataset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLoadDataset.Location = new System.Drawing.Point(10, 10);
            this.buttonLoadDataset.Name = "buttonLoadDataset";
            this.buttonLoadDataset.Size = new System.Drawing.Size(350, 50);
            this.buttonLoadDataset.TabIndex = 0;
            this.buttonLoadDataset.Text = "Load Dataset";
            this.buttonLoadDataset.UseVisualStyleBackColor = false;
            this.buttonLoadDataset.Click += new System.EventHandler(this.buttonLoadDataset_Click);
            // 
            // tabPageTesting
            // 
            this.tabPageTesting.Controls.Add(this.panelShowImg);
            this.tabPageTesting.Controls.Add(this.panelTestButtons);
            this.tabPageTesting.Location = new System.Drawing.Point(4, 34);
            this.tabPageTesting.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTesting.Name = "tabPageTesting";
            this.tabPageTesting.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTesting.Size = new System.Drawing.Size(1552, 792);
            this.tabPageTesting.TabIndex = 1;
            this.tabPageTesting.Text = "Testing";
            this.tabPageTesting.UseVisualStyleBackColor = true;
            // 
            // panelShowImg
            // 
            this.panelShowImg.AutoScroll = true;
            this.panelShowImg.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelShowImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShowImg.Controls.Add(this.pictureBoxShowImg);
            this.panelShowImg.Location = new System.Drawing.Point(395, 10);
            this.panelShowImg.Margin = new System.Windows.Forms.Padding(4);
            this.panelShowImg.Name = "panelShowImg";
            this.panelShowImg.Size = new System.Drawing.Size(1140, 770);
            this.panelShowImg.TabIndex = 2;
            // 
            // pictureBoxShowImg
            // 
            this.pictureBoxShowImg.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxShowImg.Name = "pictureBoxShowImg";
            this.pictureBoxShowImg.Size = new System.Drawing.Size(1100, 730);
            this.pictureBoxShowImg.TabIndex = 0;
            this.pictureBoxShowImg.TabStop = false;
            // 
            // panelTestButtons
            // 
            this.panelTestButtons.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTestButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTestButtons.Controls.Add(this.comboBoxMetrics);
            this.panelTestButtons.Controls.Add(this.labelMetrics);
            this.panelTestButtons.Controls.Add(this.textBoxColorB);
            this.panelTestButtons.Controls.Add(this.textBoxColorG);
            this.panelTestButtons.Controls.Add(this.textBoxColorR);
            this.panelTestButtons.Controls.Add(this.labelColorSpace);
            this.panelTestButtons.Controls.Add(this.textBoxTestNum);
            this.panelTestButtons.Controls.Add(this.buttonTestForward);
            this.panelTestButtons.Controls.Add(this.buttonTestBackward);
            this.panelTestButtons.Controls.Add(this.buttonImgForward);
            this.panelTestButtons.Controls.Add(this.buttonImgBackward);
            this.panelTestButtons.Controls.Add(this.buttonOriginalImg);
            this.panelTestButtons.Controls.Add(this.buttonThumbnailImg);
            this.panelTestButtons.Controls.Add(this.labelTestResult);
            this.panelTestButtons.Controls.Add(this.buttonTest);
            this.panelTestButtons.Controls.Add(this.textBoxReturnImgNum);
            this.panelTestButtons.Controls.Add(this.labelReturnImgNum);
            this.panelTestButtons.Controls.Add(this.buttonPreProcess);
            this.panelTestButtons.Location = new System.Drawing.Point(10, 10);
            this.panelTestButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelTestButtons.Name = "panelTestButtons";
            this.panelTestButtons.Size = new System.Drawing.Size(375, 770);
            this.panelTestButtons.TabIndex = 1;
            // 
            // labelMetrics
            // 
            this.labelMetrics.BackColor = System.Drawing.Color.Lavender;
            this.labelMetrics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMetrics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetrics.Location = new System.Drawing.Point(10, 290);
            this.labelMetrics.Name = "labelMetrics";
            this.labelMetrics.Size = new System.Drawing.Size(350, 50);
            this.labelMetrics.TabIndex = 16;
            this.labelMetrics.Text = "Distance Metrics:";
            this.labelMetrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxColorB
            // 
            this.textBoxColorB.Location = new System.Drawing.Point(325, 230);
            this.textBoxColorB.Name = "textBoxColorB";
            this.textBoxColorB.Size = new System.Drawing.Size(30, 30);
            this.textBoxColorB.TabIndex = 15;
            this.textBoxColorB.Text = "2";
            this.textBoxColorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxColorG
            // 
            this.textBoxColorG.Location = new System.Drawing.Point(275, 230);
            this.textBoxColorG.Name = "textBoxColorG";
            this.textBoxColorG.Size = new System.Drawing.Size(30, 30);
            this.textBoxColorG.TabIndex = 14;
            this.textBoxColorG.Text = "4";
            this.textBoxColorG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxColorR
            // 
            this.textBoxColorR.Location = new System.Drawing.Point(225, 230);
            this.textBoxColorR.Name = "textBoxColorR";
            this.textBoxColorR.Size = new System.Drawing.Size(30, 30);
            this.textBoxColorR.TabIndex = 13;
            this.textBoxColorR.Text = "2";
            this.textBoxColorR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelColorSpace
            // 
            this.labelColorSpace.BackColor = System.Drawing.Color.Lavender;
            this.labelColorSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelColorSpace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorSpace.Location = new System.Drawing.Point(10, 220);
            this.labelColorSpace.Name = "labelColorSpace";
            this.labelColorSpace.Size = new System.Drawing.Size(350, 50);
            this.labelColorSpace.TabIndex = 12;
            this.labelColorSpace.Text = "Color Space Partitioning:      R          G           B";
            this.labelColorSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTestNum
            // 
            this.textBoxTestNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTestNum.Location = new System.Drawing.Point(230, 159);
            this.textBoxTestNum.Name = "textBoxTestNum";
            this.textBoxTestNum.Size = new System.Drawing.Size(80, 35);
            this.textBoxTestNum.TabIndex = 11;
            this.textBoxTestNum.Text = "1";
            // 
            // buttonTestForward
            // 
            this.buttonTestForward.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonTestForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTestForward.BackgroundImage")));
            this.buttonTestForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTestForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTestForward.Location = new System.Drawing.Point(310, 150);
            this.buttonTestForward.Name = "buttonTestForward";
            this.buttonTestForward.Size = new System.Drawing.Size(50, 50);
            this.buttonTestForward.TabIndex = 10;
            this.buttonTestForward.UseVisualStyleBackColor = false;
            this.buttonTestForward.Click += new System.EventHandler(this.buttonTestForward_Click);
            // 
            // buttonTestBackward
            // 
            this.buttonTestBackward.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonTestBackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTestBackward.BackgroundImage")));
            this.buttonTestBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTestBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTestBackward.Location = new System.Drawing.Point(10, 150);
            this.buttonTestBackward.Name = "buttonTestBackward";
            this.buttonTestBackward.Size = new System.Drawing.Size(50, 50);
            this.buttonTestBackward.TabIndex = 9;
            this.buttonTestBackward.UseVisualStyleBackColor = false;
            this.buttonTestBackward.Click += new System.EventHandler(this.buttonTestBackward_Click);
            // 
            // buttonImgForward
            // 
            this.buttonImgForward.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonImgForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImgForward.BackgroundImage")));
            this.buttonImgForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonImgForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonImgForward.Location = new System.Drawing.Point(310, 600);
            this.buttonImgForward.Name = "buttonImgForward";
            this.buttonImgForward.Size = new System.Drawing.Size(50, 50);
            this.buttonImgForward.TabIndex = 8;
            this.buttonImgForward.UseVisualStyleBackColor = false;
            this.buttonImgForward.Click += new System.EventHandler(this.buttonImgForward_Click);
            // 
            // buttonImgBackward
            // 
            this.buttonImgBackward.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonImgBackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImgBackward.BackgroundImage")));
            this.buttonImgBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonImgBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonImgBackward.Location = new System.Drawing.Point(10, 600);
            this.buttonImgBackward.Name = "buttonImgBackward";
            this.buttonImgBackward.Size = new System.Drawing.Size(50, 50);
            this.buttonImgBackward.TabIndex = 7;
            this.buttonImgBackward.UseVisualStyleBackColor = false;
            this.buttonImgBackward.Click += new System.EventHandler(this.buttonImgBackward_Click);
            // 
            // buttonOriginalImg
            // 
            this.buttonOriginalImg.BackColor = System.Drawing.Color.LightCyan;
            this.buttonOriginalImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOriginalImg.Location = new System.Drawing.Point(60, 600);
            this.buttonOriginalImg.Name = "buttonOriginalImg";
            this.buttonOriginalImg.Size = new System.Drawing.Size(250, 50);
            this.buttonOriginalImg.TabIndex = 6;
            this.buttonOriginalImg.Text = "Show Original Image";
            this.buttonOriginalImg.UseVisualStyleBackColor = false;
            this.buttonOriginalImg.Click += new System.EventHandler(this.buttonOriginalImg_Click);
            // 
            // buttonThumbnailImg
            // 
            this.buttonThumbnailImg.BackColor = System.Drawing.Color.LightCyan;
            this.buttonThumbnailImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonThumbnailImg.Location = new System.Drawing.Point(10, 530);
            this.buttonThumbnailImg.Name = "buttonThumbnailImg";
            this.buttonThumbnailImg.Size = new System.Drawing.Size(350, 50);
            this.buttonThumbnailImg.TabIndex = 5;
            this.buttonThumbnailImg.Text = "Show Thumbnail Image";
            this.buttonThumbnailImg.UseVisualStyleBackColor = false;
            this.buttonThumbnailImg.Click += new System.EventHandler(this.buttonThumbnail_Click);
            // 
            // labelTestResult
            // 
            this.labelTestResult.BackColor = System.Drawing.Color.Lavender;
            this.labelTestResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTestResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestResult.Location = new System.Drawing.Point(10, 360);
            this.labelTestResult.Name = "labelTestResult";
            this.labelTestResult.Size = new System.Drawing.Size(350, 150);
            this.labelTestResult.TabIndex = 4;
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.Color.LightCyan;
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTest.Location = new System.Drawing.Point(60, 150);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(170, 50);
            this.buttonTest.TabIndex = 3;
            this.buttonTest.Text = "Test No.";
            this.buttonTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxReturnImgNum
            // 
            this.textBoxReturnImgNum.Location = new System.Drawing.Point(103, 86);
            this.textBoxReturnImgNum.Name = "textBoxReturnImgNum";
            this.textBoxReturnImgNum.Size = new System.Drawing.Size(100, 30);
            this.textBoxReturnImgNum.TabIndex = 2;
            this.textBoxReturnImgNum.Text = "30";
            this.textBoxReturnImgNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelReturnImgNum
            // 
            this.labelReturnImgNum.BackColor = System.Drawing.Color.Lavender;
            this.labelReturnImgNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReturnImgNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnImgNum.Location = new System.Drawing.Point(10, 80);
            this.labelReturnImgNum.Name = "labelReturnImgNum";
            this.labelReturnImgNum.Size = new System.Drawing.Size(350, 50);
            this.labelReturnImgNum.TabIndex = 1;
            this.labelReturnImgNum.Text = "Return                    images.";
            // 
            // buttonPreProcess
            // 
            this.buttonPreProcess.BackColor = System.Drawing.Color.LightCyan;
            this.buttonPreProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPreProcess.Location = new System.Drawing.Point(10, 10);
            this.buttonPreProcess.Name = "buttonPreProcess";
            this.buttonPreProcess.Size = new System.Drawing.Size(350, 50);
            this.buttonPreProcess.TabIndex = 0;
            this.buttonPreProcess.Text = "Pre-Process";
            this.buttonPreProcess.UseVisualStyleBackColor = false;
            this.buttonPreProcess.Click += new System.EventHandler(this.buttonPreProcess_Click);
            // 
            // comboBoxMetrics
            // 
            this.comboBoxMetrics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetrics.FormattingEnabled = true;
            this.comboBoxMetrics.Items.AddRange(new object[] {
            "Euclidean (L2)",
            "Histogram Intersection (HI)",
            "Bhattacharyya (Bh)"});
            this.comboBoxMetrics.Location = new System.Drawing.Point(150, 299);
            this.comboBoxMetrics.Name = "comboBoxMetrics";
            this.comboBoxMetrics.Size = new System.Drawing.Size(200, 33);
            this.comboBoxMetrics.TabIndex = 17;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTraining.ResumeLayout(false);
            this.panelTrainOther.ResumeLayout(false);
            this.panelTrainQuery.ResumeLayout(false);
            this.panelShowQueryList.ResumeLayout(false);
            this.panelShowQueryList.PerformLayout();
            this.panelTrainImgList.ResumeLayout(false);
            this.panelShowImgList.ResumeLayout(false);
            this.panelShowImgList.PerformLayout();
            this.panelTrainDataset.ResumeLayout(false);
            this.tabPageTesting.ResumeLayout(false);
            this.panelShowImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImg)).EndInit();
            this.panelTestButtons.ResumeLayout(false);
            this.panelTestButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTraining;
        private System.Windows.Forms.TabPage tabPageTesting;
        private System.Windows.Forms.Panel panelTrainDataset;
        private System.Windows.Forms.Panel panelTrainImgList;
        private System.Windows.Forms.Panel panelTrainQuery;
        private System.Windows.Forms.Panel panelTrainOther;
        private System.Windows.Forms.Button buttonLoadDataset;
        private System.Windows.Forms.Button buttonLoadImgList;
        private System.Windows.Forms.Button buttonLoadQueryList;
        private System.Windows.Forms.Label labelLoadDataset;
        private System.Windows.Forms.Button buttonQuickStart;
        private System.Windows.Forms.Label labelLoadImgList;
        private System.Windows.Forms.Label labelLoadQueryList;
        private System.Windows.Forms.Label labelShowImgList;
        private System.Windows.Forms.Panel panelShowImgList;
        private System.Windows.Forms.Panel panelShowQueryList;
        private System.Windows.Forms.Label labelShowQueryList;
        private System.Windows.Forms.Panel panelTestButtons;
        private System.Windows.Forms.Label labelReturnImgNum;
        private System.Windows.Forms.Button buttonPreProcess;
        private System.Windows.Forms.TextBox textBoxReturnImgNum;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelTestResult;
        private System.Windows.Forms.Panel panelShowImg;
        private System.Windows.Forms.PictureBox pictureBoxShowImg;
        private System.Windows.Forms.Button buttonThumbnailImg;
        private System.Windows.Forms.Button buttonOriginalImg;
        private System.Windows.Forms.Button buttonImgBackward;
        private System.Windows.Forms.Button buttonImgForward;
        private System.Windows.Forms.Button buttonTestBackward;
        private System.Windows.Forms.Button buttonTestForward;
        private System.Windows.Forms.TextBox textBoxTestNum;
        private System.Windows.Forms.Label labelColorSpace;
        private System.Windows.Forms.TextBox textBoxColorR;
        private System.Windows.Forms.TextBox textBoxColorG;
        private System.Windows.Forms.TextBox textBoxColorB;
        private System.Windows.Forms.Label labelMetrics;
        private System.Windows.Forms.ComboBox comboBoxMetrics;
    }
}

