namespace WindowsFormsApplication1
{
    partial class viewOmaster
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
            this.eMain = new System.Windows.Forms.Label();
            this.bc_cmb = new System.Windows.Forms.ComboBox();
            this.cDate = new System.Windows.Forms.DateTimePicker();
            this.rDate = new System.Windows.Forms.DateTimePicker();
            this.oDate = new System.Windows.Forms.DateTimePicker();
            this.e7 = new System.Windows.Forms.Label();
            this.e6 = new System.Windows.Forms.Label();
            this.e5 = new System.Windows.Forms.Label();
            this.e4 = new System.Windows.Forms.Label();
            this.e3 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.Label();
            this.hs_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.ts_lbl = new System.Windows.Forms.Label();
            this.hs_lbl = new System.Windows.Forms.Label();
            this.csd_lbl = new System.Windows.Forms.Label();
            this.rsd_lbl = new System.Windows.Forms.Label();
            this.od_lbl = new System.Windows.Forms.Label();
            this.bc_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.ci_cmb = new System.Windows.Forms.ComboBox();
            this.ar_cmb = new System.Windows.Forms.ComboBox();
            this.e11 = new System.Windows.Forms.Label();
            this.e10 = new System.Windows.Forms.Label();
            this.e9 = new System.Windows.Forms.Label();
            this.e8 = new System.Windows.Forms.Label();
            this.ov_txt = new System.Windows.Forms.TextBox();
            this.ci_lbl = new System.Windows.Forms.Label();
            this.ar_lbl = new System.Windows.Forms.Label();
            this.ov_lbl = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.yes_rad = new System.Windows.Forms.RadioButton();
            this.no_rad = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // eMain
            // 
            this.eMain.AutoSize = true;
            this.eMain.Location = new System.Drawing.Point(18, 38);
            this.eMain.Name = "eMain";
            this.eMain.Size = new System.Drawing.Size(0, 13);
            this.eMain.TabIndex = 34;
            // 
            // bc_cmb
            // 
            this.bc_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bc_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bc_cmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_cmb.FormattingEnabled = true;
            this.bc_cmb.Location = new System.Drawing.Point(212, 113);
            this.bc_cmb.Name = "bc_cmb";
            this.bc_cmb.Size = new System.Drawing.Size(200, 25);
            this.bc_cmb.TabIndex = 33;
            this.bc_cmb.Text = "Select a buyer";
            this.bc_cmb.SelectedIndexChanged += new System.EventHandler(this.bc_cmb_SelectedIndexChanged);
            // 
            // cDate
            // 
            this.cDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cDate.Location = new System.Drawing.Point(212, 255);
            this.cDate.Name = "cDate";
            this.cDate.Size = new System.Drawing.Size(200, 25);
            this.cDate.TabIndex = 32;
            this.cDate.ValueChanged += new System.EventHandler(this.cDate_ValueChanged);
            // 
            // rDate
            // 
            this.rDate.Checked = false;
            this.rDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rDate.Location = new System.Drawing.Point(212, 210);
            this.rDate.Name = "rDate";
            this.rDate.ShowCheckBox = true;
            this.rDate.Size = new System.Drawing.Size(200, 25);
            this.rDate.TabIndex = 31;
            this.rDate.Value = new System.DateTime(2016, 8, 29, 0, 20, 19, 0);
            this.rDate.ValueChanged += new System.EventHandler(this.rDate_ValueChanged);
            // 
            // oDate
            // 
            this.oDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.oDate.Location = new System.Drawing.Point(212, 159);
            this.oDate.Name = "oDate";
            this.oDate.Size = new System.Drawing.Size(200, 25);
            this.oDate.TabIndex = 30;
            this.oDate.Value = new System.DateTime(2016, 8, 29, 0, 13, 15, 0);
            this.oDate.ValueChanged += new System.EventHandler(this.oDate_ValueChanged);
            // 
            // e7
            // 
            this.e7.AutoSize = true;
            this.e7.ForeColor = System.Drawing.Color.DarkRed;
            this.e7.Location = new System.Drawing.Point(418, 365);
            this.e7.Name = "e7";
            this.e7.Size = new System.Drawing.Size(0, 13);
            this.e7.TabIndex = 28;
            // 
            // e6
            // 
            this.e6.AutoSize = true;
            this.e6.ForeColor = System.Drawing.Color.DarkRed;
            this.e6.Location = new System.Drawing.Point(418, 309);
            this.e6.Name = "e6";
            this.e6.Size = new System.Drawing.Size(0, 13);
            this.e6.TabIndex = 27;
            // 
            // e5
            // 
            this.e5.AutoSize = true;
            this.e5.ForeColor = System.Drawing.Color.DarkRed;
            this.e5.Location = new System.Drawing.Point(418, 260);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(0, 13);
            this.e5.TabIndex = 26;
            // 
            // e4
            // 
            this.e4.AutoSize = true;
            this.e4.ForeColor = System.Drawing.Color.DarkRed;
            this.e4.Location = new System.Drawing.Point(418, 211);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(0, 13);
            this.e4.TabIndex = 25;
            // 
            // e3
            // 
            this.e3.AutoSize = true;
            this.e3.ForeColor = System.Drawing.Color.DarkRed;
            this.e3.Location = new System.Drawing.Point(418, 159);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(0, 13);
            this.e3.TabIndex = 29;
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.ForeColor = System.Drawing.Color.DarkRed;
            this.e2.Location = new System.Drawing.Point(418, 111);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(0, 13);
            this.e2.TabIndex = 24;
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.ForeColor = System.Drawing.Color.DarkRed;
            this.e1.Location = new System.Drawing.Point(418, 60);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(0, 13);
            this.e1.TabIndex = 23;
            // 
            // hs_txt
            // 
            this.hs_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hs_txt.Location = new System.Drawing.Point(212, 306);
            this.hs_txt.Name = "hs_txt";
            this.hs_txt.Size = new System.Drawing.Size(200, 25);
            this.hs_txt.TabIndex = 21;
            // 
            // id_txt
            // 
            this.id_txt.Enabled = false;
            this.id_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(212, 60);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(200, 25);
            this.id_txt.TabIndex = 20;
            // 
            // ts_lbl
            // 
            this.ts_lbl.AutoSize = true;
            this.ts_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_lbl.Location = new System.Drawing.Point(18, 369);
            this.ts_lbl.Name = "ts_lbl";
            this.ts_lbl.Size = new System.Drawing.Size(103, 17);
            this.ts_lbl.TabIndex = 18;
            this.ts_lbl.Text = "Transaction Split";
            // 
            // hs_lbl
            // 
            this.hs_lbl.AutoSize = true;
            this.hs_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hs_lbl.Location = new System.Drawing.Point(16, 314);
            this.hs_lbl.Name = "hs_lbl";
            this.hs_lbl.Size = new System.Drawing.Size(159, 17);
            this.hs_lbl.TabIndex = 17;
            this.hs_lbl.Text = "Harmonized System Code";
            // 
            // csd_lbl
            // 
            this.csd_lbl.AutoSize = true;
            this.csd_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csd_lbl.Location = new System.Drawing.Point(17, 263);
            this.csd_lbl.Name = "csd_lbl";
            this.csd_lbl.Size = new System.Drawing.Size(129, 17);
            this.csd_lbl.TabIndex = 16;
            this.csd_lbl.Text = "Confirmed Ship Date";
            // 
            // rsd_lbl
            // 
            this.rsd_lbl.AutoSize = true;
            this.rsd_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsd_lbl.Location = new System.Drawing.Point(18, 218);
            this.rsd_lbl.Name = "rsd_lbl";
            this.rsd_lbl.Size = new System.Drawing.Size(130, 17);
            this.rsd_lbl.TabIndex = 15;
            this.rsd_lbl.Text = "Requested Ship Date";
            // 
            // od_lbl
            // 
            this.od_lbl.AutoSize = true;
            this.od_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_lbl.Location = new System.Drawing.Point(18, 167);
            this.od_lbl.Name = "od_lbl";
            this.od_lbl.Size = new System.Drawing.Size(74, 17);
            this.od_lbl.TabIndex = 14;
            this.od_lbl.Text = "Order Date";
            // 
            // bc_lbl
            // 
            this.bc_lbl.AutoSize = true;
            this.bc_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_lbl.Location = new System.Drawing.Point(18, 121);
            this.bc_lbl.Name = "bc_lbl";
            this.bc_lbl.Size = new System.Drawing.Size(75, 17);
            this.bc_lbl.TabIndex = 19;
            this.bc_lbl.Text = "Buyer Code";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(18, 68);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(59, 17);
            this.id_lbl.TabIndex = 13;
            this.id_lbl.Text = "Order ID";
            // 
            // ci_cmb
            // 
            this.ci_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ci_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ci_cmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ci_cmb.FormattingEnabled = true;
            this.ci_cmb.Location = new System.Drawing.Point(657, 199);
            this.ci_cmb.Name = "ci_cmb";
            this.ci_cmb.Size = new System.Drawing.Size(165, 25);
            this.ci_cmb.TabIndex = 46;
            this.ci_cmb.Text = "Select ";
            this.ci_cmb.SelectedIndexChanged += new System.EventHandler(this.ci_cmb_SelectedIndexChanged);
            // 
            // ar_cmb
            // 
            this.ar_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ar_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ar_cmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ar_cmb.FormattingEnabled = true;
            this.ar_cmb.Location = new System.Drawing.Point(657, 133);
            this.ar_cmb.Name = "ar_cmb";
            this.ar_cmb.Size = new System.Drawing.Size(165, 25);
            this.ar_cmb.TabIndex = 45;
            this.ar_cmb.Text = "Enter an Item";
            this.ar_cmb.SelectedIndexChanged += new System.EventHandler(this.ar_cmb_SelectedIndexChanged);
            // 
            // e11
            // 
            this.e11.AutoSize = true;
            this.e11.ForeColor = System.Drawing.Color.DarkRed;
            this.e11.Location = new System.Drawing.Point(829, 227);
            this.e11.Name = "e11";
            this.e11.Size = new System.Drawing.Size(0, 13);
            this.e11.TabIndex = 41;
            // 
            // e10
            // 
            this.e10.AutoSize = true;
            this.e10.ForeColor = System.Drawing.Color.DarkRed;
            this.e10.Location = new System.Drawing.Point(828, 166);
            this.e10.Name = "e10";
            this.e10.Size = new System.Drawing.Size(0, 13);
            this.e10.TabIndex = 42;
            // 
            // e9
            // 
            this.e9.AutoSize = true;
            this.e9.ForeColor = System.Drawing.Color.DarkRed;
            this.e9.Location = new System.Drawing.Point(828, 117);
            this.e9.Name = "e9";
            this.e9.Size = new System.Drawing.Size(0, 13);
            this.e9.TabIndex = 43;
            // 
            // e8
            // 
            this.e8.AutoSize = true;
            this.e8.ForeColor = System.Drawing.Color.DarkRed;
            this.e8.Location = new System.Drawing.Point(828, 64);
            this.e8.Name = "e8";
            this.e8.Size = new System.Drawing.Size(0, 13);
            this.e8.TabIndex = 44;
            // 
            // ov_txt
            // 
            this.ov_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ov_txt.Location = new System.Drawing.Point(657, 65);
            this.ov_txt.Name = "ov_txt";
            this.ov_txt.Size = new System.Drawing.Size(165, 25);
            this.ov_txt.TabIndex = 40;
            this.ov_txt.TextChanged += new System.EventHandler(this.ov_txt_TextChanged);
            // 
            // ci_lbl
            // 
            this.ci_lbl.AutoSize = true;
            this.ci_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ci_lbl.Location = new System.Drawing.Point(517, 207);
            this.ci_lbl.Name = "ci_lbl";
            this.ci_lbl.Size = new System.Drawing.Size(97, 17);
            this.ci_lbl.TabIndex = 35;
            this.ci_lbl.Text = "Color Index No";
            // 
            // ar_lbl
            // 
            this.ar_lbl.AutoSize = true;
            this.ar_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ar_lbl.Location = new System.Drawing.Point(517, 136);
            this.ar_lbl.Name = "ar_lbl";
            this.ar_lbl.Size = new System.Drawing.Size(44, 17);
            this.ar_lbl.TabIndex = 36;
            this.ar_lbl.Text = "Article";
            // 
            // ov_lbl
            // 
            this.ov_lbl.AutoSize = true;
            this.ov_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ov_lbl.Location = new System.Drawing.Point(517, 68);
            this.ov_lbl.Name = "ov_lbl";
            this.ov_lbl.Size = new System.Drawing.Size(78, 17);
            this.ov_lbl.TabIndex = 38;
            this.ov_lbl.Text = "Order Value";
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1007, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 23);
            this.close.TabIndex = 47;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // add_btn
            // 
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(520, 417);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(76, 35);
            this.add_btn.TabIndex = 50;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // yes_rad
            // 
            this.yes_rad.AutoSize = true;
            this.yes_rad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_rad.Location = new System.Drawing.Point(212, 365);
            this.yes_rad.Name = "yes_rad";
            this.yes_rad.Size = new System.Drawing.Size(45, 21);
            this.yes_rad.TabIndex = 51;
            this.yes_rad.TabStop = true;
            this.yes_rad.Text = "Yes";
            this.yes_rad.UseVisualStyleBackColor = true;
            this.yes_rad.TextChanged += new System.EventHandler(this.yes_rad_TextChanged);
            // 
            // no_rad
            // 
            this.no_rad.AutoSize = true;
            this.no_rad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_rad.Location = new System.Drawing.Point(327, 365);
            this.no_rad.Name = "no_rad";
            this.no_rad.Size = new System.Drawing.Size(44, 21);
            this.no_rad.TabIndex = 52;
            this.no_rad.TabStop = true;
            this.no_rad.Text = "No";
            this.no_rad.UseVisualStyleBackColor = true;
            this.no_rad.TextChanged += new System.EventHandler(this.no_rad_TextChanged);
            // 
            // viewOmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(1038, 505);
            this.Controls.Add(this.no_rad);
            this.Controls.Add(this.yes_rad);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.close);
            this.Controls.Add(this.ci_cmb);
            this.Controls.Add(this.ar_cmb);
            this.Controls.Add(this.e11);
            this.Controls.Add(this.e10);
            this.Controls.Add(this.e9);
            this.Controls.Add(this.e8);
            this.Controls.Add(this.ov_txt);
            this.Controls.Add(this.ci_lbl);
            this.Controls.Add(this.ar_lbl);
            this.Controls.Add(this.ov_lbl);
            this.Controls.Add(this.eMain);
            this.Controls.Add(this.bc_cmb);
            this.Controls.Add(this.cDate);
            this.Controls.Add(this.rDate);
            this.Controls.Add(this.oDate);
            this.Controls.Add(this.e7);
            this.Controls.Add(this.e6);
            this.Controls.Add(this.e5);
            this.Controls.Add(this.e4);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.hs_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.ts_lbl);
            this.Controls.Add(this.hs_lbl);
            this.Controls.Add(this.csd_lbl);
            this.Controls.Add(this.rsd_lbl);
            this.Controls.Add(this.od_lbl);
            this.Controls.Add(this.bc_lbl);
            this.Controls.Add(this.id_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewOmaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewOmaster";
            this.Load += new System.EventHandler(this.viewOmaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eMain;
        private System.Windows.Forms.ComboBox bc_cmb;
        private System.Windows.Forms.DateTimePicker cDate;
        private System.Windows.Forms.DateTimePicker rDate;
        private System.Windows.Forms.DateTimePicker oDate;
        private System.Windows.Forms.Label e7;
        private System.Windows.Forms.Label e6;
        private System.Windows.Forms.Label e5;
        private System.Windows.Forms.Label e4;
        private System.Windows.Forms.Label e3;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.TextBox hs_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label ts_lbl;
        private System.Windows.Forms.Label hs_lbl;
        private System.Windows.Forms.Label csd_lbl;
        private System.Windows.Forms.Label rsd_lbl;
        private System.Windows.Forms.Label od_lbl;
        private System.Windows.Forms.Label bc_lbl;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.ComboBox ci_cmb;
        private System.Windows.Forms.ComboBox ar_cmb;
        private System.Windows.Forms.Label e11;
        private System.Windows.Forms.Label e10;
        private System.Windows.Forms.Label e9;
        private System.Windows.Forms.Label e8;
        private System.Windows.Forms.TextBox ov_txt;
        private System.Windows.Forms.Label ci_lbl;
        private System.Windows.Forms.Label ar_lbl;
        private System.Windows.Forms.Label ov_lbl;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.RadioButton yes_rad;
        private System.Windows.Forms.RadioButton no_rad;
    }
}