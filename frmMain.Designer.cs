namespace BFPMIS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnApplicant = new System.Windows.Forms.Button();
            this.btnBusinessPermit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApplicant
            // 
            this.btnApplicant.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicant.Location = new System.Drawing.Point(182, 62);
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.Size = new System.Drawing.Size(506, 99);
            this.btnApplicant.TabIndex = 0;
            this.btnApplicant.Text = "APPLICANT";
            this.btnApplicant.UseVisualStyleBackColor = true;
            this.btnApplicant.Click += new System.EventHandler(this.btnApplicant_Click);
            // 
            // btnBusinessPermit
            // 
            this.btnBusinessPermit.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusinessPermit.Location = new System.Drawing.Point(182, 194);
            this.btnBusinessPermit.Name = "btnBusinessPermit";
            this.btnBusinessPermit.Size = new System.Drawing.Size(506, 99);
            this.btnBusinessPermit.TabIndex = 1;
            this.btnBusinessPermit.Text = "BUSINESS PERMIT";
            this.btnBusinessPermit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(182, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(506, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "FIRE INSPECTION SAFETY CERTIFICATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(795, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(893, 474);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBusinessPermit);
            this.Controls.Add(this.btnApplicant);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplicant;
        private System.Windows.Forms.Button btnBusinessPermit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogout;
    }
}