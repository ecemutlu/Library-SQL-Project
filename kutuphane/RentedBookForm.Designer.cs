namespace kutuphane
{
    partial class RentedBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
      //  private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
     /*   protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Book = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_rentDate = new System.Windows.Forms.TextBox();
            this.tb_returnDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rent date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Return Date:";
            // 
            // cb_Book
            // 
            this.cb_Book.FormattingEnabled = true;
            this.cb_Book.Location = new System.Drawing.Point(228, 88);
            this.cb_Book.Name = "cb_Book";
            this.cb_Book.Size = new System.Drawing.Size(455, 56);
            this.cb_Book.TabIndex = 7;
            this.cb_Book.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_tm);
            // 
            // tb_rentDate
            // 
            this.tb_rentDate.Location = new System.Drawing.Point(228, 266);
            this.tb_rentDate.Name = "tb_rentDate";
            this.tb_rentDate.Size = new System.Drawing.Size(300, 55);
            this.tb_rentDate.TabIndex = 9;
            // 
            // tb_returnDate
            // 
            this.tb_returnDate.Location = new System.Drawing.Point(228, 371);
            this.tb_returnDate.Name = "tb_returnDate";
            this.tb_returnDate.Size = new System.Drawing.Size(300, 55);
            this.tb_returnDate.TabIndex = 10;
            // 
            // RentedBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 546);
            this.Controls.Add(this.tb_returnDate);
            this.Controls.Add(this.tb_rentDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Book);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentedBookForm";
            this.Text = "RentedBookForm";
            this.Load += new System.EventHandler(this.RentedBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb_Book;
        private Button button1;
        private TextBox tb_rentDate;
        private TextBox tb_returnDate;
    }
}