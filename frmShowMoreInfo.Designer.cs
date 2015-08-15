namespace BFPMIS
{
    partial class frmShowMoreInfo
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
            this.appName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvAppDetails = new System.Windows.Forms.ListView();
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columBrgy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMobileNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLandlineNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBdgInfo = new System.Windows.Forms.ListView();
            this.columnOccupancyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBdgHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFloorArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaterialsUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.Maroon;
            this.appName.Location = new System.Drawing.Point(12, 19);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(200, 22);
            this.appName.TabIndex = 0;
            this.appName.Text = "APPLICANT\'S NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(768, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application Date";
            // 
            // lvAppDetails
            // 
            this.lvAppDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAddress,
            this.columBrgy,
            this.columnMobileNo,
            this.columnLandlineNo});
            this.lvAppDetails.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAppDetails.FullRowSelect = true;
            this.lvAppDetails.GridLines = true;
            this.lvAppDetails.Location = new System.Drawing.Point(19, 30);
            this.lvAppDetails.Name = "lvAppDetails";
            this.lvAppDetails.Size = new System.Drawing.Size(958, 93);
            this.lvAppDetails.TabIndex = 4;
            this.lvAppDetails.UseCompatibleStateImageBehavior = false;
            this.lvAppDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 317;
            // 
            // columBrgy
            // 
            this.columBrgy.Text = "Barangay";
            this.columBrgy.Width = 188;
            // 
            // columnMobileNo
            // 
            this.columnMobileNo.Text = "Mobile No.";
            this.columnMobileNo.Width = 212;
            // 
            // columnLandlineNo
            // 
            this.columnLandlineNo.Text = "Landline No.";
            this.columnLandlineNo.Width = 278;
            // 
            // lvBdgInfo
            // 
            this.lvBdgInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOccupancyType,
            this.columnBdgHeight,
            this.columnFloorArea,
            this.columnMaterialsUsed});
            this.lvBdgInfo.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBdgInfo.FullRowSelect = true;
            this.lvBdgInfo.GridLines = true;
            this.lvBdgInfo.Location = new System.Drawing.Point(19, 33);
            this.lvBdgInfo.Name = "lvBdgInfo";
            this.lvBdgInfo.Size = new System.Drawing.Size(958, 93);
            this.lvBdgInfo.TabIndex = 5;
            this.lvBdgInfo.UseCompatibleStateImageBehavior = false;
            this.lvBdgInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnOccupancyType
            // 
            this.columnOccupancyType.Text = "Occupany Type";
            this.columnOccupancyType.Width = 268;
            // 
            // columnBdgHeight
            // 
            this.columnBdgHeight.Text = "Building Height";
            this.columnBdgHeight.Width = 188;
            // 
            // columnFloorArea
            // 
            this.columnFloorArea.Text = "Floor Area";
            this.columnFloorArea.Width = 212;
            // 
            // columnMaterialsUsed
            // 
            this.columnMaterialsUsed.Text = "Construction Material Used";
            this.columnMaterialsUsed.Width = 278;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvAppDetails);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address and Contact Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvBdgInfo);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 141);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Building Information";
            // 
            // frmShowMoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1025, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowMoreInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvAppDetails;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columBrgy;
        private System.Windows.Forms.ColumnHeader columnMobileNo;
        private System.Windows.Forms.ColumnHeader columnLandlineNo;
        private System.Windows.Forms.ListView lvBdgInfo;
        private System.Windows.Forms.ColumnHeader columnOccupancyType;
        private System.Windows.Forms.ColumnHeader columnBdgHeight;
        private System.Windows.Forms.ColumnHeader columnFloorArea;
        private System.Windows.Forms.ColumnHeader columnMaterialsUsed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}