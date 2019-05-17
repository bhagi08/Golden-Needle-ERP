namespace WindowsFormsApplication1
{
    partial class Login
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
            this.un_txt = new System.Windows.Forms.TextBox();
            this.un_pnl = new System.Windows.Forms.Panel();
            this.un_pb = new System.Windows.Forms.PictureBox();
            this.unli_pnl = new System.Windows.Forms.Panel();
            this.pw_pnl = new System.Windows.Forms.Panel();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.pw_pb = new System.Windows.Forms.PictureBox();
            this.pwli_pnl = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_lbl = new System.Windows.Forms.Label();
            this.lg_pb = new System.Windows.Forms.PictureBox();
            this.lg_btn = new System.Windows.Forms.Button();
            this.Error_lbl = new System.Windows.Forms.Label();
            this.un_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.un_pb)).BeginInit();
            this.pw_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pw_pb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lg_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // un_txt
            // 
            this.un_txt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un_txt.Location = new System.Drawing.Point(116, 22);
            this.un_txt.Multiline = true;
            this.un_txt.Name = "un_txt";
            this.un_txt.Size = new System.Drawing.Size(315, 39);
            this.un_txt.TabIndex = 0;
            this.un_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.un_txt_MouseClick);
            this.un_txt.Enter += new System.EventHandler(this.un_txt_Enter);
            this.un_txt.Leave += new System.EventHandler(this.un_txt_Leave);
            // 
            // un_pnl
            // 
            this.un_pnl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.un_pnl.Controls.Add(this.un_txt);
            this.un_pnl.Controls.Add(this.un_pb);
            this.un_pnl.Controls.Add(this.unli_pnl);
            this.un_pnl.Location = new System.Drawing.Point(27, 168);
            this.un_pnl.Name = "un_pnl";
            this.un_pnl.Size = new System.Drawing.Size(483, 84);
            this.un_pnl.TabIndex = 5;
            // 
            // un_pb
            // 
            this.un_pb.BackColor = System.Drawing.Color.White;
            this.un_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.un_pb.Image = global::WindowsFormsApplication1.Properties.Resources.user__1_;
            this.un_pb.Location = new System.Drawing.Point(81, 22);
            this.un_pb.Name = "un_pb";
            this.un_pb.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.un_pb.Size = new System.Drawing.Size(40, 39);
            this.un_pb.TabIndex = 5;
            this.un_pb.TabStop = false;
            this.un_pb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.un_pb_MouseClick);
            // 
            // unli_pnl
            // 
            this.unli_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.unli_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.unli_pnl.Location = new System.Drawing.Point(0, 0);
            this.unli_pnl.Name = "unli_pnl";
            this.unli_pnl.Size = new System.Drawing.Size(10, 84);
            this.unli_pnl.TabIndex = 3;
            // 
            // pw_pnl
            // 
            this.pw_pnl.BackColor = System.Drawing.Color.Transparent;
            this.pw_pnl.Controls.Add(this.pw_txt);
            this.pw_pnl.Controls.Add(this.pw_pb);
            this.pw_pnl.Controls.Add(this.pwli_pnl);
            this.pw_pnl.Location = new System.Drawing.Point(27, 252);
            this.pw_pnl.Name = "pw_pnl";
            this.pw_pnl.Size = new System.Drawing.Size(483, 83);
            this.pw_pnl.TabIndex = 5;
            // 
            // pw_txt
            // 
            this.pw_txt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_txt.Location = new System.Drawing.Point(116, 20);
            this.pw_txt.Multiline = true;
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.Size = new System.Drawing.Size(315, 39);
            this.pw_txt.TabIndex = 1;
            this.pw_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pw_txt_MouseClick);
            this.pw_txt.Enter += new System.EventHandler(this.pw_txt_Enter);
            this.pw_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pw_txt_KeyDown);
            this.pw_txt.Leave += new System.EventHandler(this.pw_txt_Leave);
            // 
            // pw_pb
            // 
            this.pw_pb.BackColor = System.Drawing.Color.White;
            this.pw_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pw_pb.Image = global::WindowsFormsApplication1.Properties.Resources.locked_padlock;
            this.pw_pb.Location = new System.Drawing.Point(81, 20);
            this.pw_pb.Name = "pw_pb";
            this.pw_pb.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.pw_pb.Size = new System.Drawing.Size(40, 39);
            this.pw_pb.TabIndex = 5;
            this.pw_pb.TabStop = false;
            this.pw_pb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pw_pb_MouseClick);
            // 
            // pwli_pnl
            // 
            this.pwli_pnl.BackColor = System.Drawing.Color.Transparent;
            this.pwli_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pwli_pnl.Location = new System.Drawing.Point(0, 0);
            this.pwli_pnl.Name = "pwli_pnl";
            this.pwli_pnl.Size = new System.Drawing.Size(10, 83);
            this.pwli_pnl.TabIndex = 3;
            // 
            // close_btn
            // 
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.close_btn.Location = new System.Drawing.Point(489, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(49, 29);
            this.close_btn.TabIndex = 6;
            this.close_btn.TabStop = false;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            this.close_btn.MouseLeave += new System.EventHandler(this.close_btn_MouseLeave);
            this.close_btn.MouseHover += new System.EventHandler(this.close_btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.panel1.Controls.Add(this.logo_lbl);
            this.panel1.Controls.Add(this.lg_pb);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 123);
            this.panel1.TabIndex = 7;
            // 
            // logo_lbl
            // 
            this.logo_lbl.AutoSize = true;
            this.logo_lbl.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_lbl.ForeColor = System.Drawing.Color.White;
            this.logo_lbl.Location = new System.Drawing.Point(79, 46);
            this.logo_lbl.Name = "logo_lbl";
            this.logo_lbl.Size = new System.Drawing.Size(411, 37);
            this.logo_lbl.TabIndex = 8;
            this.logo_lbl.Text = "Golden Needle Apparels (Pvt) Ltd.";
            // 
            // lg_pb
            // 
            this.lg_pb.Image = global::WindowsFormsApplication1.Properties.Resources.need;
            this.lg_pb.Location = new System.Drawing.Point(3, 27);
            this.lg_pb.Name = "lg_pb";
            this.lg_pb.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lg_pb.Size = new System.Drawing.Size(70, 76);
            this.lg_pb.TabIndex = 7;
            this.lg_pb.TabStop = false;
            // 
            // lg_btn
            // 
            this.lg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.lg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lg_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lg_btn.ForeColor = System.Drawing.Color.White;
            this.lg_btn.Image = global::WindowsFormsApplication1.Properties.Resources.shutdown;
            this.lg_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lg_btn.Location = new System.Drawing.Point(370, 406);
            this.lg_btn.Name = "lg_btn";
            this.lg_btn.Size = new System.Drawing.Size(140, 43);
            this.lg_btn.TabIndex = 0;
            this.lg_btn.TabStop = false;
            this.lg_btn.Text = "Login";
            this.lg_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lg_btn.UseVisualStyleBackColor = false;
            this.lg_btn.Click += new System.EventHandler(this.lg_btn_Click);
            // 
            // Error_lbl
            // 
            this.Error_lbl.AutoSize = true;
            this.Error_lbl.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_lbl.Location = new System.Drawing.Point(29, 340);
            this.Error_lbl.Name = "Error_lbl";
            this.Error_lbl.Size = new System.Drawing.Size(39, 17);
            this.Error_lbl.TabIndex = 8;
            this.Error_lbl.Text = "label1";
            this.Error_lbl.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(538, 516);
            this.Controls.Add(this.Error_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pw_pnl);
            this.Controls.Add(this.un_pnl);
            this.Controls.Add(this.lg_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_MouseClick);
            this.un_pnl.ResumeLayout(false);
            this.un_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.un_pb)).EndInit();
            this.pw_pnl.ResumeLayout(false);
            this.pw_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pw_pb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lg_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox un_txt;
        private System.Windows.Forms.Button lg_btn;
        private System.Windows.Forms.Panel un_pnl;
        private System.Windows.Forms.Panel unli_pnl;
        private System.Windows.Forms.Panel pw_pnl;
        private System.Windows.Forms.Panel pwli_pnl;
        private System.Windows.Forms.PictureBox un_pb;
        private System.Windows.Forms.TextBox pw_txt;
        private System.Windows.Forms.PictureBox pw_pb;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox lg_pb;
        private System.Windows.Forms.Label logo_lbl;
        private System.Windows.Forms.Label Error_lbl;
    }
}