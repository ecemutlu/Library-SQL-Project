namespace kutuphane
{
    partial class BookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_page = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_authorN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_bookN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_releaseP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_bTrh = new System.Windows.Forms.TextBox();
            this.bt_tm = new System.Windows.Forms.Button();
            this.bt_ıp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(226, 75);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(342, 55);
            this.tb_code.TabIndex = 1;
            this.tb_code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_page
            // 
            this.tb_page.Location = new System.Drawing.Point(903, 79);
            this.tb_page.Name = "tb_page";
            this.tb_page.Size = new System.Drawing.Size(107, 55);
            this.tb_page.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Pages";
            // 
            // tb_authorN
            // 
            this.tb_authorN.Location = new System.Drawing.Point(226, 211);
            this.tb_authorN.Name = "tb_authorN";
            this.tb_authorN.Size = new System.Drawing.Size(775, 55);
            this.tb_authorN.TabIndex = 5;
            this.tb_authorN.TextChanged += new System.EventHandler(this.tb_yname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_bookN
            // 
            this.tb_bookN.Location = new System.Drawing.Point(226, 327);
            this.tb_bookN.Name = "tb_bookN";
            this.tb_bookN.Size = new System.Drawing.Size(775, 55);
            this.tb_bookN.TabIndex = 7;
            this.tb_bookN.TextChanged += new System.EventHandler(this.tb_kname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 48);
            this.label5.TabIndex = 9;
            this.label5.Text = "Released Place";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_releaseP
            // 
            this.tb_releaseP.Location = new System.Drawing.Point(282, 458);
            this.tb_releaseP.Name = "tb_releaseP";
            this.tb_releaseP.Size = new System.Drawing.Size(300, 55);
            this.tb_releaseP.TabIndex = 8;
            this.tb_releaseP.TextChanged += new System.EventHandler(this.tb_releaseP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 48);
            this.label6.TabIndex = 11;
            this.label6.Text = "Released Date";
            // 
            // tb_bTrh
            // 
            this.tb_bTrh.Location = new System.Drawing.Point(282, 595);
            this.tb_bTrh.Name = "tb_bTrh";
            this.tb_bTrh.Size = new System.Drawing.Size(300, 55);
            this.tb_bTrh.TabIndex = 10;
            // 
            // bt_tm
            // 
            this.bt_tm.Location = new System.Drawing.Point(529, 785);
            this.bt_tm.Name = "bt_tm";
            this.bt_tm.Size = new System.Drawing.Size(225, 69);
            this.bt_tm.TabIndex = 12;
            this.bt_tm.Text = "OK";
            this.bt_tm.UseVisualStyleBackColor = true;
            this.bt_tm.Click += new System.EventHandler(this.bt_tm_Click);
            // 
            // bt_ıp
            // 
            this.bt_ıp.Location = new System.Drawing.Point(776, 785);
            this.bt_ıp.Name = "bt_ıp";
            this.bt_ıp.Size = new System.Drawing.Size(225, 69);
            this.bt_ıp.TabIndex = 13;
            this.bt_ıp.Text = "CANCEL";
            this.bt_ıp.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 963);
            this.Controls.Add(this.bt_ıp);
            this.Controls.Add(this.bt_tm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_bTrh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_releaseP);
            this.Controls.Add(this.tb_bookN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_authorN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_page);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_code;
        private TextBox tb_page;
        private Label label2;
        private TextBox tb_authorN;
        private Label label3;
        private TextBox tb_bookN;
        private Label label4;
        private Label label5;
        private TextBox tb_releaseP;
        private Label label6;
        private TextBox tb_bTrh;
        private Button bt_tm;
        private Button bt_ıp;
    }
}