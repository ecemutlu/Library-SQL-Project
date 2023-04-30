namespace kutuphane
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp_members = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bt_ekle = new System.Windows.Forms.Button();
            this.dg_uyeler = new System.Windows.Forms.DataGridView();
            this.tp_books = new System.Windows.Forms.TabPage();
            this.dg_kitaplar = new System.Windows.Forms.DataGridView();
            this.tp_genres = new System.Windows.Forms.TabPage();
            this.dg_turler = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dg_authors = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg_publishers = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tp_members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_uyeler)).BeginInit();
            this.tp_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_kitaplar)).BeginInit();
            this.tp_genres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_turler)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_authors)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_publishers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 1048);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(133, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 52);
            this.label6.TabIndex = 11;
            this.label6.Text = "PUBLISHERS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(133, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 52);
            this.label5.TabIndex = 9;
            this.label5.Text = "AUTHORS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(133, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 52);
            this.label4.TabIndex = 8;
            this.label4.Text = "GENRES";
            this.label4.Click += new System.EventHandler(this.lb_tur);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 212);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 112);
            this.label1.TabIndex = 5;
            this.label1.Text = "İzmir Kent \r\n  Library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOOKS";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(133, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "MEMBERS";
            this.label2.Click += new System.EventHandler(this.lb_uye);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Location = new System.Drawing.Point(395, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1413, 1048);
            this.panel2.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tp_members);
            this.tabControl.Controls.Add(this.tp_books);
            this.tabControl.Controls.Add(this.tp_genres);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(8, -3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1402, 1051);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tp_members
            // 
            this.tp_members.Controls.Add(this.button1);
            this.tp_members.Controls.Add(this.button6);
            this.tp_members.Controls.Add(this.bt_ekle);
            this.tp_members.Controls.Add(this.dg_uyeler);
            this.tp_members.Location = new System.Drawing.Point(12, 69);
            this.tp_members.Name = "tp_members";
            this.tp_members.Padding = new System.Windows.Forms.Padding(3);
            this.tp_members.Size = new System.Drawing.Size(1378, 970);
            this.tp_members.TabIndex = 0;
            this.tp_members.Text = "Members";
            this.tp_members.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::kutuphane.Properties.Resources.kart;
            this.button1.Location = new System.Drawing.Point(1125, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 71);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Image = global::kutuphane.Properties.Resources.edit;
            this.button6.Location = new System.Drawing.Point(1241, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 66);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bt_uye_duzenle);
            // 
            // bt_ekle
            // 
            this.bt_ekle.BackColor = System.Drawing.Color.Silver;
            this.bt_ekle.FlatAppearance.BorderSize = 0;
            this.bt_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ekle.Image = global::kutuphane.Properties.Resources.artı1;
            this.bt_ekle.Location = new System.Drawing.Point(1314, 10);
            this.bt_ekle.Name = "bt_ekle";
            this.bt_ekle.Size = new System.Drawing.Size(64, 62);
            this.bt_ekle.TabIndex = 7;
            this.bt_ekle.UseVisualStyleBackColor = false;
            this.bt_ekle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dg_uyeler
            // 
            this.dg_uyeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_uyeler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_uyeler.Location = new System.Drawing.Point(0, 110);
            this.dg_uyeler.Name = "dg_uyeler";
            this.dg_uyeler.RowHeadersWidth = 123;
            this.dg_uyeler.RowTemplate.Height = 57;
            this.dg_uyeler.Size = new System.Drawing.Size(1372, 857);
            this.dg_uyeler.TabIndex = 0;
            // 
            // tp_books
            // 
            this.tp_books.Controls.Add(this.dg_kitaplar);
            this.tp_books.Location = new System.Drawing.Point(12, 69);
            this.tp_books.Name = "tp_books";
            this.tp_books.Padding = new System.Windows.Forms.Padding(3);
            this.tp_books.Size = new System.Drawing.Size(1378, 970);
            this.tp_books.TabIndex = 1;
            this.tp_books.Text = "Books";
            this.tp_books.UseVisualStyleBackColor = true;
            // 
            // dg_kitaplar
            // 
            this.dg_kitaplar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_kitaplar.Location = new System.Drawing.Point(6, 118);
            this.dg_kitaplar.Name = "dg_kitaplar";
            this.dg_kitaplar.RowHeadersWidth = 123;
            this.dg_kitaplar.RowTemplate.Height = 57;
            this.dg_kitaplar.Size = new System.Drawing.Size(1387, 846);
            this.dg_kitaplar.TabIndex = 13;
            // 
            // tp_genres
            // 
            this.tp_genres.Controls.Add(this.dg_turler);
            this.tp_genres.Location = new System.Drawing.Point(12, 69);
            this.tp_genres.Name = "tp_genres";
            this.tp_genres.Size = new System.Drawing.Size(1378, 970);
            this.tp_genres.TabIndex = 2;
            this.tp_genres.Text = "Genres";
            this.tp_genres.UseVisualStyleBackColor = true;
            // 
            // dg_turler
            // 
            this.dg_turler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_turler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_turler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_turler.Location = new System.Drawing.Point(3, 72);
            this.dg_turler.Name = "dg_turler";
            this.dg_turler.RowHeadersWidth = 123;
            this.dg_turler.RowTemplate.Height = 57;
            this.dg_turler.Size = new System.Drawing.Size(1372, 893);
            this.dg_turler.TabIndex = 0;
            this.dg_turler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dg_authors);
            this.tabPage1.Location = new System.Drawing.Point(12, 69);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1378, 970);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Authors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dg_authors
            // 
            this.dg_authors.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_authors.Location = new System.Drawing.Point(0, 126);
            this.dg_authors.Name = "dg_authors";
            this.dg_authors.RowHeadersWidth = 123;
            this.dg_authors.RowTemplate.Height = 57;
            this.dg_authors.Size = new System.Drawing.Size(1375, 838);
            this.dg_authors.TabIndex = 0;
            this.dg_authors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_authors_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg_publishers);
            this.tabPage2.Location = new System.Drawing.Point(12, 69);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1378, 970);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Publishers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg_publishers
            // 
            this.dg_publishers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_publishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_publishers.Location = new System.Drawing.Point(0, 114);
            this.dg_publishers.Name = "dg_publishers";
            this.dg_publishers.RowHeadersWidth = 123;
            this.dg_publishers.RowTemplate.Height = 57;
            this.dg_publishers.Size = new System.Drawing.Size(1375, 856);
            this.dg_publishers.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1022, 335);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tp_members.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_uyeler)).EndInit();
            this.tp_books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_kitaplar)).EndInit();
            this.tp_genres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_turler)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_authors)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_publishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel2;
        private CheckedListBox checkedListBox1;
        private TabControl tabControl;
        private TabPage tp_members;
        private TabPage tp_books;
        private DataGridView dg_uyeler;
        private Button bt_ekle;
        private TabPage tp_genres;
        private DataGridView dg_turler;
        private Label label4;
        private Button button6;
        private Button button1;
        private Label label5;
        private Label label6;
        private TabPage tabPage1;
        private DataGridView dg_authors;
        private TabPage tabPage2;
        private DataGridView dg_publishers;
        private DataGridView dg_kitaplar;
    }
}