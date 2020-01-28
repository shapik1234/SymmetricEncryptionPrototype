namespace FileStoragePOC
    {
    partial class AddNewDataBaseForm
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
            this.NewDatabaseNameLabel = new System.Windows.Forms.Label();
            this.NewDataBaseNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateDataBaseButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewDatabaseNameLabel
            // 
            this.NewDatabaseNameLabel.AutoSize = true;
            this.NewDatabaseNameLabel.Location = new System.Drawing.Point(23, 31);
            this.NewDatabaseNameLabel.Name = "NewDatabaseNameLabel";
            this.NewDatabaseNameLabel.Size = new System.Drawing.Size(131, 13);
            this.NewDatabaseNameLabel.TabIndex = 0;
            this.NewDatabaseNameLabel.Text = "Enter new database name";
            // 
            // NewDataBaseNameTextBox
            // 
            this.NewDataBaseNameTextBox.Location = new System.Drawing.Point(160, 28);
            this.NewDataBaseNameTextBox.Name = "NewDataBaseNameTextBox";
            this.NewDataBaseNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.NewDataBaseNameTextBox.TabIndex = 1;
            // 
            // CreateDataBaseButton
            // 
            this.CreateDataBaseButton.Location = new System.Drawing.Point(127, 72);
            this.CreateDataBaseButton.Name = "CreateDataBaseButton";
            this.CreateDataBaseButton.Size = new System.Drawing.Size(75, 23);
            this.CreateDataBaseButton.TabIndex = 2;
            this.CreateDataBaseButton.Text = "Create";
            this.CreateDataBaseButton.UseVisualStyleBackColor = true;
            this.CreateDataBaseButton.Click += new System.EventHandler(this.CreateDataBaseButton_Click);
            // 
            // CanselButton
            // 
            this.CanselButton.Location = new System.Drawing.Point(224, 72);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(75, 23);
            this.CanselButton.TabIndex = 3;
            this.CanselButton.Text = "Cancel";
            this.CanselButton.UseVisualStyleBackColor = true;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // AddNewDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 127);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.CreateDataBaseButton);
            this.Controls.Add(this.NewDataBaseNameTextBox);
            this.Controls.Add(this.NewDatabaseNameLabel);
            this.Name = "AddNewDataBaseForm";
            this.Text = "Add New Database";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label NewDatabaseNameLabel;
        private System.Windows.Forms.TextBox NewDataBaseNameTextBox;
        private System.Windows.Forms.Button CreateDataBaseButton;
        private System.Windows.Forms.Button CanselButton;
        }
    }