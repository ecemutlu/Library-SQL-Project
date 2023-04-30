namespace kutuphane
{
    partial class MemberForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_tm = new System.Windows.Forms.Button();
            this.bt_ıp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(182, 80);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(250, 55);
            this.tb_code.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(182, 196);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(255, 55);
            this.tb_name.TabIndex = 3;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(634, 192);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(283, 55);
            this.tb_surname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(634, 359);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(283, 55);
            this.tb_mail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(182, 355);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(255, 55);
            this.tb_tel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 96);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone \r\nNumber";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(182, 495);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(740, 55);
            this.tb_address.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 48);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // bt_tm
            // 
            this.bt_tm.Location = new System.Drawing.Point(534, 606);
            this.bt_tm.Name = "bt_tm";
            this.bt_tm.Size = new System.Drawing.Size(192, 69);
            this.bt_tm.TabIndex = 12;
            this.bt_tm.Text = "TAMAM";
            this.bt_tm.UseVisualStyleBackColor = true;
            this.bt_tm.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ıp
            // 
            this.bt_ıp.Location = new System.Drawing.Point(732, 606);
            this.bt_ıp.Name = "bt_ıp";
            this.bt_ıp.Size = new System.Drawing.Size(207, 69);
            this.bt_ıp.TabIndex = 13;
            this.bt_ıp.Text = "IPTAL";
            this.bt_ıp.UseVisualStyleBackColor = true;
            this.bt_ıp.Click += new System.EventHandler(this.bt_ıp_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 757);
            this.Controls.Add(this.bt_ıp);
            this.Controls.Add(this.bt_tm);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MemberForm";
            this.Text = "UyeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UyeForm_FormClosing);
            this.Load += new System.EventHandler(this.UyeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_code;
        private TextBox tb_name;
        private TextBox tb_surname;
        private Label label3;
        private TextBox tb_mail;
        private Label label4;
        private TextBox tb_tel;
        private Label label5;
        private TextBox tb_address;
        private Label label6;
        private Button bt_tm;
        private Button bt_ıp;
    }
}