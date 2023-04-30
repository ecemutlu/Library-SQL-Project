using kutuphane.Models;


namespace kutuphane
{
    public partial class GenreForm : Form
    {
        internal Genre? Genre { get; set; }

        public GenreForm()
        {
            InitializeComponent();
            bt_tm.DialogResult = DialogResult.OK;
            bt_ıp.DialogResult = DialogResult.Cancel;
            this.AcceptButton = bt_tm;
            this.CancelButton = bt_ıp;

        }

        private void TurForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                var mesaj = "";
                if (string.IsNullOrEmpty(Genre?.code.ToString()))
                    mesaj += "Code cannot be empty\n";
                if (Genre?.name == "")
                    mesaj += "Name cannot be empty\n";
                if (!string.IsNullOrEmpty(mesaj))
                {
                    e.Cancel = true;
                    MessageBox.Show(mesaj);
                }
            }
        }
        
       
        private void InitializeComponent()
         {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.bt_tm = new System.Windows.Forms.Button();
            this.bt_ıp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(235, 128);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(412, 55);
            this.tb_code.TabIndex = 2;
            this.tb_code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(235, 226);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(412, 55);
            this.tb_name.TabIndex = 4;
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(235, 344);
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(412, 55);
            this.tb_des.TabIndex = 5;
            // 
            // bt_tm
            // 
            this.bt_tm.Location = new System.Drawing.Point(372, 467);
            this.bt_tm.Name = "bt_tm";
            this.bt_tm.Size = new System.Drawing.Size(187, 78);
            this.bt_tm.TabIndex = 6;
            this.bt_tm.Text = "OK";
            this.bt_tm.UseVisualStyleBackColor = true;
            // 
            // bt_ıp
            // 
            this.bt_ıp.Location = new System.Drawing.Point(565, 467);
            this.bt_ıp.Name = "bt_ıp";
            this.bt_ıp.Size = new System.Drawing.Size(175, 78);
            this.bt_ıp.TabIndex = 7;
            this.bt_ıp.Text = "CANCEL";
            this.bt_ıp.UseVisualStyleBackColor = true;
            // 
            // GenreForm
            // 
            this.ClientSize = new System.Drawing.Size(752, 572);
            this.Controls.Add(this.bt_ıp);
            this.Controls.Add(this.bt_tm);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenreForm";
            this.Text = "GenreForm";
            this.Load += new System.EventHandler(this.GenreForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

         }

        private Label label1;
        private Label label2;
        private TextBox tb_code;
        private Label label3;

        private void GenreForm_Load(object sender, EventArgs e)
        {
            if (Genre != null)
            {
                tb_code.Text = Genre.code.ToString();
                tb_name.Text = Genre.name;

                tb_code.Enabled = string.IsNullOrEmpty(Genre.code.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private TextBox tb_name;
        private TextBox tb_des;
        private Button bt_tm;
        private Button bt_ıp;

        private void GenreForm_Load_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
