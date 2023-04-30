using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphane.Models;

namespace kutuphane
{
    public partial class MemberForm : Form
    {
        internal Member? Member { get; set; }
        public MemberForm()
        {
            InitializeComponent();
            bt_tm.DialogResult = DialogResult.OK;
            bt_ıp.DialogResult = DialogResult.Cancel;
            this.AcceptButton = bt_tm;
            this.CancelButton = bt_ıp;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Member == null)
                return;
            Member.code= int.Parse(tb_code.Text);
            Member.name = tb_name.Text;
            Member.surname = tb_surname.Text;
            Member.phoneNumber = tb_tel.Text;
            Member.email = tb_mail.Text;
            Member.address = tb_address.Text;
        }

        private void UyeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                var mesaj = "";
                if (string.IsNullOrEmpty(Member?.code.ToString()))
                    mesaj += "Code cannot be empty\n";
                if (Member?.name == "")
                    mesaj += "Name cannot be empty\n";
                if (Member?.surname == "")
                    mesaj += "Surname cannot be empty\n";
                if (Member?.phoneNumber == "")
                    mesaj += "Phone number cannot be empty";
                if (!string.IsNullOrEmpty(mesaj))
                {
                    e.Cancel = true;
                    MessageBox.Show(mesaj);
                }
            }
        }

        private void bt_ıp_Click(object sender, EventArgs e)
        {

        }

        private void UyeForm_Load(object sender, EventArgs e)
        {
            if (Member != null)
            {
                tb_code.Text =Member.code.ToString();
                tb_name.Text = Member.name;
                tb_surname.Text = Member.surname;
                tb_tel.Text = Member.phoneNumber;
                tb_mail.Text = Member.email;
                tb_address.Text = Member.address;

                tb_code.Enabled =string.IsNullOrEmpty(Member.code.ToString());
            }
        }
    }
}
