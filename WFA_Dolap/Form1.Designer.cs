
namespace WFA_Dolap
{
    partial class Form1
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
            this.lstAyakkabi = new System.Windows.Forms.ListBox();
            this.lstTshirt = new System.Windows.Forms.ListBox();
            this.lstPantolon = new System.Windows.Forms.ListBox();
            this.lstMont = new System.Windows.Forms.ListBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAyakkabi
            // 
            this.lstAyakkabi.FormattingEnabled = true;
            this.lstAyakkabi.ItemHeight = 20;
            this.lstAyakkabi.Location = new System.Drawing.Point(36, 37);
            this.lstAyakkabi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAyakkabi.Name = "lstAyakkabi";
            this.lstAyakkabi.Size = new System.Drawing.Size(370, 444);
            this.lstAyakkabi.TabIndex = 0;
            this.lstAyakkabi.DoubleClick += new System.EventHandler(this.lstAyakkabi_DoubleClick);
            // 
            // lstTshirt
            // 
            this.lstTshirt.FormattingEnabled = true;
            this.lstTshirt.ItemHeight = 20;
            this.lstTshirt.Location = new System.Drawing.Point(444, 37);
            this.lstTshirt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstTshirt.Name = "lstTshirt";
            this.lstTshirt.Size = new System.Drawing.Size(370, 444);
            this.lstTshirt.TabIndex = 0;
            this.lstTshirt.DoubleClick += new System.EventHandler(this.lstTshirt_DoubleClick);
            // 
            // lstPantolon
            // 
            this.lstPantolon.FormattingEnabled = true;
            this.lstPantolon.ItemHeight = 20;
            this.lstPantolon.Location = new System.Drawing.Point(444, 492);
            this.lstPantolon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPantolon.Name = "lstPantolon";
            this.lstPantolon.Size = new System.Drawing.Size(370, 444);
            this.lstPantolon.TabIndex = 0;
            this.lstPantolon.DoubleClick += new System.EventHandler(this.lstPantolon_DoubleClick);
            // 
            // lstMont
            // 
            this.lstMont.FormattingEnabled = true;
            this.lstMont.ItemHeight = 20;
            this.lstMont.Location = new System.Drawing.Point(36, 492);
            this.lstMont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMont.Name = "lstMont";
            this.lstMont.Size = new System.Drawing.Size(370, 444);
            this.lstMont.TabIndex = 0;
            this.lstMont.DoubleClick += new System.EventHandler(this.lstMont_DoubleClick);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 20;
            this.lstSepet.Location = new System.Drawing.Point(840, 37);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(757, 804);
            this.lstSepet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(840, 854);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(1068, 854);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 32);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "0 TL";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 971);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1562, 288);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 264;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            this.columnHeader2.Width = 287;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 259;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KDV dahil Fiyat";
            this.columnHeader4.Width = 271;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1294, 854);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Alışverişi Tamamla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1288, 1264);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genel Toplam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1516, 1264);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 1326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMont);
            this.Controls.Add(this.lstPantolon);
            this.Controls.Add(this.lstTshirt);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstAyakkabi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAyakkabi;
        private System.Windows.Forms.ListBox lstTshirt;
        private System.Windows.Forms.ListBox lstPantolon;
        private System.Windows.Forms.ListBox lstMont;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

