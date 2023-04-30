using System.Data;
using System.Data.SqlClient;
using kutuphane.Helpers;
using kutuphane.Models;

namespace kutuphane
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            using (var dt = MemberHelper.ReadMember())
            {
                dg_uyeler.DataSource = dt;
                dg_uyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void lb_uye(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    using (var dt = MemberHelper.ReadMember())
                    {
                        dg_uyeler.DataSource = dt;
                        dg_uyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    break;
                case 1:
                    using (var dt = BookHelper.ReadBooks())
                    {
                        dg_kitaplar.DataSource = dt;
                        dg_kitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }

                    break;
                case 2:
                    using (var dt = GenreHelper.ReadGenres(Global.ConnectionString))
                    {
                        dg_turler.DataSource = dt;
                        dg_turler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                    break;
                case 3:
                    using (var dt = Author_Publisher_UserHelper.ReadAuthours())
                    {
                        dg_authors.DataSource = dt;
                        dg_authors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                    break;
                case 4:
                    using (var dt = Author_Publisher_UserHelper.ReadPublishers())
                    {
                        dg_publishers.DataSource = dt;
                        dg_publishers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                    break;

                default:
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var uyeForm = new MemberForm();
            uyeForm.Member = new Member();
            var formResult = uyeForm.ShowDialog(this);
            if (formResult == DialogResult.OK)
            {
                if (uyeForm.Member != null)
                {
                    try
                    {
                        MemberHelper.InsertMember(uyeForm.Member);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                dg_uyeler.DataSource = MemberHelper.ReadMember();
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_tur(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;

        }

        private void button8_Click(object sender, EventArgs e)
        {
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void bt_sil_uye(object sender, EventArgs e)
        {
            
        }

        private void bt_sil_Book(object sender, EventArgs e)
        {
           
        }

        private void bt_sil_tur(object sender, EventArgs e)
        {
            
        }

        private void bt_uye_duzenle(object sender, EventArgs e)
        {
            if (dg_uyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please show the member that you want to edit");
                return;
            }
            var uyeform = new MemberForm();
            var selectedUye = MemberHelper.ReadMember((int)dg_uyeler.SelectedRows[0].Cells["code"].Value);
            uyeform.Member = selectedUye;
            var formresult = uyeform.ShowDialog();
            if (formresult == DialogResult.OK)
            {
                try
                {
                    if (selectedUye != null)
                        MemberHelper.UpdateUye(selectedUye);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            dg_uyeler.DataSource = MemberHelper.ReadMember();
        }

        private void bt_Book_duzenle(object sender, EventArgs e)
        {
           
        }

        private void bt_tur_duzenle(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dg_uyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please pick a member");
                return;
            }
            var uyekartiform = new MemberCardForm();
            var selectedUye = MemberHelper.ReadMember((int)dg_uyeler.SelectedRows[0].Cells["code"].Value);
            uyekartiform.Member = selectedUye;
            var formresult = uyekartiform.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void dg_authors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}




