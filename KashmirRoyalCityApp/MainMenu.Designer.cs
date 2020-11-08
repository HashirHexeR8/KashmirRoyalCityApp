namespace KashmirRoyalCityApp
{
    partial class MainMenu
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
            this.btnNewPlot = new System.Windows.Forms.Button();
            this.btnPlotRecord = new System.Windows.Forms.Button();
            this.btnInstallment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewPlot
            // 
            this.btnNewPlot.Location = new System.Drawing.Point(12, 72);
            this.btnNewPlot.Name = "btnNewPlot";
            this.btnNewPlot.Size = new System.Drawing.Size(202, 85);
            this.btnNewPlot.TabIndex = 0;
            this.btnNewPlot.Text = "New Plot";
            this.btnNewPlot.UseVisualStyleBackColor = true;
            this.btnNewPlot.Click += new System.EventHandler(this.btnNewPlot_Click);
            this.btnNewPlot.MouseLeave += new System.EventHandler(this.btnNewPlotMouse_Exit);
            this.btnNewPlot.MouseHover += new System.EventHandler(this.btnNewPlotMouse_Hover);
            // 
            // btnPlotRecord
            // 
            this.btnPlotRecord.Location = new System.Drawing.Point(12, 196);
            this.btnPlotRecord.Name = "btnPlotRecord";
            this.btnPlotRecord.Size = new System.Drawing.Size(202, 85);
            this.btnPlotRecord.TabIndex = 1;
            this.btnPlotRecord.Text = "Plot Record";
            this.btnPlotRecord.UseVisualStyleBackColor = true;
            this.btnPlotRecord.Click += new System.EventHandler(this.btnPlotRecord_Click);
            this.btnPlotRecord.MouseHover += new System.EventHandler(this.btnPlotRecord_Hover);
            this.btnPlotRecord.MouseLeave += new System.EventHandler(this.btnPlotRecord_Exit);
            // 
            // btnInstallment
            // 
            this.btnInstallment.Location = new System.Drawing.Point(12, 323);
            this.btnInstallment.Name = "btnInstallment";
            this.btnInstallment.Size = new System.Drawing.Size(202, 85);
            this.btnInstallment.TabIndex = 2;
            this.btnInstallment.Text = "Plot Installment";
            this.btnInstallment.UseVisualStyleBackColor = true;
            this.btnInstallment.Click += new System.EventHandler(this.btnInstallment_Click);
            this.btnInstallment.MouseHover += new System.EventHandler(this.btnInstallment_Hover);
            this.btnInstallment.MouseLeave += new System.EventHandler(this.btnInstallment_Exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Info Tip";
            // 
            // lblInfoTip
            // 
            this.lblInfoTip.AutoSize = true;
            this.lblInfoTip.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoTip.Location = new System.Drawing.Point(310, 124);
            this.lblInfoTip.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblInfoTip.Name = "lblInfoTip";
            this.lblInfoTip.Size = new System.Drawing.Size(454, 33);
            this.lblInfoTip.TabIndex = 4;
            this.lblInfoTip.Text = "Please Choose an option to continue.";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfoTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstallment);
            this.Controls.Add(this.btnPlotRecord);
            this.Controls.Add(this.btnNewPlot);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPlot;
        private System.Windows.Forms.Button btnPlotRecord;
        private System.Windows.Forms.Button btnInstallment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoTip;
    }
}