namespace iTin.Export.Web.Cloud.Clients
{
    partial class DropboxSignInDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropboxSignInDialog));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.cancelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // browser
            // 
            resources.ApplyResources(this.browser, "browser");
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            // 
            // cancelLinkLabel
            // 
            resources.ApplyResources(this.cancelLinkLabel, "cancelLinkLabel");
            this.cancelLinkLabel.Name = "cancelLinkLabel";
            this.cancelLinkLabel.TabStop = true;
            this.cancelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CancelLinkLabelLinkClicked);
            // 
            // DropboxSignInDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.cancelLinkLabel);
            this.Controls.Add(this.browser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DropboxSignInDialog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.LinkLabel cancelLinkLabel;
    }
}