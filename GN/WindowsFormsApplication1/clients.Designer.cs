namespace WindowsFormsApplication1
{
    partial class clients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pay = new System.Windows.Forms.Button();
            this.sam = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.ord = new System.Windows.Forms.Button();
            this.da = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.sub_ord = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.viewc = new System.Windows.Forms.Button();
            this.addc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pay);
            this.panel1.Controls.Add(this.sam);
            this.panel1.Controls.Add(this.cl);
            this.panel1.Controls.Add(this.ord);
            this.panel1.Controls.Add(this.da);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 510);
            this.panel1.TabIndex = 0;
            // 
            // pay
            // 
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pay.Image = global::WindowsFormsApplication1.Properties.Resources.cc;
            this.pay.Location = new System.Drawing.Point(0, 413);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(239, 68);
            this.pay.TabIndex = 2;
            this.pay.Text = "Payments";
            this.pay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // sam
            // 
            this.sam.FlatAppearance.BorderSize = 0;
            this.sam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sam.Image = global::WindowsFormsApplication1.Properties.Resources.jacket;
            this.sam.Location = new System.Drawing.Point(0, 328);
            this.sam.Name = "sam";
            this.sam.Size = new System.Drawing.Size(239, 68);
            this.sam.TabIndex = 1;
            this.sam.Text = "Samples";
            this.sam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sam.UseVisualStyleBackColor = true;
            this.sam.Click += new System.EventHandler(this.sam_Click);
            this.sam.MouseLeave += new System.EventHandler(this.sam_MouseLeave);
            this.sam.MouseHover += new System.EventHandler(this.sam_MouseHover);
            // 
            // cl
            // 
            this.cl.FlatAppearance.BorderSize = 0;
            this.cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cl.Image = global::WindowsFormsApplication1.Properties.Resources.cp;
            this.cl.Location = new System.Drawing.Point(0, 254);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(239, 68);
            this.cl.TabIndex = 1;
            this.cl.Text = "Clients";
            this.cl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            this.cl.MouseLeave += new System.EventHandler(this.cl_MouseLeave);
            this.cl.MouseHover += new System.EventHandler(this.cl_MouseHover);
            // 
            // ord
            // 
            this.ord.FlatAppearance.BorderSize = 0;
            this.ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ord.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ord.Image = global::WindowsFormsApplication1.Properties.Resources.list;
            this.ord.Location = new System.Drawing.Point(0, 180);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(239, 68);
            this.ord.TabIndex = 1;
            this.ord.Text = "Orders";
            this.ord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ord.UseVisualStyleBackColor = true;
            this.ord.Click += new System.EventHandler(this.ord_Click);
            this.ord.MouseLeave += new System.EventHandler(this.ord_MouseLeave);
            this.ord.MouseHover += new System.EventHandler(this.ord_MouseHover);
            // 
            // da
            // 
            this.da.FlatAppearance.BorderSize = 0;
            this.da.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.da.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.da.Image = global::WindowsFormsApplication1.Properties.Resources.db;
            this.da.Location = new System.Drawing.Point(0, 106);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(239, 68);
            this.da.TabIndex = 1;
            this.da.Text = "Dash Board";
            this.da.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.da.UseVisualStyleBackColor = true;
            this.da.Click += new System.EventHandler(this.da_Click);
            this.da.MouseLeave += new System.EventHandler(this.da_MouseLeave);
            this.da.MouseHover += new System.EventHandler(this.da_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.panel3.Controls.Add(this.title);
            this.panel3.Controls.Add(this.pb1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 100);
            this.panel3.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(65, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 56);
            this.title.TabIndex = 1;
            this.title.Text = " Golden Needle\r\nApparels (Pvt) Ltd.";
            // 
            // pb1
            // 
            this.pb1.Image = global::WindowsFormsApplication1.Properties.Resources.need;
            this.pb1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.need;
            this.pb1.Location = new System.Drawing.Point(3, 21);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(60, 75);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.sub_ord);
            this.panel2.Controls.Add(this.close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 100);
            this.panel2.TabIndex = 1;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(544, 83);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(38, 13);
            this.time.TabIndex = 2;
            this.time.Text = "label1";
            // 
            // sub_ord
            // 
            this.sub_ord.AutoSize = true;
            this.sub_ord.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_ord.Location = new System.Drawing.Point(17, 75);
            this.sub_ord.Name = "sub_ord";
            this.sub_ord.Size = new System.Drawing.Size(57, 21);
            this.sub_ord.TabIndex = 1;
            this.sub_ord.Text = "Clients";
            this.sub_ord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(628, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // viewc
            // 
            this.viewc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.viewc.FlatAppearance.BorderSize = 0;
            this.viewc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewc.Image = global::WindowsFormsApplication1.Properties.Resources.serCli;
            this.viewc.Location = new System.Drawing.Point(612, 180);
            this.viewc.Name = "viewc";
            this.viewc.Size = new System.Drawing.Size(239, 134);
            this.viewc.TabIndex = 1;
            this.viewc.Text = "     View  Clients";
            this.viewc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.viewc.UseVisualStyleBackColor = false;
            this.viewc.Click += new System.EventHandler(this.viewc_Click);
            this.viewc.MouseLeave += new System.EventHandler(this.viewc_MouseLeave);
            this.viewc.MouseHover += new System.EventHandler(this.viewc_MouseHover);
            // 
            // addc
            // 
            this.addc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.addc.FlatAppearance.BorderSize = 0;
            this.addc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addc.Image = global::WindowsFormsApplication1.Properties.Resources.cli;
            this.addc.Location = new System.Drawing.Point(311, 180);
            this.addc.Name = "addc";
            this.addc.Size = new System.Drawing.Size(239, 134);
            this.addc.TabIndex = 1;
            this.addc.Text = "      Add Clients";
            this.addc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addc.UseVisualStyleBackColor = false;
            this.addc.Click += new System.EventHandler(this.addc_Click_1);
            this.addc.MouseLeave += new System.EventHandler(this.addc_MouseLeave);
            this.addc.MouseHover += new System.EventHandler(this.addc_MouseHover);
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewc);
            this.Controls.Add(this.addc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.clients_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button da;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sam;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button ord;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label sub_ord;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button addc;
        private System.Windows.Forms.Button viewc;
        private System.Windows.Forms.Button pay;
    }
}

