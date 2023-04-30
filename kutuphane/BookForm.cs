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
    public partial class BookForm : Form
    {
        internal Book? Book { get; set; }
        public BookForm()
        {
            InitializeComponent();
            bt_tm.DialogResult = DialogResult.OK;
            bt_ıp.DialogResult = DialogResult.Cancel;
            this.AcceptButton = bt_tm;
            this.CancelButton = bt_ıp;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_tm_Click(object sender, EventArgs e)
        {
            if (Book == null)
                return;

            Book.code = int.Parse(tb_code.Text);
            Book.nameOfBook = tb_bookN.Text;
            Book.numberOfPages = int.Parse(tb_page.Text);
            Book.ReleaseDate =tb_bTrh.Text;
            Book.ReleasePlace= tb_releaseP.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                var mesaj = "";
                if (Book?.code == null)
                    mesaj += "Code cannot be empty\n";
                if (Book?.nameOfBook == "")
                    mesaj += "Book name cannot be empty\n";
               if (!string.IsNullOrEmpty(mesaj))
                {
                    e.Cancel = true;
                    MessageBox.Show(mesaj);
                }
            }
        }

        private void tb_kname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_yname_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            if (Book != null)
            {
                tb_code.Text = Book.code.ToString();
                tb_bookN.Text = Book.nameOfBook;
                tb_page.Text = Book.numberOfPages.ToString();
                tb_bTrh.Text = Book.ReleaseDate;
                tb_releaseP.Text = Book.ReleasePlace;

                tb_code.Enabled = string.IsNullOrEmpty(Book.code.ToString());
            }

        }

        private void tb_releaseP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
