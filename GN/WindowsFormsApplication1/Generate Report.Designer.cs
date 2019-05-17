namespace Project001
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            this.topPan = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.logoPan = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbllogo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.leftPan = new System.Windows.Forms.Panel();
            this.btndashBoard = new System.Windows.Forms.Button();
            this.btnsupplierDetails = new System.Windows.Forms.Button();
            this.btnpurchaseDetails = new System.Windows.Forms.Button();
            this.btngenarateReport = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnanualReport = new System.Windows.Forms.Button();
            this.btnmonthlyReport = new System.Windows.Forms.Button();
            this.topPan.SuspendLayout();
            this.logoPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.leftPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPan
            // 
            this.topPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(202)))));
            this.topPan.Controls.Add(this.button1);
            this.topPan.Controls.Add(this.label1);
            this.topPan.Controls.Add(this.btnMinimize);
            this.topPan.Controls.Add(this.logoPan);
            this.topPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPan.Location = new System.Drawing.Point(0, 0);
            this.topPan.Name = "topPan";
            this.topPan.Size = new System.Drawing.Size(692, 97);
            this.topPan.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 21);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(623, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 21);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // logoPan
            // 
            this.logoPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.logoPan.Controls.Add(this.pictureBox1);
            this.logoPan.Controls.Add(this.lbllogo);
            this.logoPan.Location = new System.Drawing.Point(0, 0);
            this.logoPan.Name = "logoPan";
            this.logoPan.Size = new System.Drawing.Size(249, 97);
            this.logoPan.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project001.Properties.Resources.needle_with_thread_to_sew_clothes;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 67);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = false;
            this.lbllogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.Color.White;
            this.lbllogo.Location = new System.Drawing.Point(84, 9);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(141, 51);
            this.lbllogo.TabIndex = 2;
            this.lbllogo.Text = "  Golden Needle Apparels (pvt) Ltd.";
            this.lbllogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPan
            // 
            this.leftPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.leftPan.Controls.Add(this.btndashBoard);
            this.leftPan.Controls.Add(this.btnsupplierDetails);
            this.leftPan.Controls.Add(this.btnpurchaseDetails);
            this.leftPan.Controls.Add(this.btngenarateReport);
            this.leftPan.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPan.Location = new System.Drawing.Point(0, 97);
            this.leftPan.Name = "leftPan";
            this.leftPan.Size = new System.Drawing.Size(249, 363);
            this.leftPan.TabIndex = 5;
            // 
            // btndashBoard
            // 
            this.btndashBoard.FlatAppearance.BorderSize = 0;
            this.btndashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashBoard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashBoard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndashBoard.Image = global::Project001.Properties.Resources.dashboard2;
            this.btndashBoard.Location = new System.Drawing.Point(0, 0);
            this.btndashBoard.Name = "btndashBoard";
            this.btndashBoard.Size = new System.Drawing.Size(249, 76);
            this.btndashBoard.TabIndex = 7;
            this.btndashBoard.Text = "Dash Board";
            this.btndashBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndashBoard.UseVisualStyleBackColor = true;
            this.btndashBoard.Click += new System.EventHandler(this.button1_Click);
            this.btndashBoard.MouseLeave += new System.EventHandler(this.btndashBoard_MouseLeave);
            this.btndashBoard.MouseHover += new System.EventHandler(this.btndashBoard_MouseHover);
            // 
            // btnsupplierDetails
            // 
            this.btnsupplierDetails.FlatAppearance.BorderSize = 0;
            this.btnsupplierDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupplierDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplierDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsupplierDetails.Image = global::Project001.Properties.Resources.hotel_supplier;
            this.btnsupplierDetails.Location = new System.Drawing.Point(0, 71);
            this.btnsupplierDetails.Name = "btnsupplierDetails";
            this.btnsupplierDetails.Size = new System.Drawing.Size(249, 76);
            this.btnsupplierDetails.TabIndex = 9;
            this.btnsupplierDetails.Text = "Supplier Details";
            this.btnsupplierDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsupplierDetails.UseVisualStyleBackColor = true;
            this.btnsupplierDetails.Click += new System.EventHandler(this.button3_Click);
            this.btnsupplierDetails.MouseLeave += new System.EventHandler(this.btnsupplierDetails_MouseLeave);
            this.btnsupplierDetails.MouseHover += new System.EventHandler(this.btnsupplierDetails_MouseHover);
            // 
            // btnpurchaseDetails
            // 
            this.btnpurchaseDetails.FlatAppearance.BorderSize = 0;
            this.btnpurchaseDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurchaseDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchaseDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpurchaseDetails.Image = global::Project001.Properties.Resources.approve_invoice;
            this.btnpurchaseDetails.Location = new System.Drawing.Point(0, 143);
            this.btnpurchaseDetails.Name = "btnpurchaseDetails";
            this.btnpurchaseDetails.Size = new System.Drawing.Size(249, 76);
            this.btnpurchaseDetails.TabIndex = 8;
            this.btnpurchaseDetails.Text = "Puchase Invoice";
            this.btnpurchaseDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnpurchaseDetails.UseVisualStyleBackColor = true;
            this.btnpurchaseDetails.Click += new System.EventHandler(this.button2_Click);
            this.btnpurchaseDetails.MouseLeave += new System.EventHandler(this.btnpurchaseDetails_MouseLeave);
            this.btnpurchaseDetails.MouseHover += new System.EventHandler(this.btnpurchaseDetails_MouseHover);
            // 
            // btngenarateReport
            // 
            this.btngenarateReport.FlatAppearance.BorderSize = 0;
            this.btngenarateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenarateReport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenarateReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngenarateReport.Image = global::Project001.Properties.Resources.seo_report;
            this.btngenarateReport.Location = new System.Drawing.Point(0, 216);
            this.btngenarateReport.Name = "btngenarateReport";
            this.btngenarateReport.Size = new System.Drawing.Size(249, 76);
            this.btngenarateReport.TabIndex = 10;
            this.btngenarateReport.Text = "Generate Reports";
            this.btngenarateReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngenarateReport.UseVisualStyleBackColor = true;
            this.btngenarateReport.MouseLeave += new System.EventHandler(this.btngenarateReport_MouseLeave);
            this.btngenarateReport.MouseHover += new System.EventHandler(this.btngenarateReport_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnanualReport
            // 
            this.btnanualReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnanualReport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanualReport.ForeColor = System.Drawing.Color.White;
            this.btnanualReport.Image = global::Project001.Properties.Resources.progress_report__1_;
            this.btnanualReport.Location = new System.Drawing.Point(500, 204);
            this.btnanualReport.Name = "btnanualReport";
            this.btnanualReport.Size = new System.Drawing.Size(124, 118);
            this.btnanualReport.TabIndex = 7;
            this.btnanualReport.Text = "Anual Report";
            this.btnanualReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnanualReport.UseVisualStyleBackColor = false;
            this.btnanualReport.MouseLeave += new System.EventHandler(this.btnanualReport_MouseLeave);
            this.btnanualReport.MouseHover += new System.EventHandler(this.btnanualReport_MouseHover);
            // 
            // btnmonthlyReport
            // 
            this.btnmonthlyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnmonthlyReport.FlatAppearance.BorderSize = 0;
            this.btnmonthlyReport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmonthlyReport.ForeColor = System.Drawing.Color.White;
            this.btnmonthlyReport.Image = global::Project001.Properties.Resources.analytic_report__1_;
            this.btnmonthlyReport.Location = new System.Drawing.Point(314, 204);
            this.btnmonthlyReport.Name = "btnmonthlyReport";
            this.btnmonthlyReport.Size = new System.Drawing.Size(124, 118);
            this.btnmonthlyReport.TabIndex = 6;
            this.btnmonthlyReport.Text = "Monthly Report";
            this.btnmonthlyReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmonthlyReport.UseVisualStyleBackColor = false;
            this.btnmonthlyReport.MouseLeave += new System.EventHandler(this.btnmonthlyReport_MouseLeave);
            this.btnmonthlyReport.MouseHover += new System.EventHandler(this.meterialSupplier_MouseHover);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 460);
            this.Controls.Add(this.btnanualReport);
            this.Controls.Add(this.btnmonthlyReport);
            this.Controls.Add(this.leftPan);
            this.Controls.Add(this.topPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Generate_Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.topPan.ResumeLayout(false);
            this.topPan.PerformLayout();
            this.logoPan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.leftPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPan;
        private System.Windows.Forms.Panel logoPan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbllogo;
        private System.Windows.Forms.Panel leftPan;
        private System.Windows.Forms.Button btndashBoard;
        private System.Windows.Forms.Button btnsupplierDetails;
        private System.Windows.Forms.Button btnpurchaseDetails;
        private System.Windows.Forms.Button btngenarateReport;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnanualReport;
        private System.Windows.Forms.Button btnmonthlyReport;


    }
}