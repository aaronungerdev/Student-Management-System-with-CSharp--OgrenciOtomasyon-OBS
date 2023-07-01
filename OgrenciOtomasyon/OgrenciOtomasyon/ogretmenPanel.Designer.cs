namespace OgrenciOtomasyon
{
    partial class ogretmenPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretmenPanel));
            this.label4 = new System.Windows.Forms.Label();
            this.txbNo = new System.Windows.Forms.TextBox();
            this.txbBrans = new System.Windows.Forms.TextBox();
            this.txbSoyadi = new System.Windows.Forms.TextBox();
            this.txbAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.dgwDersler = new System.Windows.Forms.DataGridView();
            this.btnOnay = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNotGir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Öğretmen No:";
            // 
            // txbNo
            // 
            this.txbNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNo.Location = new System.Drawing.Point(199, 238);
            this.txbNo.Margin = new System.Windows.Forms.Padding(4);
            this.txbNo.Name = "txbNo";
            this.txbNo.ReadOnly = true;
            this.txbNo.Size = new System.Drawing.Size(203, 27);
            this.txbNo.TabIndex = 10;
            this.txbNo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txbBrans
            // 
            this.txbBrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbBrans.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrans.Location = new System.Drawing.Point(199, 172);
            this.txbBrans.Margin = new System.Windows.Forms.Padding(4);
            this.txbBrans.Name = "txbBrans";
            this.txbBrans.ReadOnly = true;
            this.txbBrans.Size = new System.Drawing.Size(203, 27);
            this.txbBrans.TabIndex = 7;
            // 
            // txbSoyadi
            // 
            this.txbSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbSoyadi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoyadi.Location = new System.Drawing.Point(199, 106);
            this.txbSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoyadi.Name = "txbSoyadi";
            this.txbSoyadi.ReadOnly = true;
            this.txbSoyadi.Size = new System.Drawing.Size(203, 27);
            this.txbSoyadi.TabIndex = 8;
            // 
            // txbAdi
            // 
            this.txbAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbAdi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAdi.Location = new System.Drawing.Point(199, 40);
            this.txbAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txbAdi.Name = "txbAdi";
            this.txbAdi.ReadOnly = true;
            this.txbAdi.Size = new System.Drawing.Size(203, 27);
            this.txbAdi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğretmen Branşı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğretmen Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Öğretmen Adı:";
            // 
            // dgwOgrenciler
            // 
            this.dgwOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOgrenciler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgwOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciler.Location = new System.Drawing.Point(7, 29);
            this.dgwOgrenciler.Margin = new System.Windows.Forms.Padding(4);
            this.dgwOgrenciler.Name = "dgwOgrenciler";
            this.dgwOgrenciler.RowHeadersWidth = 51;
            this.dgwOgrenciler.Size = new System.Drawing.Size(1248, 210);
            this.dgwOgrenciler.TabIndex = 12;
            this.dgwOgrenciler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgwDersler
            // 
            this.dgwDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDersler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwDersler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgwDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDersler.Location = new System.Drawing.Point(7, 22);
            this.dgwDersler.Margin = new System.Windows.Forms.Padding(4);
            this.dgwDersler.Name = "dgwDersler";
            this.dgwDersler.RowHeadersWidth = 51;
            this.dgwDersler.Size = new System.Drawing.Size(816, 205);
            this.dgwDersler.TabIndex = 13;
            this.dgwDersler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOnay.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnay.ImageKey = "1004739.png";
            this.btnOnay.ImageList = this.imageList1;
            this.btnOnay.Location = new System.Drawing.Point(867, 16);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(193, 63);
            this.btnOnay.TabIndex = 18;
            this.btnOnay.Text = "Danışman \r\nOnay";
            this.btnOnay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1004739.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            // 
            // btnNotGir
            // 
            this.btnNotGir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNotGir.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotGir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotGir.ImageKey = "add.png";
            this.btnNotGir.ImageList = this.imageList1;
            this.btnNotGir.Location = new System.Drawing.Point(1081, 16);
            this.btnNotGir.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotGir.Name = "btnNotGir";
            this.btnNotGir.Size = new System.Drawing.Size(193, 63);
            this.btnNotGir.TabIndex = 19;
            this.btnNotGir.Text = "Not \r\nGirişi";
            this.btnNotGir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotGir.UseVisualStyleBackColor = false;
            this.btnNotGir.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbSoyadi);
            this.groupBox1.Controls.Add(this.txbBrans);
            this.groupBox1.Controls.Add(this.txbNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 320);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwOgrenciler);
            this.groupBox2.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1262, 253);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danışmanlık Yapılan Öğrenciler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwDersler);
            this.groupBox3.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(444, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 234);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Derslerim";
            // 
            // ogretmenPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1284, 605);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNotGir);
            this.Controls.Add(this.btnOnay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ogretmenPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRETMEN PANELİ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbNo;
        public System.Windows.Forms.TextBox txbBrans;
        public System.Windows.Forms.TextBox txbSoyadi;
        public System.Windows.Forms.TextBox txbAdi;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.DataGridView dgwDersler;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnNotGir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ImageList imageList1;
    }
}