namespace BFPMIS
{
    partial class frmBuildinginfo
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
            this.cmbOccuType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCMU = new System.Windows.Forms.ComboBox();
            this.txtFloorArea = new System.Windows.Forms.TextBox();
            this.txtBuildH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 34);
            this.label9.TabIndex = 17;
            this.label9.Text = "Occupancy Type:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbOccuType
            // 
            this.cmbOccuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOccuType.FormattingEnabled = true;
            this.cmbOccuType.Location = new System.Drawing.Point(284, 23);
            this.cmbOccuType.Name = "cmbOccuType";
            this.cmbOccuType.Size = new System.Drawing.Size(645, 39);
            this.cmbOccuType.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Building Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Floor Area:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Construction Materials Used:";
            // 
            // cmbCMU
            // 
            this.cmbCMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCMU.FormattingEnabled = true;
            this.cmbCMU.Location = new System.Drawing.Point(284, 198);
            this.cmbCMU.Name = "cmbCMU";
            this.cmbCMU.Size = new System.Drawing.Size(645, 39);
            this.cmbCMU.TabIndex = 22;
            // 
            // txtFloorArea
            // 
            this.txtFloorArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloorArea.Location = new System.Drawing.Point(284, 145);
            this.txtFloorArea.Name = "txtFloorArea";
            this.txtFloorArea.Size = new System.Drawing.Size(645, 38);
            this.txtFloorArea.TabIndex = 23;
            this.txtFloorArea.TextChanged += new System.EventHandler(this.txtBPN_TextChanged);
            // 
            // txtBuildH
            // 
            this.txtBuildH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildH.Location = new System.Drawing.Point(284, 83);
            this.txtBuildH.Name = "txtBuildH";
            this.txtBuildH.Size = new System.Drawing.Size(645, 38);
            this.txtBuildH.TabIndex = 24;
            // 
            // frmBuildinginfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 261);
            this.ControlBox = false;
            this.Controls.Add(this.txtBuildH);
            this.Controls.Add(this.txtFloorArea);
            this.Controls.Add(this.cmbCMU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOccuType);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmBuildinginfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Building Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbOccuType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCMU;
        private System.Windows.Forms.TextBox txtFloorArea;
        private System.Windows.Forms.TextBox txtBuildH;
    }
}