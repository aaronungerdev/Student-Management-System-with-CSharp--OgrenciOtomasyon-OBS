namespace OgrenciOtomasyon
{
    partial class dersSecimPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dersSecimPanel));
            this.dgwEkliDersler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaldir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGonder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEkliDersler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwEkliDersler
            // 
            this.dgwEkliDersler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgwEkliDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEkliDersler.Location = new System.Drawing.Point(7, 22);
            this.dgwEkliDersler.Margin = new System.Windows.Forms.Padding(4);
            this.dgwEkliDersler.Name = "dgwEkliDersler";
            this.dgwEkliDersler.RowHeadersWidth = 51;
            this.dgwEkliDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEkliDersler.Size = new System.Drawing.Size(1301, 301);
            this.dgwEkliDersler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(370, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklenmiş Dersler";
            // 
            // btnKaldir
            // 
            this.btnKaldir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKaldir.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaldir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaldir.ImageKey = "reject-icon.png";
            this.btnKaldir.ImageList = this.imageList1;
            this.btnKaldir.Location = new System.Drawing.Point(203, 353);
            this.btnKaldir.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaldir.Name = "btnKaldir";
            this.btnKaldir.Size = new System.Drawing.Size(164, 59);
            this.btnKaldir.TabIndex = 15;
            this.btnKaldir.Text = "Listeden \r\nKaldır";
            this.btnKaldir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaldir.UseVisualStyleBackColor = false;
            this.btnKaldir.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pngwing.com1.png");
            this.imageList1.Images.SetKeyName(1, "reject-icon.png");
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGonder.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGonder.ImageKey = "pngwing.com1.png";
            this.btnGonder.ImageList = this.imageList1;
            this.btnGonder.Location = new System.Drawing.Point(19, 353);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(176, 59);
            this.btnGonder.TabIndex = 16;
            this.btnGonder.Text = "Danışmana \r\nGönder";
            this.btnGonder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwEkliDersler);
            this.groupBox1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1315, 334);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekli Dersler";
            // 
            // dersSecimPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1339, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnKaldir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dersSecimPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DERS SEÇİMİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEkliDersler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEkliDersler;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaldir;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}