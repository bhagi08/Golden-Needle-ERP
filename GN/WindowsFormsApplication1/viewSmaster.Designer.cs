namespace WindowsFormsApplication1
{
    partial class viewSmaster
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
            this.close = new System.Windows.Forms.Button();
            this.delDat_lbl = new System.Windows.Forms.Label();
            this.valUsd_lbl = new System.Windows.Forms.Label();
            this.bc_lbl = new System.Windows.Forms.Label();
            this.oId_lbl = new System.Windows.Forms.Label();
            this.saId_lbl = new System.Windows.Forms.Label();
            this.valLkr_lbl = new System.Windows.Forms.Label();
            this.sam_txt = new System.Windows.Forms.TextBox();
            this.bc_txt = new System.Windows.Forms.TextBox();
            this.costUsd_txt = new System.Windows.Forms.TextBox();
            this.costLkr_txt = new System.Windows.Forms.TextBox();
            this.date_dtp = new System.Windows.Forms.DateTimePicker();
            this.oid_cmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_pb = new System.Windows.Forms.PictureBox();
            this.upd_btn = new System.Windows.Forms.Button();
            this.sat_cmb = new System.Windows.Forms.ComboBox();
            this.sat_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(920, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 23);
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // delDat_lbl
            // 
            this.delDat_lbl.AutoSize = true;
            this.delDat_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDat_lbl.Location = new System.Drawing.Point(24, 245);
            this.delDat_lbl.Name = "delDat_lbl";
            this.delDat_lbl.Size = new System.Drawing.Size(94, 17);
            this.delDat_lbl.TabIndex = 3;
            this.delDat_lbl.Text = "Delivered Date";
            // 
            // valUsd_lbl
            // 
            this.valUsd_lbl.AutoSize = true;
            this.valUsd_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUsd_lbl.Location = new System.Drawing.Point(24, 162);
            this.valUsd_lbl.Name = "valUsd_lbl";
            this.valUsd_lbl.Size = new System.Drawing.Size(93, 17);
            this.valUsd_lbl.TabIndex = 4;
            this.valUsd_lbl.Text = "Cost ( in USD )";
            // 
            // bc_lbl
            // 
            this.bc_lbl.AutoSize = true;
            this.bc_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_lbl.Location = new System.Drawing.Point(24, 122);
            this.bc_lbl.Name = "bc_lbl";
            this.bc_lbl.Size = new System.Drawing.Size(75, 17);
            this.bc_lbl.TabIndex = 5;
            this.bc_lbl.Text = "Buyer Code";
            // 
            // oId_lbl
            // 
            this.oId_lbl.AutoSize = true;
            this.oId_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oId_lbl.Location = new System.Drawing.Point(24, 81);
            this.oId_lbl.Name = "oId_lbl";
            this.oId_lbl.Size = new System.Drawing.Size(59, 17);
            this.oId_lbl.TabIndex = 6;
            this.oId_lbl.Text = "Order ID";
            // 
            // saId_lbl
            // 
            this.saId_lbl.AutoSize = true;
            this.saId_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saId_lbl.Location = new System.Drawing.Point(24, 34);
            this.saId_lbl.Name = "saId_lbl";
            this.saId_lbl.Size = new System.Drawing.Size(67, 17);
            this.saId_lbl.TabIndex = 7;
            this.saId_lbl.Text = "Sample ID";
            // 
            // valLkr_lbl
            // 
            this.valLkr_lbl.AutoSize = true;
            this.valLkr_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLkr_lbl.Location = new System.Drawing.Point(24, 203);
            this.valLkr_lbl.Name = "valLkr_lbl";
            this.valLkr_lbl.Size = new System.Drawing.Size(90, 17);
            this.valLkr_lbl.TabIndex = 4;
            this.valLkr_lbl.Text = "Cost ( in LKR )";
            this.valLkr_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // sam_txt
            // 
            this.sam_txt.Enabled = false;
            this.sam_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sam_txt.Location = new System.Drawing.Point(136, 34);
            this.sam_txt.Name = "sam_txt";
            this.sam_txt.Size = new System.Drawing.Size(217, 25);
            this.sam_txt.TabIndex = 1;
            this.sam_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            // 
            // bc_txt
            // 
            this.bc_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bc_txt.Enabled = false;
            this.bc_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_txt.Location = new System.Drawing.Point(136, 119);
            this.bc_txt.Name = "bc_txt";
            this.bc_txt.Size = new System.Drawing.Size(217, 25);
            this.bc_txt.TabIndex = 3;
            this.bc_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            // 
            // costUsd_txt
            // 
            this.costUsd_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costUsd_txt.Location = new System.Drawing.Point(136, 159);
            this.costUsd_txt.Name = "costUsd_txt";
            this.costUsd_txt.Size = new System.Drawing.Size(217, 25);
            this.costUsd_txt.TabIndex = 4;
            this.costUsd_txt.TextChanged += new System.EventHandler(this.costUsd_txt_TextChanged);
            this.costUsd_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            this.costUsd_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.costUsd_txt_KeyUp);
            // 
            // costLkr_txt
            // 
            this.costLkr_txt.Enabled = false;
            this.costLkr_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLkr_txt.Location = new System.Drawing.Point(136, 200);
            this.costLkr_txt.Name = "costLkr_txt";
            this.costLkr_txt.Size = new System.Drawing.Size(217, 25);
            this.costLkr_txt.TabIndex = 5;
            this.costLkr_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.costLkr_txt_MouseClick);
            this.costLkr_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            // 
            // date_dtp
            // 
            this.date_dtp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dtp.Location = new System.Drawing.Point(136, 237);
            this.date_dtp.Name = "date_dtp";
            this.date_dtp.Size = new System.Drawing.Size(217, 25);
            this.date_dtp.TabIndex = 6;
            this.date_dtp.ValueChanged += new System.EventHandler(this.date_dtp_ValueChanged);
            this.date_dtp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            // 
            // oid_cmb
            // 
            this.oid_cmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oid_cmb.FormattingEnabled = true;
            this.oid_cmb.Location = new System.Drawing.Point(136, 81);
            this.oid_cmb.Name = "oid_cmb";
            this.oid_cmb.Size = new System.Drawing.Size(217, 25);
            this.oid_cmb.TabIndex = 2;
            this.oid_cmb.SelectedIndexChanged += new System.EventHandler(this.oid_cmb_SelectedIndexChanged);
            this.oid_cmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_pb);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(394, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 228);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // pic_pb
            // 
            this.pic_pb.Location = new System.Drawing.Point(19, 19);
            this.pic_pb.Name = "pic_pb";
            this.pic_pb.Size = new System.Drawing.Size(490, 191);
            this.pic_pb.TabIndex = 0;
            this.pic_pb.TabStop = false;
            this.pic_pb.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pic_pb_LoadCompleted);
            this.pic_pb.DoubleClick += new System.EventHandler(this.pic_pb_DoubleClick_1);
            // 
            // upd_btn
            // 
            this.upd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_btn.Location = new System.Drawing.Point(438, 282);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(75, 23);
            this.upd_btn.TabIndex = 0;
            this.upd_btn.TabStop = false;
            this.upd_btn.Text = "Add";
            this.upd_btn.UseVisualStyleBackColor = true;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // sat_cmb
            // 
            this.sat_cmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat_cmb.FormattingEnabled = true;
            this.sat_cmb.Items.AddRange(new object[] {
            "Pending",
            "Accepted",
            "Rejected"});
            this.sat_cmb.Location = new System.Drawing.Point(136, 282);
            this.sat_cmb.Name = "sat_cmb";
            this.sat_cmb.Size = new System.Drawing.Size(217, 25);
            this.sat_cmb.TabIndex = 17;
            this.sat_cmb.SelectedIndexChanged += new System.EventHandler(this.sat_cmb_SelectedIndexChanged);
            // 
            // sat_lbl
            // 
            this.sat_lbl.AutoSize = true;
            this.sat_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat_lbl.Location = new System.Drawing.Point(24, 288);
            this.sat_lbl.Name = "sat_lbl";
            this.sat_lbl.Size = new System.Drawing.Size(43, 17);
            this.sat_lbl.TabIndex = 18;
            this.sat_lbl.Text = "Status";
            // 
            // viewSmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(950, 326);
            this.Controls.Add(this.sat_lbl);
            this.Controls.Add(this.sat_cmb);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.oid_cmb);
            this.Controls.Add(this.date_dtp);
            this.Controls.Add(this.costLkr_txt);
            this.Controls.Add(this.costUsd_txt);
            this.Controls.Add(this.bc_txt);
            this.Controls.Add(this.sam_txt);
            this.Controls.Add(this.delDat_lbl);
            this.Controls.Add(this.valLkr_lbl);
            this.Controls.Add(this.valUsd_lbl);
            this.Controls.Add(this.bc_lbl);
            this.Controls.Add(this.oId_lbl);
            this.Controls.Add(this.saId_lbl);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewSmaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewSmaster";
            this.Load += new System.EventHandler(this.viewSmaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ctrl_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label delDat_lbl;
        private System.Windows.Forms.Label valUsd_lbl;
        private System.Windows.Forms.Label bc_lbl;
        private System.Windows.Forms.Label oId_lbl;
        private System.Windows.Forms.Label saId_lbl;
        private System.Windows.Forms.Label valLkr_lbl;
        private System.Windows.Forms.TextBox sam_txt;
        private System.Windows.Forms.TextBox bc_txt;
        private System.Windows.Forms.TextBox costUsd_txt;
        private System.Windows.Forms.TextBox costLkr_txt;
        private System.Windows.Forms.DateTimePicker date_dtp;
        private System.Windows.Forms.ComboBox oid_cmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_pb;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.ComboBox sat_cmb;
        private System.Windows.Forms.Label sat_lbl;
    }
}