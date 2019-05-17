namespace WindowsFormsApplication1
{
    partial class viewOrd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.sub_d = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.viewOgrid = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goldenDataSet2 = new WindowsFormsApplication1.GoldenDataSet2();
            this.goldenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goldenDataSet = new WindowsFormsApplication1.GoldenDataSet();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyerTableAdapter = new WindowsFormsApplication1.GoldenDataSetTableAdapters.BuyerTableAdapter();
            this.ordersTableAdapter = new WindowsFormsApplication1.GoldenDataSet2TableAdapters.OrdersTableAdapter();
            this.searchtx = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(234, 585);
            this.panel1.TabIndex = 0;
            // 
            // pay
            // 
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pay.Image = global::WindowsFormsApplication1.Properties.Resources.cc;
            this.pay.Location = new System.Drawing.Point(0, 402);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(234, 68);
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
            this.sam.Size = new System.Drawing.Size(234, 68);
            this.sam.TabIndex = 1;
            this.sam.Text = "Samples";
            this.sam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sam.UseVisualStyleBackColor = true;
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
            this.cl.Size = new System.Drawing.Size(234, 68);
            this.cl.TabIndex = 1;
            this.cl.Text = "Clients";
            this.cl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cl.UseVisualStyleBackColor = true;
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
            this.ord.Size = new System.Drawing.Size(234, 68);
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
            this.da.Size = new System.Drawing.Size(234, 68);
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
            this.panel3.Size = new System.Drawing.Size(234, 100);
            this.panel3.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(61, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(181, 60);
            this.title.TabIndex = 1;
            this.title.Text = " Golden Needle\r\nApparels (Pvt) Ltd.";
            // 
            // pb1
            // 
            this.pb1.Image = global::WindowsFormsApplication1.Properties.Resources.need;
            this.pb1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.need;
            this.pb1.Location = new System.Drawing.Point(3, 21);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(56, 65);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.sub_d);
            this.panel2.Controls.Add(this.close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 100);
            this.panel2.TabIndex = 1;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(1032, 82);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(38, 13);
            this.time.TabIndex = 2;
            this.time.Text = "label1";
            // 
            // sub_d
            // 
            this.sub_d.AutoSize = true;
            this.sub_d.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_d.Location = new System.Drawing.Point(4, 76);
            this.sub_d.Name = "sub_d";
            this.sub_d.Size = new System.Drawing.Size(93, 21);
            this.sub_d.TabIndex = 1;
            this.sub_d.Text = "View Orders";
            this.sub_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1041, 0);
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
            // viewOgrid
            // 
            this.viewOgrid.AllowUserToAddRows = false;
            this.viewOgrid.AllowUserToDeleteRows = false;
            this.viewOgrid.AllowUserToResizeColumns = false;
            this.viewOgrid.AllowUserToResizeRows = false;
            this.viewOgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewOgrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewOgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewOgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewOgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewOgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewOgrid.ColumnHeadersHeight = 41;
            this.viewOgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewOgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewOgrid.EnableHeadersVisualStyles = false;
            this.viewOgrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewOgrid.Location = new System.Drawing.Point(240, 234);
            this.viewOgrid.MultiSelect = false;
            this.viewOgrid.Name = "viewOgrid";
            this.viewOgrid.RowHeadersVisible = false;
            this.viewOgrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.viewOgrid.RowTemplate.Height = 40;
            this.viewOgrid.RowTemplate.ReadOnly = true;
            this.viewOgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewOgrid.Size = new System.Drawing.Size(1072, 248);
            this.viewOgrid.TabIndex = 2;
            this.viewOgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewOgrid_CellContentClick);
            this.viewOgrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.viewOgrid_CellFormatting);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.goldenDataSet2;
            // 
            // goldenDataSet2
            // 
            this.goldenDataSet2.DataSetName = "GoldenDataSet2";
            this.goldenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goldenDataSetBindingSource
            // 
            this.goldenDataSetBindingSource.DataSource = this.goldenDataSet;
            this.goldenDataSetBindingSource.Position = 0;
            // 
            // goldenDataSet
            // 
            this.goldenDataSet.DataSetName = "GoldenDataSet";
            this.goldenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "Buyer";
            this.buyerBindingSource.DataSource = this.goldenDataSetBindingSource;
            // 
            // buyerTableAdapter
            // 
            this.buyerTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // searchtx
            // 
            this.searchtx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtx.Location = new System.Drawing.Point(469, 151);
            this.searchtx.Name = "searchtx";
            this.searchtx.Size = new System.Drawing.Size(227, 35);
            this.searchtx.TabIndex = 3;
            this.searchtx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Image = global::WindowsFormsApplication1.Properties.Resources.search;
            this.Search.Location = new System.Drawing.Point(702, 151);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 38);
            this.Search.TabIndex = 4;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.MouseLeave += new System.EventHandler(this.Search_MouseLeave);
            this.Search.MouseHover += new System.EventHandler(this.Search_MouseHover);
            // 
            // delete_btn
            // 
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(1050, 156);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 30);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(969, 156);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 30);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // viewOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 585);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.searchtx);
            this.Controls.Add(this.viewOgrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewOrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewOrd_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label sub_d;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource goldenDataSetBindingSource;
        private GoldenDataSet goldenDataSet;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private GoldenDataSetTableAdapters.BuyerTableAdapter buyerTableAdapter;
        private GoldenDataSet2 goldenDataSet2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private GoldenDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.TextBox searchtx;
        private System.Windows.Forms.Button Search;
        public System.Windows.Forms.DataGridView viewOgrid;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button pay;
    }
}

