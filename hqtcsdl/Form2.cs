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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab123Form
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=DESKTOP-1FK03R5\SQLEXPRESS;Initial Catalog=qltv;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form2()
        {
            InitializeComponent();
        }
        private void hienThiTheoISBN()
        {
            int i = 0, STT;
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "sp_tracuu_docgia_dang_muonsach";
            sqlCmd.Parameters.Add("@madg", SqlDbType.Int).Value = txtMaDocGia.Text;
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            listView2.Items.Clear();
            while (reader.Read())
            {
                STT = i + 1;
                i++;
                ListViewItem lvi = new ListViewItem((STT).ToString());
                lvi.SubItems.Add(reader.GetInt32(0) + "");
                lvi.SubItems.Add(reader.GetInt16(1) + "");
                lvi.SubItems.Add(reader.GetDateTime(2) + "");
                lvi.SubItems.Add(reader.GetDateTime(3) + "");
                listView2.Items.Add(lvi);
            }
            reader.Close();
        }

        private void TraCuu_Click(object sender, EventArgs e)
        {
            hienThiTheoISBN();
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_trasach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlCon;
                // khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@isbn", SqlDbType.Int).Value = txt_isbn.Text;
                cmd.Parameters.Add("@ma_cuonsach", SqlDbType.Int).Value = txtMaCS.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tra sach thanh cong", "Thông báo");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thong bao");
            }
            hienThiTheoISBN();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = listView2.SelectedItems[0];
            txt_isbn.Text = (liv.SubItems[1].Text);
            txtMaCS.Text = (liv.SubItems[2].Text);
        }
    }
}
