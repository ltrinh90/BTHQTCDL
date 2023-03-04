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

namespace Lab123Form
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-1FK03R5\SQLEXPRESS;Initial Catalog=qltv;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
           if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_ThemCuonSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlCon;
                // khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@isbn", SqlDbType.Int).Value = txtISBN.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo");
                txtISBN.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnToForm2_Click(object sender, EventArgs e)
        {
            Form2 o = new Form2();
            o.ShowDialog();
        }

      
    }
}
