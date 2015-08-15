namespace BFPMIS
{
    partial class frmNTC
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
            this.txtNTCDoR = new System.Windows.Forms.TextBox();
            this.txtNTCTime = new System.Windows.Forms.TextBox();
            this.txtNTCReceive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "NTC Date of Release:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "NTC Time Receive:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "NTC Receive By:";
            // 
            // txtNTCDoR
            // 
            this.txtNTCDoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTCDoR.Location = new System.Drawing.Point(232, 24);
            this.txtNTCDoR.Name = "txtNTCDoR";
            this.txtNTCDoR.Size = new System.Drawing.Size(592, 38);
            this.txtNTCDoR.TabIndex = 21;
            // 
            // txtNTCTime
            // 
            this.txtNTCTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTCTime.Location = new System.Drawing.Point(232, 88);
            this.txtNTCTime.Name = "txtNTCTime";
            this.txtNTCTime.Size = new System.Drawing.Size(592, 38);
            this.txtNTCTime.TabIndex = 22;
            // 
            // txtNTCReceive
            // 
            this.txtNTCReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTCReceive.Location = new System.Drawing.Point(232, 144);
            this.txtNTCReceive.Name = "txtNTCReceive";
            this.txtNTCReceive.Size = new System.Drawing.Size(592, 38);
            this.txtNTCReceive.TabIndex = 23;
            // 
            // frmNTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 257);
            this.ControlBox = false;
            this.Controls.Add(this.txtNTCReceive);
            this.Controls.Add(this.txtNTCTime);
            this.Controls.Add(this.txtNTCDoR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "frmNTC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice To Comply";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNTCDoR;
        private System.Windows.Forms.TextBox txtNTCTime;
        private System.Windows.Forms.TextBox txtNTCReceive;
    }
}