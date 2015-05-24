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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTraining = new System.Windows.Forms.TabPage();
            this.panelTrainOther = new System.Windows.Forms.Panel();
            this.buttonQuickStart = new System.Windows.Forms.Button();
            this.panelTrainQuery = new System.Windows.Forms.Panel();
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
            this.panelShowQueryList = new System.Windows.Forms.Panel();
            this.labelShowQueryList = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageTraining.SuspendLayout();
            this.panelTrainOther.SuspendLayout();
            this.panelTrainQuery.SuspendLayout();
            this.panelTrainImgList.SuspendLayout();
            this.panelShowImgList.SuspendLayout();
            this.panelTrainDataset.SuspendLayout();
            this.panelShowQueryList.SuspendLayout();
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
            this.tabPageTesting.Location = new System.Drawing.Point(4, 34);
            this.tabPageTesting.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTesting.Name = "tabPageTesting";
            this.tabPageTesting.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTesting.Size = new System.Drawing.Size(1552, 792);
            this.tabPageTesting.TabIndex = 1;
            this.tabPageTesting.Text = "Testing";
            this.tabPageTesting.UseVisualStyleBackColor = true;
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
            this.panelTrainImgList.ResumeLayout(false);
            this.panelShowImgList.ResumeLayout(false);
            this.panelShowImgList.PerformLayout();
            this.panelTrainDataset.ResumeLayout(false);
            this.panelShowQueryList.ResumeLayout(false);
            this.panelShowQueryList.PerformLayout();
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
    }
}

