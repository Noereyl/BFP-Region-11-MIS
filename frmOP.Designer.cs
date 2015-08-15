namespace BFPMIS
{
    partial class frmOP
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOPdate = new System.Windows.Forms.TextBox();
            this.txtOPno = new System.Windows.Forms.TextBox();
            this.cmbRemarks = new System.Windows.Forms.ComboBox();
            this.btnOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 34);
            this.label9.TabIndex = 19;
            this.label9.Text = "Order of Payment Date:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order of Payment No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "Remarks";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOPdate
            // 
            this.txtOPdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPdate.Location = new System.Drawing.Point(274, 26);
            this.txtOPdate.Name = "txtOPdate";
            this.txtOPdate.Size = new System.Drawing.Size(630, 38);
            this.txtOPdate.TabIndex = 22;
            // 
            // txtOPno
            // 
            this.txtOPno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPno.Location = new System.Drawing.Point(274, 88);
            this.txtOPno.Name = "txtOPno";
            this.txtOPno.Size = new System.Drawing.Size(630, 38);
            this.txtOPno.TabIndex = 23;
            // 
            // cmbRemarks
            // 
            this.cmbRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRemarks.FormattingEnabled = true;
            this.cmbRemarks.Location = new System.Drawing.Point(274, 149);
            this.cmbRemarks.Name = "cmbRemarks";
            this.cmbRemarks.Size = new System.Drawing.Size(630, 39);
            this.cmbRemarks.TabIndex = 24;
            // 
            // btnOP
            // 
            this.btnOP.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOP.Location = new System.Drawing.Point(491, 232);
            this.btnOP.Name = "btnOP";
            this.btnOP.Size = new System.Drawing.Size(413, 72);
            this.btnOP.TabIndex = 25;
            this.btnOP.Text = "Order of Payment";
            this.btnOP.UseVisualStyleBackColor = true;
            // 
            // frmOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 331);
            this.ControlBox = false;
            this.Controls.Add(this.btnOP);
            this.Controls.Add(this.cmbRemarks);
            this.Controls.Add(this.txtOPno);
            this.Controls.Add(this.txtOPdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "frmOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order of Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOPdate;
        private System.Windows.Forms.TextBox txtOPno;
        private System.Windows.Forms.ComboBox cmbRemarks;
        private System.Windows.Forms.Button btnOP;
    }
}