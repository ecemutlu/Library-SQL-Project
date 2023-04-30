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
    public partial class MemberCardForm : Form
    {
        internal Member? Member { get; set; }
        internal RentedBook RentedBook { get; set; }
        public MemberCardForm()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            this.AcceptButton = button1;
            this.CancelButton = button2;

        }

        private void UyeKart_Load(object sender, EventArgs e)
        {
            if (Member != null)
            {
                lb_ad.Text = Member.name + " " + Member.surname;
                using (var dt = MemberHelper.ReadMemberBooks(Member.code))
                {
                    dg_uyekitaplari.DataSource = dt;
                    dg_uyekitaplari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_ıp(object sender, EventArgs e)
        {

        }

        private void bt_tm(object sender, EventArgs e)
        {

        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            //var kiralananBookformu = new RentedBookForm();
            //try
            //{
            //    kiralananBookformu.RentedBook = new RentedBook
            //    {
            //        Member_code = Member?.code ?? 0,
            //        RentDate = RentedBook?.RentDate?? "",
            //        User_code = Global.User?.code ?? 0
            //    };
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //var formResult = kiralananBookformu.ShowDialog(this);
            //if (formResult == DialogResult.OK)
            //{
            //    MemberHelper.InsertRentedBook(kiralananBookformu.RentedBook);
            //    dg_uyekitaplari.DataSource = MemberHelper.ReadMemberBooks(Member?.code?? 0);
            //}
        }

        ////private void bt_sil_Click(object sender, EventArgs e)
        //{
        //}

        private void bt_düzenle_Click(object sender, EventArgs e)
        {
        //    var kiralananBookformu = new RentedBookForm();
        //    if (dg_uyekitaplari.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Please pick the member that you want to edit");
        //        return;
        //    }

        //    var selectedUyeKitabi = MemberHelper.ReadMemberBook(
        //                    (int)dg_uyekitaplari.SelectedRows[0].Cells["Member_code"].Value,
        //                    (int)dg_uyekitaplari.SelectedRows[0].Cells["Book_code"].Value,
        //                    dg_uyekitaplari.SelectedRows[0].Cells["RentDate"].ToString(),
        //                    (int)dg_uyekitaplari.SelectedRows[0].Cells["User_code"].Value);
        //    if (selectedUyeKitabi == null)
        //        return;
        //    kiralananBookformu.RentedBook = selectedUyeKitabi;
        //    var formResult = kiralananBookformu.ShowDialog(this);
        //    if (formResult == DialogResult.OK)
        //    {
        //        try
        //        {
        //            if (selectedUyeKitabi != null)
        //            {
        //                MemberHelper.UpdateRentedBook(selectedUyeKitabi);
        //                dg_uyekitaplari.DataSource = MemberHelper.ReadMemberBooks(selectedUyeKitabi.Member_code);
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        }
    }
}

