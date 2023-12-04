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

namespace MarketYönetimSistemi
{
    public partial class UserPanel : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"data source=AZRA;initial catalog=MarketManageSystemDB;Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = null;

        public UserPanel()
        {
            InitializeComponent();
        }

       private void UserPanel_Load(object sender, EventArgs e)
        {
            //DataGridDiv'e verileri çek
            updateProductList();

        }

        //Product Listesini Güncelle
        private void updateProductList()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select Id,Image,Name,Description,Price,Stock,IsStatus from Products ", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            marketDgv.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void TankDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
