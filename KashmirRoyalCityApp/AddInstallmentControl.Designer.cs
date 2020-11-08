namespace KashmirRoyalCityApp
{
    partial class AddInstallmentControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInstallmentAmmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRegistrationNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddInstallment = new System.Windows.Forms.Button();
            this.installmentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.installmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(378, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installment Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1069, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(713, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(278, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "*";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(879, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 39);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(879, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Installment Date";
            // 
            // tbInstallmentAmmount
            // 
            this.tbInstallmentAmmount.Location = new System.Drawing.Point(471, 289);
            this.tbInstallmentAmmount.Name = "tbInstallmentAmmount";
            this.tbInstallmentAmmount.Size = new System.Drawing.Size(276, 39);
            this.tbInstallmentAmmount.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Installment Ammount";
            // 
            // tbRegistrationNumber
            // 
            this.tbRegistrationNumber.Location = new System.Drawing.Point(51, 289);
            this.tbRegistrationNumber.Name = "tbRegistrationNumber";
            this.tbRegistrationNumber.Size = new System.Drawing.Size(276, 39);
            this.tbRegistrationNumber.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Registration Number";
            // 
            // btnAddInstallment
            // 
            this.btnAddInstallment.Location = new System.Drawing.Point(471, 362);
            this.btnAddInstallment.Name = "btnAddInstallment";
            this.btnAddInstallment.Size = new System.Drawing.Size(276, 46);
            this.btnAddInstallment.TabIndex = 5;
            this.btnAddInstallment.Text = "Add Installment";
            this.btnAddInstallment.UseVisualStyleBackColor = true;
            this.btnAddInstallment.Click += new System.EventHandler(this.btnAddInstallment_Click);
            // 
            // installmentDataGridView
            // 
            this.installmentDataGridView.AllowUserToAddRows = false;
            this.installmentDataGridView.AllowUserToDeleteRows = false;
            this.installmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.installmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.installmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.installmentDataGridView.Location = new System.Drawing.Point(2, 440);
            this.installmentDataGridView.Name = "installmentDataGridView";
            this.installmentDataGridView.ReadOnly = true;
            this.installmentDataGridView.RowHeadersWidth = 82;
            this.installmentDataGridView.Size = new System.Drawing.Size(1246, 490);
            this.installmentDataGridView.TabIndex = 4;
            this.installmentDataGridView.Text = "dataGridView1";
            // 
            // AddInstallmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddInstallment);
            this.Controls.Add(this.installmentDataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRegistrationNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbInstallmentAmmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddInstallmentControl";
            this.Size = new System.Drawing.Size(1248, 946);
            ((System.ComponentModel.ISupportInitialize)(this.installmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInstallmentAmmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRegistrationNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddInstallment;
        private System.Windows.Forms.DataGridView installmentDataGridView;
    }
}
