using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphane.Helpers;
using kutuphane.Models;

namespace kutuphane
{
    public partial class RentedBookForm : Form
    {
        internal RentedBook RentedBook { get; set; }

        public RentedBookForm()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            this.AcceptButton = button1;
           
        }

        private void dateTimePicker2_FontChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }


        private void bt_kaydet(object sender, EventArgs e)
        {
           
             }
        private void UyeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                var mesaj = "";
                if (RentedBook?.Book_code.ToString() == "")
                    mesaj += "Please pick a book\n";
                if (RentedBook?.RentDate.ToString() == "")
                    mesaj += "Please pick a date\n";
                if (!string.IsNullOrEmpty(mesaj))
                {
                    e.Cancel = true;
                    MessageBox.Show(mesaj);
                }
            }
        }

        private void bt_tm(object sender, EventArgs e)
        {
            if (RentedBook == null)
                return;
            RentedBook.Book_code = (int)cb_Book.SelectedValue;
            RentedBook.RentDate = tb_rentDate.Text;
            RentedBook.ReturnDate=tb_returnDate.Text;
        }

        private void RentedBookForm_Load(object sender, EventArgs e)
        {
            cb_Book.DataSource = BookHelper.ReadBooks();
            cb_Book.DisplayMember = "nameOfBook";
            cb_Book.ValueMember = "code";
        }

        private void dt_kiratrh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
