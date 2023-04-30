namespace kutuphane
{
    partial class GenreForm
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
            this.tb_turkodu = new System.Windows.Forms.TextBox();
            this.tb_tanım = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_tm = new System.Windows.Forms.Button();
            this.bt_ıp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // tb_turkodu
            // 
            this.tb_turkodu.Location = new System.Drawing.Point(211, 85);
            this.tb_turkodu.Name = "tb_turkodu";
            this.tb_turkodu.Size = new System.Drawing.Size(300, 55);
            this.tb_turkodu.TabIndex = 1;
            // 
            // tb_tanım
            // 
            this.tb_tanım.Location = new System.Drawing.Point(211, 237);
            this.tb_tanım.Name = "tb_tanım";
            this.tb_tanım.Size = new System.Drawing.Size(319, 55);
            this.tb_tanım.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_tm
            // 
            this.bt_tm.Location = new System.Drawing.Point(518, 536);
            this.bt_tm.Name = "bt_tm";
            this.bt_tm.Size = new System.Drawing.Size(162, 83);
            this.bt_tm.TabIndex = 4;
            this.bt_tm.Text = "OK";
            this.bt_tm.UseVisualStyleBackColor = true;
            this.bt_tm.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ıp
            // 
            this.bt_ıp.Location = new System.Drawing.Point(711, 536);
            this.bt_ıp.Name = "bt_ıp";
            this.bt_ıp.Size = new System.Drawing.Size(162, 83);
            this.bt_ıp.TabIndex = 5;
            this.bt_ıp.Text = "CANCEL";
            this.bt_ıp.UseVisualStyleBackColor = true;
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 745);
            this.Controls.Add(this.bt_ıp);
            this.Controls.Add(this.bt_tm);
            this.Controls.Add(this.tb_tanım);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_turkodu);
            this.Controls.Add(this.label1);
            this.Name = "GenreForm";
            this.Text = "TurForm";
            this.Load += new System.EventHandler(this.TurForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_turkodu;
        private TextBox tb_tanım;
        private Label label2;
        private Button bt_tm;
        private Button bt_ıp;
    }
}