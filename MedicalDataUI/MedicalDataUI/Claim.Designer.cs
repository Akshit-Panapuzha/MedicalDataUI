namespace MedicalDataUI
{
    partial class Claim
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
            this.covType = new System.Windows.Forms.TextBox();
            this.claimNo = new System.Windows.Forms.TextBox();
            this.CompName = new System.Windows.Forms.TextBox();
            this.deductible = new System.Windows.Forms.TextBox();
            this.officeAddress1 = new System.Windows.Forms.TextBox();
            this.adjusterID = new System.Windows.Forms.TextBox();
            this.policyNo = new System.Windows.Forms.TextBox();
            this.polEffectiveDate = new System.Windows.Forms.TextBox();
            this.dateOfLoss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.officeAddress2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EDIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // covType
            // 
            this.covType.Location = new System.Drawing.Point(156, 110);
            this.covType.Margin = new System.Windows.Forms.Padding(2);
            this.covType.Name = "covType";
            this.covType.Size = new System.Drawing.Size(143, 20);
            this.covType.TabIndex = 3;
            // 
            // claimNo
            // 
            this.claimNo.Location = new System.Drawing.Point(156, 44);
            this.claimNo.Margin = new System.Windows.Forms.Padding(2);
            this.claimNo.Name = "claimNo";
            this.claimNo.Size = new System.Drawing.Size(142, 20);
            this.claimNo.TabIndex = 1;
            this.claimNo.TextChanged += new System.EventHandler(this.claimNo_TextChanged);
            this.claimNo.Leave += new System.EventHandler(this.claimNo_Leave);
            // 
            // CompName
            // 
            this.CompName.Location = new System.Drawing.Point(156, 143);
            this.CompName.Margin = new System.Windows.Forms.Padding(2);
            this.CompName.Name = "CompName";
            this.CompName.Size = new System.Drawing.Size(143, 20);
            this.CompName.TabIndex = 4;
            this.CompName.TextChanged += new System.EventHandler(this.CompName_TextChanged);
            // 
            // deductible
            // 
            this.deductible.Location = new System.Drawing.Point(156, 346);
            this.deductible.Margin = new System.Windows.Forms.Padding(2);
            this.deductible.Name = "deductible";
            this.deductible.Size = new System.Drawing.Size(143, 20);
            this.deductible.TabIndex = 10;
            // 
            // officeAddress1
            // 
            this.officeAddress1.Location = new System.Drawing.Point(156, 180);
            this.officeAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.officeAddress1.Name = "officeAddress1";
            this.officeAddress1.Size = new System.Drawing.Size(143, 20);
            this.officeAddress1.TabIndex = 5;
            // 
            // adjusterID
            // 
            this.adjusterID.Location = new System.Drawing.Point(156, 251);
            this.adjusterID.Margin = new System.Windows.Forms.Padding(2);
            this.adjusterID.Name = "adjusterID";
            this.adjusterID.Size = new System.Drawing.Size(139, 20);
            this.adjusterID.TabIndex = 7;
            this.adjusterID.TextChanged += new System.EventHandler(this.adjusterID_TextChanged);
            // 
            // policyNo
            // 
            this.policyNo.Location = new System.Drawing.Point(156, 287);
            this.policyNo.Margin = new System.Windows.Forms.Padding(2);
            this.policyNo.Name = "policyNo";
            this.policyNo.Size = new System.Drawing.Size(142, 20);
            this.policyNo.TabIndex = 8;
            // 
            // polEffectiveDate
            // 
            this.polEffectiveDate.Location = new System.Drawing.Point(156, 318);
            this.polEffectiveDate.Margin = new System.Windows.Forms.Padding(2);
            this.polEffectiveDate.Name = "polEffectiveDate";
            this.polEffectiveDate.Size = new System.Drawing.Size(142, 20);
            this.polEffectiveDate.TabIndex = 9;
            // 
            // dateOfLoss
            // 
            this.dateOfLoss.Location = new System.Drawing.Point(156, 80);
            this.dateOfLoss.Margin = new System.Windows.Forms.Padding(2);
            this.dateOfLoss.Name = "dateOfLoss";
            this.dateOfLoss.Size = new System.Drawing.Size(142, 20);
            this.dateOfLoss.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Claim Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Deductible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Policy Effective Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Policy Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adjuster Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Office Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Company Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Coverage Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date Of Loss";
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(178, 379);
            this.SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(56, 19);
            this.SAVE.TabIndex = 11;
            this.SAVE.Text = "SAVE";
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(352, 379);
            this.EXIT.Margin = new System.Windows.Forms.Padding(2);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(59, 20);
            this.EXIT.TabIndex = 13;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(270, 379);
            this.CLEAR.Margin = new System.Windows.Forms.Padding(2);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(56, 19);
            this.CLEAR.TabIndex = 12;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // officeAddress2
            // 
            this.officeAddress2.Location = new System.Drawing.Point(156, 213);
            this.officeAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.officeAddress2.Name = "officeAddress2";
            this.officeAddress2.Size = new System.Drawing.Size(143, 20);
            this.officeAddress2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 217);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Office Address";
            // 
            // EDIT
            // 
            this.EDIT.Location = new System.Drawing.Point(63, 376);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(64, 27);
            this.EDIT.TabIndex = 23;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // Claim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 465);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.officeAddress2);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateOfLoss);
            this.Controls.Add(this.polEffectiveDate);
            this.Controls.Add(this.policyNo);
            this.Controls.Add(this.adjusterID);
            this.Controls.Add(this.officeAddress1);
            this.Controls.Add(this.deductible);
            this.Controls.Add(this.CompName);
            this.Controls.Add(this.claimNo);
            this.Controls.Add(this.covType);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Claim";
            this.Text = "Medical Data Entry";
            this.Load += new System.EventHandler(this.Claim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox covType;
        private System.Windows.Forms.TextBox claimNo;
        private System.Windows.Forms.TextBox CompName;
        private System.Windows.Forms.TextBox deductible;
        private System.Windows.Forms.TextBox officeAddress1;
        private System.Windows.Forms.TextBox adjusterID;
        private System.Windows.Forms.TextBox policyNo;
        private System.Windows.Forms.TextBox polEffectiveDate;
        private System.Windows.Forms.TextBox dateOfLoss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.TextBox officeAddress2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button EDIT;
    }
}

