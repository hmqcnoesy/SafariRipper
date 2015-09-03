namespace SafariRipper
{
    partial class UserControlSafariRipper
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkClearSessions = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrls = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXpathNodesToRemove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Location:";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(22, 377);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(431, 20);
            this.txtSaveLocation.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(459, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnClickSaveButton);
            // 
            // chkClearSessions
            // 
            this.chkClearSessions.AutoSize = true;
            this.chkClearSessions.Location = new System.Drawing.Point(22, 419);
            this.chkClearSessions.Name = "chkClearSessions";
            this.chkClearSessions.Size = new System.Drawing.Size(156, 17);
            this.chkClearSessions.TabIndex = 3;
            this.chkClearSessions.Text = "Clear all sessions after save";
            this.chkClearSessions.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Process URLs matching:";
            // 
            // txtUrls
            // 
            this.txtUrls.Location = new System.Drawing.Point(22, 43);
            this.txtUrls.Multiline = true;
            this.txtUrls.Name = "txtUrls";
            this.txtUrls.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrls.Size = new System.Drawing.Size(431, 73);
            this.txtUrls.TabIndex = 4;
            this.txtUrls.Text = "safaribooksonline.com/library/view/\r\nsafaribooksonline.com/nest/epub/block/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "XPath Nodes to Remove:";
            // 
            // txtXpathNodesToRemove
            // 
            this.txtXpathNodesToRemove.Location = new System.Drawing.Point(22, 160);
            this.txtXpathNodesToRemove.Multiline = true;
            this.txtXpathNodesToRemove.Name = "txtXpathNodesToRemove";
            this.txtXpathNodesToRemove.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXpathNodesToRemove.Size = new System.Drawing.Size(431, 156);
            this.txtXpathNodesToRemove.TabIndex = 4;
            this.txtXpathNodesToRemove.Text = "//comment() \r\n//script \r\n//link \r\n//noscript \r\n//meta[@property]\r\n//a[@class=\'ind" +
    "exterm\']\r\n//div[starts-with(@class,\'t-sbo-\')]";
            // 
            // UserControlSafariRipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtXpathNodesToRemove);
            this.Controls.Add(this.txtUrls);
            this.Controls.Add(this.chkClearSessions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSaveLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlSafariRipper";
            this.Size = new System.Drawing.Size(625, 552);
            this.Load += new System.EventHandler(this.UserControlSafariRipper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkClearSessions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrls;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXpathNodesToRemove;
    }
}
