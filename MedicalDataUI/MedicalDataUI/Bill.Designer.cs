namespace MedicalDataUI
{
    partial class Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice = new System.Windows.Forms.TextBox();
            this.diagnosis = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagnosis";
            // 
            // invoice
            // 
            this.invoice.Location = new System.Drawing.Point(239, 83);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(177, 20);
            this.invoice.TabIndex = 2;
            // 
            // diagnosis
            // 
            this.diagnosis.Location = new System.Drawing.Point(239, 153);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(177, 20);
            this.diagnosis.TabIndex = 3;
            this.diagnosis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(569, 377);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 33);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoice;
        private System.Windows.Forms.TextBox diagnosis;
        private System.Windows.Forms.Button Save;
    }
}