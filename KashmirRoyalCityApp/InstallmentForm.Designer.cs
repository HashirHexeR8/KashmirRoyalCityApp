namespace KashmirRoyalCityApp
{
    partial class InstallmentForm
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
            this.installmentMainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // installmentMainPanel
            // 
            this.installmentMainPanel.Location = new System.Drawing.Point(3, 6);
            this.installmentMainPanel.Name = "installmentMainPanel";
            this.installmentMainPanel.Size = new System.Drawing.Size(1248, 946);
            this.installmentMainPanel.TabIndex = 0;
            // 
            // InstallmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 953);
            this.Controls.Add(this.installmentMainPanel);
            this.Name = "InstallmentForm";
            this.Text = "InstallmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel installmentMainPanel;
    }
}