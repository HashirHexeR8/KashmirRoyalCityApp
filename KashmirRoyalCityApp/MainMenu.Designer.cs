using System.Runtime.CompilerServices;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnNomineeInfo = new System.Windows.Forms.Button();
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.btnPlotInfo = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelMain, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 946);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDocuments);
            this.panel1.Controls.Add(this.btnNomineeInfo);
            this.panel1.Controls.Add(this.btnCustomerInfo);
            this.panel1.Controls.Add(this.btnPlotInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 940);
            this.panel1.TabIndex = 0;
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(-2, 608);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(240, 136);
            this.btnDocuments.TabIndex = 0;
            this.btnDocuments.Text = "Documents";
            this.btnDocuments.UseVisualStyleBackColor = true;
            // 
            // btnNomineeInfo
            // 
            this.btnNomineeInfo.Location = new System.Drawing.Point(-2, 466);
            this.btnNomineeInfo.Name = "btnNomineeInfo";
            this.btnNomineeInfo.Size = new System.Drawing.Size(240, 136);
            this.btnNomineeInfo.TabIndex = 0;
            this.btnNomineeInfo.Text = "Nominee Info";
            this.btnNomineeInfo.UseVisualStyleBackColor = true;
            this.btnNomineeInfo.Click += new System.EventHandler(this.btnNomineeInfo_Click);
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.Location = new System.Drawing.Point(0, 324);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(240, 136);
            this.btnCustomerInfo.TabIndex = 0;
            this.btnCustomerInfo.Text = "Customer Info";
            this.btnCustomerInfo.UseVisualStyleBackColor = true;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // btnPlotInfo
            // 
            this.btnPlotInfo.Location = new System.Drawing.Point(0, 182);
            this.btnPlotInfo.Name = "btnPlotInfo";
            this.btnPlotInfo.Size = new System.Drawing.Size(240, 136);
            this.btnPlotInfo.TabIndex = 0;
            this.btnPlotInfo.Text = "Plot Info";
            this.btnPlotInfo.UseVisualStyleBackColor = true;
            this.btnPlotInfo.Click += new System.EventHandler(this.btnPlotInfo_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(252, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(993, 940);
            this.panelMain.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(1254, 953);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnNomineeInfo;
        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.Button btnPlotInfo;
        private System.Windows.Forms.Panel panelMain;
    }
}