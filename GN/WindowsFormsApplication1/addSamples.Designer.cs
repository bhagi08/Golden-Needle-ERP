namespace WindowsFormsApplication1
{
    partial class addSamples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSamples));
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
            this.log_pnl = new System.Windows.Forms.Panel();
            this.grt_lbl = new System.Windows.Forms.Label();
            this.nm_lbl = new System.Windows.Forms.Label();
            this.profPic_pnl = new System.Windows.Forms.Panel();
            this.prof_pb = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.sub_d = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saId_lbl = new System.Windows.Forms.Label();
            this.oId_lbl = new System.Windows.Forms.Label();
            this.bc_lbl = new System.Windows.Forms.Label();
            this.val_lbl = new System.Windows.Forms.Label();
            this.delDat_lbl = new System.Windows.Forms.Label();
            this.Fpic_lbl = new System.Windows.Forms.Label();
            this.sam_txt = new System.Windows.Forms.TextBox();
            this.oid_cmb = new System.Windows.Forms.ComboBox();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goldenDataSet4 = new WindowsFormsApplication1.GoldenDataSet4();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.date_dtp = new System.Windows.Forms.DateTimePicker();
            this.fp_txt = new System.Windows.Forms.TextBox();
            this.fcBrw_btn = new System.Windows.Forms.Button();
            this.addSa_btn = new System.Windows.Forms.Button();
            this.clrSa_btn = new System.Windows.Forms.Button();
            this.demo = new System.Windows.Forms.Button();
            this.buyerTableAdapter = new WindowsFormsApplication1.GoldenDataSet4TableAdapters.BuyerTableAdapter();
            this.goldenDataSet5 = new WindowsFormsApplication1.GoldenDataSet5();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTableAdapter = new WindowsFormsApplication1.GoldenDataSet5TableAdapters.CurrencyTableAdapter();
            this.bc_txt = new System.Windows.Forms.TextBox();
            this.goldenDataSet6 = new WindowsFormsApplication1.GoldenDataSet6();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WindowsFormsApplication1.GoldenDataSet6TableAdapters.OrdersTableAdapter();
            this.e0 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.e4 = new System.Windows.Forms.Label();
            this.fp_pb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panel2.SuspendLayout();
            this.log_pnl.SuspendLayout();
            this.profPic_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prof_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_pb)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(239, 575);
            this.panel1.TabIndex = 0;
            // 
            // pay
            // 
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pay.Image = global::WindowsFormsApplication1.Properties.Resources.cc;
            this.pay.Location = new System.Drawing.Point(0, 442);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(239, 68);
            this.pay.TabIndex = 1;
            this.pay.Text = "Payments";
            this.pay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            this.pay.MouseLeave += new System.EventHandler(this.pay_MouseLeave);
            this.pay.MouseHover += new System.EventHandler(this.pay_MouseHover);
            // 
            // sam
            // 
            this.sam.FlatAppearance.BorderSize = 0;
            this.sam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sam.Image = global::WindowsFormsApplication1.Properties.Resources.jacket;
            this.sam.Location = new System.Drawing.Point(3, 349);
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
            this.cl.Location = new System.Drawing.Point(0, 258);
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
            this.ord.Location = new System.Drawing.Point(0, 189);
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
            this.da.Location = new System.Drawing.Point(0, 113);
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
            this.panel3.Size = new System.Drawing.Size(239, 111);
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
            this.pb1.Size = new System.Drawing.Size(60, 65);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.log_pnl);
            this.panel2.Controls.Add(this.sub_d);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 111);
            this.panel2.TabIndex = 1;
            // 
            // log_pnl
            // 
            this.log_pnl.Controls.Add(this.grt_lbl);
            this.log_pnl.Controls.Add(this.nm_lbl);
            this.log_pnl.Controls.Add(this.profPic_pnl);
            this.log_pnl.Controls.Add(this.time);
            this.log_pnl.Controls.Add(this.close);
            this.log_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.log_pnl.Location = new System.Drawing.Point(892, 0);
            this.log_pnl.Name = "log_pnl";
            this.log_pnl.Size = new System.Drawing.Size(182, 111);
            this.log_pnl.TabIndex = 3;
            // 
            // grt_lbl
            // 
            this.grt_lbl.Font = new System.Drawing.Font("Segoe UI Semilight", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grt_lbl.Location = new System.Drawing.Point(32, 17);
            this.grt_lbl.Name = "grt_lbl";
            this.grt_lbl.Size = new System.Drawing.Size(53, 44);
            this.grt_lbl.TabIndex = 4;
            this.grt_lbl.Text = "Hi";
            this.grt_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nm_lbl
            // 
            this.nm_lbl.AutoSize = true;
            this.nm_lbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_lbl.Location = new System.Drawing.Point(30, 61);
            this.nm_lbl.Name = "nm_lbl";
            this.nm_lbl.Size = new System.Drawing.Size(57, 25);
            this.nm_lbl.TabIndex = 3;
            this.nm_lbl.Text = "name";
            this.nm_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profPic_pnl
            // 
            this.profPic_pnl.BackColor = System.Drawing.Color.White;
            this.profPic_pnl.Controls.Add(this.prof_pb);
            this.profPic_pnl.Location = new System.Drawing.Point(93, 25);
            this.profPic_pnl.Name = "profPic_pnl";
            this.profPic_pnl.Size = new System.Drawing.Size(77, 67);
            this.profPic_pnl.TabIndex = 2;
            // 
            // prof_pb
            // 
            this.prof_pb.BackColor = System.Drawing.Color.Black;
            this.prof_pb.Location = new System.Drawing.Point(3, 0);
            this.prof_pb.Name = "prof_pb";
            this.prof_pb.Size = new System.Drawing.Size(74, 67);
            this.prof_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prof_pb.TabIndex = 3;
            this.prof_pb.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(29, 93);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 17);
            this.time.TabIndex = 2;
            this.time.Text = "time";
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(153, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // sub_d
            // 
            this.sub_d.AutoSize = true;
            this.sub_d.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_d.Location = new System.Drawing.Point(4, 86);
            this.sub_d.Name = "sub_d";
            this.sub_d.Size = new System.Drawing.Size(99, 21);
            this.sub_d.TabIndex = 1;
            this.sub_d.Text = "Add Samples";
            this.sub_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saId_lbl
            // 
            this.saId_lbl.AutoSize = true;
            this.saId_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saId_lbl.Location = new System.Drawing.Point(289, 167);
            this.saId_lbl.Name = "saId_lbl";
            this.saId_lbl.Size = new System.Drawing.Size(67, 17);
            this.saId_lbl.TabIndex = 2;
            this.saId_lbl.Text = "Sample ID";
            // 
            // oId_lbl
            // 
            this.oId_lbl.AutoSize = true;
            this.oId_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oId_lbl.Location = new System.Drawing.Point(289, 228);
            this.oId_lbl.Name = "oId_lbl";
            this.oId_lbl.Size = new System.Drawing.Size(59, 17);
            this.oId_lbl.TabIndex = 2;
            this.oId_lbl.Text = "Order ID";
            // 
            // bc_lbl
            // 
            this.bc_lbl.AutoSize = true;
            this.bc_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_lbl.Location = new System.Drawing.Point(289, 289);
            this.bc_lbl.Name = "bc_lbl";
            this.bc_lbl.Size = new System.Drawing.Size(75, 17);
            this.bc_lbl.TabIndex = 2;
            this.bc_lbl.Text = "Buyer Code";
            // 
            // val_lbl
            // 
            this.val_lbl.AutoSize = true;
            this.val_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_lbl.Location = new System.Drawing.Point(289, 349);
            this.val_lbl.Name = "val_lbl";
            this.val_lbl.Size = new System.Drawing.Size(93, 17);
            this.val_lbl.TabIndex = 2;
            this.val_lbl.Text = "Cost ( in USD )";
            // 
            // delDat_lbl
            // 
            this.delDat_lbl.AutoSize = true;
            this.delDat_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDat_lbl.Location = new System.Drawing.Point(289, 422);
            this.delDat_lbl.Name = "delDat_lbl";
            this.delDat_lbl.Size = new System.Drawing.Size(94, 17);
            this.delDat_lbl.TabIndex = 2;
            this.delDat_lbl.Text = "Delivered Date";
            // 
            // Fpic_lbl
            // 
            this.Fpic_lbl.AutoSize = true;
            this.Fpic_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fpic_lbl.Location = new System.Drawing.Point(766, 159);
            this.Fpic_lbl.Name = "Fpic_lbl";
            this.Fpic_lbl.Size = new System.Drawing.Size(81, 17);
            this.Fpic_lbl.TabIndex = 2;
            this.Fpic_lbl.Text = "Front Picture";
            // 
            // sam_txt
            // 
            this.sam_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sam_txt.Location = new System.Drawing.Point(409, 164);
            this.sam_txt.Name = "sam_txt";
            this.sam_txt.Size = new System.Drawing.Size(217, 25);
            this.sam_txt.TabIndex = 3;
            // 
            // oid_cmb
            // 
            this.oid_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.oid_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.oid_cmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oid_cmb.FormattingEnabled = true;
            this.oid_cmb.Location = new System.Drawing.Point(409, 220);
            this.oid_cmb.Name = "oid_cmb";
            this.oid_cmb.Size = new System.Drawing.Size(217, 25);
            this.oid_cmb.TabIndex = 4;
            this.oid_cmb.SelectedIndexChanged += new System.EventHandler(this.oid_cmb_SelectedIndexChanged_1);
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "Buyer";
            this.buyerBindingSource.DataSource = this.goldenDataSet4;
            // 
            // goldenDataSet4
            // 
            this.goldenDataSet4.DataSetName = "GoldenDataSet4";
            this.goldenDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cost_txt
            // 
            this.cost_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_txt.Location = new System.Drawing.Point(409, 346);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.Size = new System.Drawing.Size(217, 25);
            this.cost_txt.TabIndex = 6;
            this.cost_txt.TextChanged += new System.EventHandler(this.codt_txt_TextChanged);
            this.cost_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cost_txt_KeyPress);
            this.cost_txt.Leave += new System.EventHandler(this.cost_txt_Leave);
            // 
            // date_dtp
            // 
            this.date_dtp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dtp.Location = new System.Drawing.Point(409, 414);
            this.date_dtp.Name = "date_dtp";
            this.date_dtp.Size = new System.Drawing.Size(217, 25);
            this.date_dtp.TabIndex = 7;
            // 
            // fp_txt
            // 
            this.fp_txt.Enabled = false;
            this.fp_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_txt.Location = new System.Drawing.Point(853, 159);
            this.fp_txt.Name = "fp_txt";
            this.fp_txt.Size = new System.Drawing.Size(212, 25);
            this.fp_txt.TabIndex = 10;
            // 
            // fcBrw_btn
            // 
            this.fcBrw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fcBrw_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fcBrw_btn.Location = new System.Drawing.Point(853, 190);
            this.fcBrw_btn.Name = "fcBrw_btn";
            this.fcBrw_btn.Size = new System.Drawing.Size(75, 25);
            this.fcBrw_btn.TabIndex = 11;
            this.fcBrw_btn.Text = "Browse";
            this.fcBrw_btn.UseVisualStyleBackColor = true;
            this.fcBrw_btn.Click += new System.EventHandler(this.fcBrw_btn_Click);
            // 
            // addSa_btn
            // 
            this.addSa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSa_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSa_btn.Location = new System.Drawing.Point(1118, 526);
            this.addSa_btn.Name = "addSa_btn";
            this.addSa_btn.Size = new System.Drawing.Size(75, 37);
            this.addSa_btn.TabIndex = 11;
            this.addSa_btn.Text = "Add";
            this.addSa_btn.UseVisualStyleBackColor = true;
            this.addSa_btn.Click += new System.EventHandler(this.addSa_btn_Click);
            // 
            // clrSa_btn
            // 
            this.clrSa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrSa_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrSa_btn.Location = new System.Drawing.Point(1224, 526);
            this.clrSa_btn.Name = "clrSa_btn";
            this.clrSa_btn.Size = new System.Drawing.Size(75, 37);
            this.clrSa_btn.TabIndex = 11;
            this.clrSa_btn.Text = "Clear";
            this.clrSa_btn.UseVisualStyleBackColor = true;
            this.clrSa_btn.Click += new System.EventHandler(this.clrSa_btn_Click);
            // 
            // demo
            // 
            this.demo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.demo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demo.Location = new System.Drawing.Point(292, 526);
            this.demo.Name = "demo";
            this.demo.Size = new System.Drawing.Size(75, 37);
            this.demo.TabIndex = 11;
            this.demo.Text = "Demo";
            this.demo.UseVisualStyleBackColor = true;
            // 
            // buyerTableAdapter
            // 
            this.buyerTableAdapter.ClearBeforeFill = true;
            // 
            // goldenDataSet5
            // 
            this.goldenDataSet5.DataSetName = "GoldenDataSet5";
            this.goldenDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.goldenDataSet5;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // bc_txt
            // 
            this.bc_txt.Enabled = false;
            this.bc_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_txt.Location = new System.Drawing.Point(409, 286);
            this.bc_txt.Name = "bc_txt";
            this.bc_txt.Size = new System.Drawing.Size(217, 25);
            this.bc_txt.TabIndex = 3;
            // 
            // goldenDataSet6
            // 
            this.goldenDataSet6.DataSetName = "GoldenDataSet6";
            this.goldenDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.goldenDataSet6;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // e0
            // 
            this.e0.AutoSize = true;
            this.e0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e0.Location = new System.Drawing.Point(247, 118);
            this.e0.Name = "e0";
            this.e0.Size = new System.Drawing.Size(22, 17);
            this.e0.TabIndex = 12;
            this.e0.Text = "e0";
            this.e0.Visible = false;
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(629, 223);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(22, 17);
            this.e2.TabIndex = 13;
            this.e2.Text = "e2";
            this.e2.Visible = false;
            // 
            // e4
            // 
            this.e4.AutoSize = true;
            this.e4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e4.Location = new System.Drawing.Point(629, 350);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(22, 17);
            this.e4.TabIndex = 14;
            this.e4.Text = "e4";
            this.e4.Visible = false;
            // 
            // fp_pb
            // 
            this.fp_pb.Image = global::WindowsFormsApplication1.Properties.Resources.picture1;
            this.fp_pb.InitialImage = global::WindowsFormsApplication1.Properties.Resources.add_image;
            this.fp_pb.Location = new System.Drawing.Point(1071, 159);
            this.fp_pb.Name = "fp_pb";
            this.fp_pb.Size = new System.Drawing.Size(182, 167);
            this.fp_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fp_pb.TabIndex = 9;
            this.fp_pb.TabStop = false;
            // 
            // addSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 575);
            this.Controls.Add(this.e4);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e0);
            this.Controls.Add(this.demo);
            this.Controls.Add(this.clrSa_btn);
            this.Controls.Add(this.addSa_btn);
            this.Controls.Add(this.fcBrw_btn);
            this.Controls.Add(this.fp_txt);
            this.Controls.Add(this.fp_pb);
            this.Controls.Add(this.date_dtp);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.oid_cmb);
            this.Controls.Add(this.bc_txt);
            this.Controls.Add(this.sam_txt);
            this.Controls.Add(this.Fpic_lbl);
            this.Controls.Add(this.delDat_lbl);
            this.Controls.Add(this.val_lbl);
            this.Controls.Add(this.bc_lbl);
            this.Controls.Add(this.oId_lbl);
            this.Controls.Add(this.saId_lbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addSamples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.addSamples_frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.log_pnl.ResumeLayout(false);
            this.log_pnl.PerformLayout();
            this.profPic_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prof_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_pb)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saId_lbl;
        private System.Windows.Forms.Label oId_lbl;
        private System.Windows.Forms.Label bc_lbl;
        private System.Windows.Forms.Label val_lbl;
        private System.Windows.Forms.Label delDat_lbl;
        private System.Windows.Forms.Label Fpic_lbl;
        private System.Windows.Forms.TextBox sam_txt;
        private System.Windows.Forms.ComboBox oid_cmb;
        private System.Windows.Forms.TextBox cost_txt;
        private System.Windows.Forms.DateTimePicker date_dtp;
        private System.Windows.Forms.Panel log_pnl;
        private System.Windows.Forms.Label grt_lbl;
        private System.Windows.Forms.Label nm_lbl;
        private System.Windows.Forms.Panel profPic_pnl;
        private System.Windows.Forms.PictureBox prof_pb;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox fp_pb;
        private System.Windows.Forms.TextBox fp_txt;
        private System.Windows.Forms.Button fcBrw_btn;
        private System.Windows.Forms.Button addSa_btn;
        private System.Windows.Forms.Button clrSa_btn;
        private System.Windows.Forms.Button demo;
        private GoldenDataSet4 goldenDataSet4;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private GoldenDataSet4TableAdapters.BuyerTableAdapter buyerTableAdapter;
        private GoldenDataSet5 goldenDataSet5;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private GoldenDataSet5TableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.TextBox bc_txt;
        private GoldenDataSet6 goldenDataSet6;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private GoldenDataSet6TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Label e0;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Label e4;
        private System.Windows.Forms.Button pay;
    }
}

