namespace kutuphane
{
    partial class MemberCardForm
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
            this.lb_ad = new System.Windows.Forms.Label();
            this.dg_uyekitaplari = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_uyekitaplari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name-Surname:";
            // 
            // lb_ad
            // 
            this.lb_ad.AutoSize = true;
            this.lb_ad.Location = new System.Drawing.Point(295, 47);
            this.lb_ad.Name = "lb_ad";
            this.lb_ad.Size = new System.Drawing.Size(115, 48);
            this.lb_ad.TabIndex = 1;
            this.lb_ad.Text = "label2";
            // 
            // dg_uyekitaplari
            // 
            this.dg_uyekitaplari.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg_uyekitaplari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_uyekitaplari.GridColor = System.Drawing.SystemColors.Control;
            this.dg_uyekitaplari.Location = new System.Drawing.Point(2, 161);
            this.dg_uyekitaplari.Name = "dg_uyekitaplari";
            this.dg_uyekitaplari.RowHeadersWidth = 123;
            this.dg_uyekitaplari.RowTemplate.Height = 57;
            this.dg_uyekitaplari.Size = new System.Drawing.Size(1147, 634);
            this.dg_uyekitaplari.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 801);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_tm);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(976, 801);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bt_ıp);
            // 
            // MemberCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 868);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_uyekitaplari);
            this.Controls.Add(this.lb_ad);
            this.Controls.Add(this.label1);
            this.Name = "MemberCardForm";
            this.Text = "MemberCard";
            this.Load += new System.EventHandler(this.UyeKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_uyekitaplari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lb_ad;
        private DataGridView dg_uyekitaplari;
        private Button button1;
        private Button button2;
    }
}