namespace WindowsFormsApplication1
{
    partial class viewPmaster
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
            this.bc_txt = new System.Windows.Forms.TextBox();
            this.pt_cmb = new System.Windows.Forms.ComboBox();
            this.pd_dtp = new System.Windows.Forms.DateTimePicker();
            this.oid_cmb = new System.Windows.Forms.ComboBox();
            this.val_txt = new System.Windows.Forms.TextBox();
            this.pid_txt = new System.Windows.Forms.TextBox();
            this.pt_lbl = new System.Windows.Forms.Label();
            this.pd_lbl = new System.Windows.Forms.Label();
            this.val_lbl = new System.Windows.Forms.Label();
            this.bc_lbl = new System.Windows.Forms.Label();
            this.oid_lbl = new System.Windows.Forms.Label();
            this.pay_lbl = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lkr_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bc_txt
            // 
            this.bc_txt.Enabled = false;
            this.bc_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_txt.Location = new System.Drawing.Point(202, 182);
            this.bc_txt.Name = "bc_txt";
            this.bc_txt.Size = new System.Drawing.Size(189, 25);
            this.bc_txt.TabIndex = 24;
            // 
            // pt_cmb
            // 
            this.pt_cmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt_cmb.FormattingEnabled = true;
            this.pt_cmb.Items.AddRange(new object[] {
            "T/T at delivery",
            "PBS",
            "PIA"});
            this.pt_cmb.Location = new System.Drawing.Point(202, 358);
            this.pt_cmb.Name = "pt_cmb";
            this.pt_cmb.Size = new System.Drawing.Size(189, 25);
            this.pt_cmb.TabIndex = 23;
            this.pt_cmb.Text = "Select ";
            this.pt_cmb.SelectedIndexChanged += new System.EventHandler(this.pt_cmb_SelectedIndexChanged);
            // 
            // pd_dtp
            // 
            this.pd_dtp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pd_dtp.Location = new System.Drawing.Point(202, 301);
            this.pd_dtp.Name = "pd_dtp";
            this.pd_dtp.Size = new System.Drawing.Size(189, 25);
            this.pd_dtp.TabIndex = 22;
            this.pd_dtp.ValueChanged += new System.EventHandler(this.pd_dtp_ValueChanged);
            // 
            // oid_cmb
            // 
            this.oid_cmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oid_cmb.FormattingEnabled = true;
            this.oid_cmb.Location = new System.Drawing.Point(202, 131);
            this.oid_cmb.Name = "oid_cmb";
            this.oid_cmb.Size = new System.Drawing.Size(189, 25);
            this.oid_cmb.TabIndex = 21;
            this.oid_cmb.Text = "Select";
            this.oid_cmb.SelectedIndexChanged += new System.EventHandler(this.oid_cmb_SelectedIndexChanged);
            // 
            // val_txt
            // 
            this.val_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_txt.Location = new System.Drawing.Point(202, 228);
            this.val_txt.Name = "val_txt";
            this.val_txt.Size = new System.Drawing.Size(189, 25);
            this.val_txt.TabIndex = 19;
            this.val_txt.TextChanged += new System.EventHandler(this.val_txt_TextChanged);
            // 
            // pid_txt
            // 
            this.pid_txt.Enabled = false;
            this.pid_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid_txt.Location = new System.Drawing.Point(202, 73);
            this.pid_txt.Name = "pid_txt";
            this.pid_txt.Size = new System.Drawing.Size(189, 25);
            this.pid_txt.TabIndex = 20;
            // 
            // pt_lbl
            // 
            this.pt_lbl.AutoSize = true;
            this.pt_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt_lbl.Location = new System.Drawing.Point(66, 362);
            this.pt_lbl.Name = "pt_lbl";
            this.pt_lbl.Size = new System.Drawing.Size(115, 21);
            this.pt_lbl.TabIndex = 18;
            this.pt_lbl.Text = "Payment Terms";
            // 
            // pd_lbl
            // 
            this.pd_lbl.AutoSize = true;
            this.pd_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_lbl.Location = new System.Drawing.Point(66, 300);
            this.pd_lbl.Name = "pd_lbl";
            this.pd_lbl.Size = new System.Drawing.Size(42, 21);
            this.pd_lbl.TabIndex = 17;
            this.pd_lbl.Text = "Date";
            // 
            // val_lbl
            // 
            this.val_lbl.AutoSize = true;
            this.val_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_lbl.Location = new System.Drawing.Point(66, 274);
            this.val_lbl.Name = "val_lbl";
            this.val_lbl.Size = new System.Drawing.Size(48, 21);
            this.val_lbl.TabIndex = 16;
            this.val_lbl.Text = "Value";
            // 
            // bc_lbl
            // 
            this.bc_lbl.AutoSize = true;
            this.bc_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_lbl.Location = new System.Drawing.Point(66, 186);
            this.bc_lbl.Name = "bc_lbl";
            this.bc_lbl.Size = new System.Drawing.Size(90, 21);
            this.bc_lbl.TabIndex = 15;
            this.bc_lbl.Text = "Buyer Code";
            // 
            // oid_lbl
            // 
            this.oid_lbl.AutoSize = true;
            this.oid_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oid_lbl.Location = new System.Drawing.Point(66, 135);
            this.oid_lbl.Name = "oid_lbl";
            this.oid_lbl.Size = new System.Drawing.Size(70, 21);
            this.oid_lbl.TabIndex = 14;
            this.oid_lbl.Text = "Order ID";
            // 
            // pay_lbl
            // 
            this.pay_lbl.AutoSize = true;
            this.pay_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_lbl.Location = new System.Drawing.Point(66, 77);
            this.pay_lbl.Name = "pay_lbl";
            this.pay_lbl.Size = new System.Drawing.Size(87, 21);
            this.pay_lbl.TabIndex = 13;
            this.pay_lbl.Text = "Payment Id";
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(613, 398);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 43);
            this.Clear.TabIndex = 25;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(517, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Value";
            // 
            // lkr_txt
            // 
            this.lkr_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkr_txt.Location = new System.Drawing.Point(202, 270);
            this.lkr_txt.Name = "lkr_txt";
            this.lkr_txt.Size = new System.Drawing.Size(189, 25);
            this.lkr_txt.TabIndex = 19;
            // 
            // viewPmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.bc_txt);
            this.Controls.Add(this.pt_cmb);
            this.Controls.Add(this.pd_dtp);
            this.Controls.Add(this.oid_cmb);
            this.Controls.Add(this.lkr_txt);
            this.Controls.Add(this.val_txt);
            this.Controls.Add(this.pid_txt);
            this.Controls.Add(this.pt_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pd_lbl);
            this.Controls.Add(this.val_lbl);
            this.Controls.Add(this.bc_lbl);
            this.Controls.Add(this.oid_lbl);
            this.Controls.Add(this.pay_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewPmaster";
            this.Text = "viewPmaster";
            this.Load += new System.EventHandler(this.viewPmaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bc_txt;
        private System.Windows.Forms.ComboBox pt_cmb;
        private System.Windows.Forms.DateTimePicker pd_dtp;
        private System.Windows.Forms.ComboBox oid_cmb;
        private System.Windows.Forms.TextBox val_txt;
        private System.Windows.Forms.TextBox pid_txt;
        private System.Windows.Forms.Label pt_lbl;
        private System.Windows.Forms.Label pd_lbl;
        private System.Windows.Forms.Label val_lbl;
        private System.Windows.Forms.Label bc_lbl;
        private System.Windows.Forms.Label oid_lbl;
        private System.Windows.Forms.Label pay_lbl;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lkr_txt;
    }
}