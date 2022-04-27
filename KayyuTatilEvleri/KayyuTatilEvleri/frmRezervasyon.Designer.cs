
namespace KayyuTatilEvleri
{
    partial class frmRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.Rezervasyon = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOdemeYontemi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Rezervasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnRezervasyonYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.Black;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(0, 32);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(119, 32);
            this.btnRezervasyonYap.TabIndex = 16;
            this.btnRezervasyonYap.Text = "Ekle";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // Rezervasyon
            // 
            this.Rezervasyon.Controls.Add(this.button2);
            this.Rezervasyon.Controls.Add(this.button1);
            this.Rezervasyon.Controls.Add(this.btnRezervasyonYap);
            this.Rezervasyon.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rezervasyon.Location = new System.Drawing.Point(28, 416);
            this.Rezervasyon.Name = "Rezervasyon";
            this.Rezervasyon.Size = new System.Drawing.Size(156, 178);
            this.Rezervasyon.TabIndex = 17;
            this.Rezervasyon.TabStop = false;
            this.Rezervasyon.Text = "Rezervasyon";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeBaslangic.Location = new System.Drawing.Point(547, 427);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(200, 33);
            this.dateTimeBaslangic.TabIndex = 18;
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeBitis.Location = new System.Drawing.Point(547, 469);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(200, 33);
            this.dateTimeBitis.TabIndex = 19;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(547, 549);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(200, 33);
            this.txtTutar.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(547, 588);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 96);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(386, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(386, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(380, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ödeme Yöntemi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(472, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tutar :";
            // 
            // cmbOdemeYontemi
            // 
            this.cmbOdemeYontemi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeYontemi.FormattingEnabled = true;
            this.cmbOdemeYontemi.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit"});
            this.cmbOdemeYontemi.Location = new System.Drawing.Point(547, 509);
            this.cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            this.cmbOdemeYontemi.Size = new System.Drawing.Size(200, 34);
            this.cmbOdemeYontemi.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(440, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Açıklama :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(804, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 35);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(847, 696);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.cmbOdemeYontemi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.Rezervasyon);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervasyon";
            this.Text = "frmRezervasyon";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Rezervasyon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.GroupBox Rezervasyon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOdemeYontemi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}