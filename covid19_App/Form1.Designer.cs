namespace covid19_App
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.barOlum = new ns1.BunifuCircleProgressbar();
            this.barİyilesen = new ns1.BunifuGauge();
            this.barZaturre = new ns1.BunifuGauge();
            this.barVaka = new ns1.BunifuCircleProgressbar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZaturre = new System.Windows.Forms.Label();
            this.lblToplamTest = new System.Windows.Forms.Label();
            this.lblBugunİyilesen = new System.Windows.Forms.Label();
            this.lblBugunVefat = new System.Windows.Forms.Label();
            this.lblBugunTest = new System.Windows.Forms.Label();
            this.lblBugunHasta = new System.Windows.Forms.Label();
            this.lblToplamİyilesen = new System.Windows.Forms.Label();
            this.lblAgirHasta = new System.Windows.Forms.Label();
            this.lblToplamVefat = new System.Windows.Forms.Label();
            this.lblToplamVaka = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dateSecili = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 486);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(60, 14);
            this.dataGridView1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(493, 471);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 42);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 39);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1179, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1141, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkiye Günlük Covid - 19 Tablosu Api Uygulaması";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(145)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.date2);
            this.panel2.Controls.Add(this.dateSecili);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.barOlum);
            this.panel2.Controls.Add(this.barİyilesen);
            this.panel2.Controls.Add(this.barZaturre);
            this.panel2.Controls.Add(this.barVaka);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 424);
            this.panel2.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(946, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(201, 33);
            this.label17.TabIndex = 7;
            this.label17.Text = "İyileşen Oranı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(668, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 33);
            this.label16.TabIndex = 6;
            this.label16.Text = "Ölüm Oranı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(341, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 33);
            this.label15.TabIndex = 5;
            this.label15.Text = "Zatürre Oranı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(52, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 33);
            this.label14.TabIndex = 3;
            this.label14.Text = "Vaka Oranı";
            // 
            // barOlum
            // 
            this.barOlum.animated = false;
            this.barOlum.animationIterval = 5;
            this.barOlum.animationSpeed = 300;
            this.barOlum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(145)))));
            this.barOlum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barOlum.BackgroundImage")));
            this.barOlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.barOlum.ForeColor = System.Drawing.Color.White;
            this.barOlum.LabelVisible = true;
            this.barOlum.LineProgressThickness = 8;
            this.barOlum.LineThickness = 5;
            this.barOlum.Location = new System.Drawing.Point(655, 187);
            this.barOlum.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barOlum.MaxValue = 100;
            this.barOlum.Name = "barOlum";
            this.barOlum.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.barOlum.ProgressColor = System.Drawing.Color.Fuchsia;
            this.barOlum.Size = new System.Drawing.Size(170, 170);
            this.barOlum.TabIndex = 4;
            this.barOlum.Value = 16;
            // 
            // barİyilesen
            // 
            this.barİyilesen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barİyilesen.BackgroundImage")));
            this.barİyilesen.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.barİyilesen.ForeColor = System.Drawing.Color.White;
            this.barİyilesen.Location = new System.Drawing.Point(923, 187);
            this.barİyilesen.Margin = new System.Windows.Forms.Padding(6);
            this.barİyilesen.Name = "barİyilesen";
            this.barİyilesen.ProgressBgColor = System.Drawing.Color.White;
            this.barİyilesen.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.barİyilesen.ProgressColor2 = System.Drawing.Color.Purple;
            this.barİyilesen.Size = new System.Drawing.Size(242, 170);
            this.barİyilesen.TabIndex = 3;
            this.barİyilesen.Thickness = 30;
            this.barİyilesen.Value = 79;
            // 
            // barZaturre
            // 
            this.barZaturre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barZaturre.BackgroundImage")));
            this.barZaturre.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.barZaturre.ForeColor = System.Drawing.Color.White;
            this.barZaturre.Location = new System.Drawing.Point(310, 187);
            this.barZaturre.Margin = new System.Windows.Forms.Padding(6);
            this.barZaturre.Name = "barZaturre";
            this.barZaturre.ProgressBgColor = System.Drawing.Color.White;
            this.barZaturre.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.barZaturre.ProgressColor2 = System.Drawing.Color.Indigo;
            this.barZaturre.Size = new System.Drawing.Size(242, 170);
            this.barZaturre.TabIndex = 1;
            this.barZaturre.Thickness = 30;
            this.barZaturre.Value = 57;
            // 
            // barVaka
            // 
            this.barVaka.animated = false;
            this.barVaka.animationIterval = 5;
            this.barVaka.animationSpeed = 300;
            this.barVaka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(145)))));
            this.barVaka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barVaka.BackgroundImage")));
            this.barVaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.barVaka.ForeColor = System.Drawing.Color.White;
            this.barVaka.LabelVisible = true;
            this.barVaka.LineProgressThickness = 8;
            this.barVaka.LineThickness = 5;
            this.barVaka.Location = new System.Drawing.Point(43, 187);
            this.barVaka.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barVaka.MaxValue = 100;
            this.barVaka.Name = "barVaka";
            this.barVaka.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.barVaka.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barVaka.Size = new System.Drawing.Size(170, 170);
            this.barVaka.TabIndex = 0;
            this.barVaka.Value = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1221, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(213, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(975, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyright 2021 TBCSOFT All Right Reversed || Design and Coding by Alikper İslam";
            // 
            // lblZaturre
            // 
            this.lblZaturre.AutoSize = true;
            this.lblZaturre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblZaturre.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblZaturre.ForeColor = System.Drawing.Color.White;
            this.lblZaturre.Location = new System.Drawing.Point(489, 517);
            this.lblZaturre.Name = "lblZaturre";
            this.lblZaturre.Size = new System.Drawing.Size(28, 18);
            this.lblZaturre.TabIndex = 1;
            this.lblZaturre.Text = "0.0";
            // 
            // lblToplamTest
            // 
            this.lblToplamTest.AutoSize = true;
            this.lblToplamTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblToplamTest.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblToplamTest.ForeColor = System.Drawing.Color.White;
            this.lblToplamTest.Location = new System.Drawing.Point(123, 517);
            this.lblToplamTest.Name = "lblToplamTest";
            this.lblToplamTest.Size = new System.Drawing.Size(16, 18);
            this.lblToplamTest.TabIndex = 11;
            this.lblToplamTest.Text = "0";
            // 
            // lblBugunİyilesen
            // 
            this.lblBugunİyilesen.AutoSize = true;
            this.lblBugunİyilesen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblBugunİyilesen.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblBugunİyilesen.ForeColor = System.Drawing.Color.White;
            this.lblBugunİyilesen.Location = new System.Drawing.Point(1124, 517);
            this.lblBugunİyilesen.Name = "lblBugunİyilesen";
            this.lblBugunİyilesen.Size = new System.Drawing.Size(16, 18);
            this.lblBugunİyilesen.TabIndex = 12;
            this.lblBugunİyilesen.Text = "0";
            // 
            // lblBugunVefat
            // 
            this.lblBugunVefat.AutoSize = true;
            this.lblBugunVefat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblBugunVefat.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblBugunVefat.ForeColor = System.Drawing.Color.White;
            this.lblBugunVefat.Location = new System.Drawing.Point(1017, 517);
            this.lblBugunVefat.Name = "lblBugunVefat";
            this.lblBugunVefat.Size = new System.Drawing.Size(16, 18);
            this.lblBugunVefat.TabIndex = 13;
            this.lblBugunVefat.Text = "0";
            // 
            // lblBugunTest
            // 
            this.lblBugunTest.AutoSize = true;
            this.lblBugunTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblBugunTest.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblBugunTest.ForeColor = System.Drawing.Color.White;
            this.lblBugunTest.Location = new System.Drawing.Point(904, 517);
            this.lblBugunTest.Name = "lblBugunTest";
            this.lblBugunTest.Size = new System.Drawing.Size(16, 18);
            this.lblBugunTest.TabIndex = 14;
            this.lblBugunTest.Text = "0";
            // 
            // lblBugunHasta
            // 
            this.lblBugunHasta.AutoSize = true;
            this.lblBugunHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblBugunHasta.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblBugunHasta.ForeColor = System.Drawing.Color.White;
            this.lblBugunHasta.Location = new System.Drawing.Point(795, 517);
            this.lblBugunHasta.Name = "lblBugunHasta";
            this.lblBugunHasta.Size = new System.Drawing.Size(16, 18);
            this.lblBugunHasta.TabIndex = 15;
            this.lblBugunHasta.Text = "0";
            // 
            // lblToplamİyilesen
            // 
            this.lblToplamİyilesen.AutoSize = true;
            this.lblToplamİyilesen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblToplamİyilesen.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblToplamİyilesen.ForeColor = System.Drawing.Color.White;
            this.lblToplamİyilesen.Location = new System.Drawing.Point(680, 517);
            this.lblToplamİyilesen.Name = "lblToplamİyilesen";
            this.lblToplamİyilesen.Size = new System.Drawing.Size(16, 18);
            this.lblToplamİyilesen.TabIndex = 16;
            this.lblToplamİyilesen.Text = "0";
            // 
            // lblAgirHasta
            // 
            this.lblAgirHasta.AutoSize = true;
            this.lblAgirHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblAgirHasta.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblAgirHasta.ForeColor = System.Drawing.Color.White;
            this.lblAgirHasta.Location = new System.Drawing.Point(570, 517);
            this.lblAgirHasta.Name = "lblAgirHasta";
            this.lblAgirHasta.Size = new System.Drawing.Size(16, 18);
            this.lblAgirHasta.TabIndex = 17;
            this.lblAgirHasta.Text = "0";
            // 
            // lblToplamVefat
            // 
            this.lblToplamVefat.AutoSize = true;
            this.lblToplamVefat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblToplamVefat.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblToplamVefat.ForeColor = System.Drawing.Color.White;
            this.lblToplamVefat.Location = new System.Drawing.Point(345, 517);
            this.lblToplamVefat.Name = "lblToplamVefat";
            this.lblToplamVefat.Size = new System.Drawing.Size(16, 18);
            this.lblToplamVefat.TabIndex = 18;
            this.lblToplamVefat.Text = "0";
            // 
            // lblToplamVaka
            // 
            this.lblToplamVaka.AutoSize = true;
            this.lblToplamVaka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblToplamVaka.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblToplamVaka.ForeColor = System.Drawing.Color.White;
            this.lblToplamVaka.Location = new System.Drawing.Point(232, 517);
            this.lblToplamVaka.Name = "lblToplamVaka";
            this.lblToplamVaka.Size = new System.Drawing.Size(16, 18);
            this.lblToplamVaka.TabIndex = 19;
            this.lblToplamVaka.Text = "0";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(133)))));
            this.lblTarih.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(4, 517);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(80, 18);
            this.lblTarih.TabIndex = 20;
            this.lblTarih.Text = "00.00.0000\r\n";
            // 
            // dateSecili
            // 
            this.dateSecili.Location = new System.Drawing.Point(43, 47);
            this.dateSecili.Name = "dateSecili";
            this.dateSecili.Size = new System.Drawing.Size(318, 32);
            this.dateSecili.TabIndex = 9;
            this.dateSecili.Value = new System.DateTime(2021, 2, 12, 0, 0, 0, 0);
            this.dateSecili.ValueChanged += new System.EventHandler(this.dateSecili_ValueChanged);
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(543, 47);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(350, 32);
            this.date2.TabIndex = 10;
            this.date2.Value = new System.DateTime(2021, 2, 12, 0, 0, 0, 0);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(479, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 102);
            this.panel4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 599);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblToplamVaka);
            this.Controls.Add(this.lblToplamVefat);
            this.Controls.Add(this.lblAgirHasta);
            this.Controls.Add(this.lblToplamİyilesen);
            this.Controls.Add(this.lblBugunHasta);
            this.Controls.Add(this.lblBugunTest);
            this.Controls.Add(this.lblBugunVefat);
            this.Controls.Add(this.lblBugunİyilesen);
            this.Controls.Add(this.lblToplamTest);
            this.Controls.Add(this.lblZaturre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblToplamVaka;
        private System.Windows.Forms.Label lblToplamVefat;
        private System.Windows.Forms.Label lblAgirHasta;
        private System.Windows.Forms.Label lblToplamİyilesen;
        private System.Windows.Forms.Label lblBugunHasta;
        private System.Windows.Forms.Label lblBugunTest;
        private System.Windows.Forms.Label lblBugunVefat;
        private System.Windows.Forms.Label lblBugunİyilesen;
        private System.Windows.Forms.Label lblToplamTest;
        private System.Windows.Forms.Label lblZaturre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ns1.BunifuGauge barZaturre;
        private ns1.BunifuCircleProgressbar barVaka;
        private ns1.BunifuCircleProgressbar barOlum;
        private ns1.BunifuGauge barİyilesen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateSecili;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker date2;
    }
}

