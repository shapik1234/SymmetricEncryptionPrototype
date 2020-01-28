namespace FileStoragePOC
    {
    partial class DataTransferDiagnosting
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if(disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTransferDiagnosting));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectTodatabaseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ConnectedServerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatabasesDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.DatabaseConnectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewCommonResult = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxEncryption = new System.Windows.Forms.CheckBox();
            this.groupBoxFileSize = new System.Windows.Forms.GroupBox();
            this.openFolder = new System.Windows.Forms.Button();
            this.radioButtonExtraLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBoxIO = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.groupBoxTypeReadWrite = new System.Windows.Forms.GroupBox();
            this.numericUpDownCountThread = new System.Windows.Forms.NumericUpDown();
            this.radioButtonMultThread = new System.Windows.Forms.RadioButton();
            this.radioButtonbulks = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.groupBoxTypes = new System.Windows.Forms.GroupBox();
            this.radioButtonFS = new System.Windows.Forms.RadioButton();
            this.radioButtonBLOB = new System.Windows.Forms.RadioButton();
            this.MenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommonResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBoxParams.SuspendLayout();
            this.groupBoxFileSize.SuspendLayout();
            this.groupBoxIO.SuspendLayout();
            this.groupBoxTypeReadWrite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountThread)).BeginInit();
            this.groupBoxTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1123, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Database";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectTodatabaseStripMenuItem,
            this.createDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.dataBaseToolStripMenuItem.Text = "Connection";
            // 
            // connectTodatabaseStripMenuItem
            // 
            this.connectTodatabaseStripMenuItem.Name = "connectTodatabaseStripMenuItem";
            this.connectTodatabaseStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.connectTodatabaseStripMenuItem.Text = "New connection";
            this.connectTodatabaseStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.createDatabaseToolStripMenuItem.Text = "Create database";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectedServerStatusLabel,
            this.DatabasesDropDownButton});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1123, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ConnectedServerStatusLabel
            // 
            this.ConnectedServerStatusLabel.Name = "ConnectedServerStatusLabel";
            this.ConnectedServerStatusLabel.Size = new System.Drawing.Size(119, 17);
            this.ConnectedServerStatusLabel.Text = "No Server Connected";
            // 
            // DatabasesDropDownButton
            // 
            this.DatabasesDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DatabasesDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatabaseConnectedToolStripMenuItem});
            this.DatabasesDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("DatabasesDropDownButton.Image")));
            this.DatabasesDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DatabasesDropDownButton.Name = "DatabasesDropDownButton";
            this.DatabasesDropDownButton.Size = new System.Drawing.Size(148, 20);
            this.DatabasesDropDownButton.Text = "No Database Connected";
            this.DatabasesDropDownButton.Click += new System.EventHandler(this.DatabasesDropDownButton_Click);
            // 
            // DatabaseConnectedToolStripMenuItem
            // 
            this.DatabaseConnectedToolStripMenuItem.Name = "DatabaseConnectedToolStripMenuItem";
            this.DatabaseConnectedToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.DatabaseConnectedToolStripMenuItem.Text = "No Database Connected";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 472);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxResult);
            this.tabPage1.Controls.Add(this.groupBoxParams);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1115, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridViewCommonResult);
            this.groupBoxResult.Controls.Add(this.dataGridViewResult);
            this.groupBoxResult.Location = new System.Drawing.Point(237, 8);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(874, 432);
            this.groupBoxResult.TabIndex = 8;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Results";
            // 
            // dataGridViewCommonResult
            // 
            this.dataGridViewCommonResult.AllowUserToAddRows = false;
            this.dataGridViewCommonResult.AllowUserToDeleteRows = false;
            this.dataGridViewCommonResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCommonResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommonResult.Location = new System.Drawing.Point(537, 19);
            this.dataGridViewCommonResult.Name = "dataGridViewCommonResult";
            this.dataGridViewCommonResult.ReadOnly = true;
            this.dataGridViewCommonResult.RowHeadersVisible = false;
            this.dataGridViewCommonResult.Size = new System.Drawing.Size(331, 407);
            this.dataGridViewCommonResult.TabIndex = 7;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.Size = new System.Drawing.Size(514, 407);
            this.dataGridViewResult.TabIndex = 6;
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxEncryption);
            this.groupBoxParams.Controls.Add(this.groupBoxFileSize);
            this.groupBoxParams.Controls.Add(this.buttonRun);
            this.groupBoxParams.Controls.Add(this.groupBoxIO);
            this.groupBoxParams.Controls.Add(this.groupBoxTypeReadWrite);
            this.groupBoxParams.Controls.Add(this.groupBoxTypes);
            this.groupBoxParams.Location = new System.Drawing.Point(9, 6);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(222, 434);
            this.groupBoxParams.TabIndex = 7;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Params";
            // 
            // checkBoxEncryption
            // 
            this.checkBoxEncryption.AutoSize = true;
            this.checkBoxEncryption.Location = new System.Drawing.Point(9, 19);
            this.checkBoxEncryption.Name = "checkBoxEncryption";
            this.checkBoxEncryption.Size = new System.Drawing.Size(76, 17);
            this.checkBoxEncryption.TabIndex = 0;
            this.checkBoxEncryption.Text = "Encryption";
            this.checkBoxEncryption.UseVisualStyleBackColor = true;
            // 
            // groupBoxFileSize
            // 
            this.groupBoxFileSize.Controls.Add(this.openFolder);
            this.groupBoxFileSize.Controls.Add(this.radioButtonExtraLarge);
            this.groupBoxFileSize.Controls.Add(this.radioButtonLarge);
            this.groupBoxFileSize.Controls.Add(this.radioButtonMedium);
            this.groupBoxFileSize.Controls.Add(this.radioButtonSmall);
            this.groupBoxFileSize.Location = new System.Drawing.Point(9, 42);
            this.groupBoxFileSize.Name = "groupBoxFileSize";
            this.groupBoxFileSize.Size = new System.Drawing.Size(200, 121);
            this.groupBoxFileSize.TabIndex = 1;
            this.groupBoxFileSize.TabStop = false;
            this.groupBoxFileSize.Text = "File Size";
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(119, 20);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(75, 23);
            this.openFolder.TabIndex = 2;
            this.openFolder.Text = "Open Folder";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // radioButtonExtraLarge
            // 
            this.radioButtonExtraLarge.AutoSize = true;
            this.radioButtonExtraLarge.Location = new System.Drawing.Point(7, 89);
            this.radioButtonExtraLarge.Name = "radioButtonExtraLarge";
            this.radioButtonExtraLarge.Size = new System.Drawing.Size(115, 17);
            this.radioButtonExtraLarge.TabIndex = 3;
            this.radioButtonExtraLarge.TabStop = true;
            this.radioButtonExtraLarge.Text = "ExtraLarge: >10Mb";
            this.radioButtonExtraLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(7, 66);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(94, 17);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large: 3-10Mb";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(7, 43);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(98, 17);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium: 1-3Mb";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(7, 20);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Small: < 1Mb";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(65, 394);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // groupBoxIO
            // 
            this.groupBoxIO.Controls.Add(this.radioButton7);
            this.groupBoxIO.Controls.Add(this.radioButton8);
            this.groupBoxIO.Location = new System.Drawing.Point(9, 169);
            this.groupBoxIO.Name = "groupBoxIO";
            this.groupBoxIO.Size = new System.Drawing.Size(200, 55);
            this.groupBoxIO.TabIndex = 2;
            this.groupBoxIO.TabStop = false;
            this.groupBoxIO.Text = "IO";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(96, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(50, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Write";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 20);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(51, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Read";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // groupBoxTypeReadWrite
            // 
            this.groupBoxTypeReadWrite.Controls.Add(this.numericUpDownCountThread);
            this.groupBoxTypeReadWrite.Controls.Add(this.radioButtonMultThread);
            this.groupBoxTypeReadWrite.Controls.Add(this.radioButtonbulks);
            this.groupBoxTypeReadWrite.Controls.Add(this.radioButtonSingle);
            this.groupBoxTypeReadWrite.Location = new System.Drawing.Point(9, 230);
            this.groupBoxTypeReadWrite.Name = "groupBoxTypeReadWrite";
            this.groupBoxTypeReadWrite.Size = new System.Drawing.Size(200, 99);
            this.groupBoxTypeReadWrite.TabIndex = 4;
            this.groupBoxTypeReadWrite.TabStop = false;
            this.groupBoxTypeReadWrite.Text = "Type Read/Write";
            // 
            // numericUpDownCountThread
            // 
            this.numericUpDownCountThread.Location = new System.Drawing.Point(96, 65);
            this.numericUpDownCountThread.Name = "numericUpDownCountThread";
            this.numericUpDownCountThread.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownCountThread.TabIndex = 3;
            this.numericUpDownCountThread.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // radioButtonMultThread
            // 
            this.radioButtonMultThread.AutoSize = true;
            this.radioButtonMultThread.Location = new System.Drawing.Point(7, 66);
            this.radioButtonMultThread.Name = "radioButtonMultThread";
            this.radioButtonMultThread.Size = new System.Drawing.Size(84, 17);
            this.radioButtonMultThread.TabIndex = 2;
            this.radioButtonMultThread.TabStop = true;
            this.radioButtonMultThread.Text = "Multi Thread";
            this.radioButtonMultThread.UseVisualStyleBackColor = true;
            // 
            // radioButtonbulks
            // 
            this.radioButtonbulks.AutoSize = true;
            this.radioButtonbulks.Location = new System.Drawing.Point(7, 43);
            this.radioButtonbulks.Name = "radioButtonbulks";
            this.radioButtonbulks.Size = new System.Drawing.Size(46, 17);
            this.radioButtonbulks.TabIndex = 1;
            this.radioButtonbulks.TabStop = true;
            this.radioButtonbulks.Text = "Bulk";
            this.radioButtonbulks.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(7, 20);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSingle.TabIndex = 0;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // groupBoxTypes
            // 
            this.groupBoxTypes.Controls.Add(this.radioButtonFS);
            this.groupBoxTypes.Controls.Add(this.radioButtonBLOB);
            this.groupBoxTypes.Location = new System.Drawing.Point(9, 335);
            this.groupBoxTypes.Name = "groupBoxTypes";
            this.groupBoxTypes.Size = new System.Drawing.Size(200, 53);
            this.groupBoxTypes.TabIndex = 3;
            this.groupBoxTypes.TabStop = false;
            this.groupBoxTypes.Text = "Type";
            // 
            // radioButtonFS
            // 
            this.radioButtonFS.AutoSize = true;
            this.radioButtonFS.Location = new System.Drawing.Point(96, 20);
            this.radioButtonFS.Name = "radioButtonFS";
            this.radioButtonFS.Size = new System.Drawing.Size(74, 17);
            this.radioButtonFS.TabIndex = 1;
            this.radioButtonFS.TabStop = true;
            this.radioButtonFS.Text = "FileStream";
            this.radioButtonFS.UseVisualStyleBackColor = true;
            // 
            // radioButtonBLOB
            // 
            this.radioButtonBLOB.AutoSize = true;
            this.radioButtonBLOB.Location = new System.Drawing.Point(7, 20);
            this.radioButtonBLOB.Name = "radioButtonBLOB";
            this.radioButtonBLOB.Size = new System.Drawing.Size(53, 17);
            this.radioButtonBLOB.TabIndex = 0;
            this.radioButtonBLOB.TabStop = true;
            this.radioButtonBLOB.Text = "BLOB";
            this.radioButtonBLOB.UseVisualStyleBackColor = true;
            // 
            // DataTransferDiagnosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 521);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "DataTransferDiagnosting";
            this.Text = "Data Transfer Diagnosting";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommonResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            this.groupBoxFileSize.ResumeLayout(false);
            this.groupBoxFileSize.PerformLayout();
            this.groupBoxIO.ResumeLayout(false);
            this.groupBoxIO.PerformLayout();
            this.groupBoxTypeReadWrite.ResumeLayout(false);
            this.groupBoxTypeReadWrite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountThread)).EndInit();
            this.groupBoxTypes.ResumeLayout(false);
            this.groupBoxTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectTodatabaseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ConnectedServerStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton DatabasesDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem DatabaseConnectedToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dataGridViewCommonResult;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.CheckBox checkBoxEncryption;
        private System.Windows.Forms.GroupBox groupBoxFileSize;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.RadioButton radioButtonExtraLarge;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBoxIO;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.GroupBox groupBoxTypeReadWrite;
        private System.Windows.Forms.NumericUpDown numericUpDownCountThread;
        private System.Windows.Forms.RadioButton radioButtonMultThread;
        private System.Windows.Forms.RadioButton radioButtonbulks;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.GroupBox groupBoxTypes;
        private System.Windows.Forms.RadioButton radioButtonFS;
        private System.Windows.Forms.RadioButton radioButtonBLOB;
    }
    }

