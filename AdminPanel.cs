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

namespace MarketYönetimSistemi
{
    public partial class AdminPanel : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"data source=AZRA;initial catalog=MarketManageSystemDB;Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = null;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //DataGridDiv'e verileri çek
            updateProductList();
            updateUserList();


            //Combo Box'a Categori isimlerini çağır
            sqlConnection.Open();
            SqlCommand comment = new SqlCommand("select Name from Categories", sqlConnection);
            SqlDataReader readComment = comment.ExecuteReader();
            while (readComment.Read())
            {
                TankCategoryCb.Items.Add(readComment[0].ToString());

            }
            sqlConnection.Close();

        }


        // -----------------------  TANK PART ----------------------- 

        //Listeye veri ekle
        private void TankAddBtn_Click(object sender, EventArgs e)
        {
            
            var categoryName = TankCategoryCb.Text;
            var name = TankNameTxt.Text;
            var description = TankDescriptionTxt.Text;
            var price = TankPriceTxt.Text;
            var stock = TankStockTxt.Text;

            if ((categoryName != "") && (name != "") && (description != "") && (price != "") && (stock != ""))
            {
                try
                {

                    SqlCommand productInsert = new SqlCommand("insert products(categoryId,Name,Description,Price,Stock) values(@p1,@p2,@p3,@p4,@p5)", sqlConnection);
                    productInsert.Parameters.AddWithValue("@p1", TankCategoryCb.SelectedIndex + 1);
                    productInsert.Parameters.AddWithValue("@p2", name.ToString());
                    productInsert.Parameters.AddWithValue("@p3", description.ToString());
                    productInsert.Parameters.AddWithValue("@p4", price.ToString());
                    productInsert.Parameters.AddWithValue("@p5", stock.ToString());
                    sqlConnection.Open();

                    productInsert.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Product addition successful");

            }
                catch (Exception)
                {
                sqlConnection.Close();
                MessageBox.Show("You have logged in incorrectly...");
            }

        }
            else
            {
                MessageBox.Show("Empty Space should not be left...");
            }
            updateProductList();
        }

        //Product Listesini Güncelle
        private void updateProductList()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select P.Id,P.Image,P.Name,P.Description,P.Price,P.Stock,P.IsStatus, C.Name as 'Category_Name' from Products P left join Categories C on P.Name = C.Name", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            TankDgv.DataSource = dataTable;
            sqlConnection.Close();
        }

        //Grid List bilgileri textboxa taşı. (CategoryName'i çekemedim)
        private void TankDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // select P.Id,P.Image,P.Name,P.Description,P.Price,P.Stock,P.IsStatus
            TankProductIdTxt.Text = TankDgv.CurrentRow.Cells[0].Value.ToString(); //Id
//            TankCategoryCb.Text = TankCategoryCb.Items[Convert.ToInt32(TankDgv.CurrentRow.Cells[7].Value.ToString())].ToString(); //Category Name
            TankNameTxt.Text = TankDgv.CurrentRow.Cells[2].Value.ToString(); //Product Name
            TankDescriptionTxt.Text = TankDgv.CurrentRow.Cells[3].Value.ToString(); //Description
            TankPriceTxt.Text = TankDgv.CurrentRow.Cells[4].Value.ToString(); //Price
            TankStockTxt.Text = TankDgv.CurrentRow.Cells[5].Value.ToString(); //Stock
        }

        //Product Item Güncelle
        private void TankUpdateBtn_Click(object sender, EventArgs e)
        {
            var categoryName = TankCategoryCb.Text;
            var name = TankNameTxt.Text;
            var description = TankDescriptionTxt.Text;
            var price = TankPriceTxt.Text;
            var stock = TankStockTxt.Text;
            var id = TankProductIdTxt.Text;

            SqlCommand updateProduct = new SqlCommand("Update Products Set Name=@name,Description=@description,Price=@price,Stock=@stock where Id=@id", sqlConnection);
            updateProduct.Parameters.AddWithValue("@name", name);
            updateProduct.Parameters.AddWithValue("@description", description);
            updateProduct.Parameters.AddWithValue("@price", price);
            updateProduct.Parameters.AddWithValue("@stock",stock);
            updateProduct.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            updateProduct.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Registration Updated...");

            updateProductList();
        }

        //Product Item Delete
        private void TankDeleteBtn_Click(object sender, EventArgs e)
        {
            var id = TankProductIdTxt.Text;

            SqlCommand deleteProduct = new SqlCommand("delete from Products where Id=@p1", sqlConnection);
            deleteProduct.Parameters.AddWithValue("@p1", id);
            sqlConnection.Open();
            deleteProduct.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deleted Product");

            updateProductList();
        }




        // -----------------------  CUSTOMER PART ----------------------- 
        
        //Listeye veri ekle
        private void UserAddBtn_Click(object sender, EventArgs e)
        {
            var id = UserIdTxt.Text;
            var name = UserNameTxt.Text;
            var surname = UserSurnameTxt.Text;
            var email = UserEmailTxt.Text;
            var password = UserPasswordTxt.Text;
            var description = UserDescriptionTxt.Text;

            if ((id != "") && (name != "") && (surname != "") && (email != "") && (password != "") && (description != ""))
            {
                try
                {
                    SqlCommand userInsert = new SqlCommand("insert users(Name,Surname,Email,Password,Description) values(@p1,@p2,@p3,@p4,@p5,@p6)", sqlConnection);
                    userInsert.Parameters.AddWithValue("@p1", name.ToString());
                    userInsert.Parameters.AddWithValue("@p2", surname.ToString());
                    userInsert.Parameters.AddWithValue("@p3", email.ToString());
                    userInsert.Parameters.AddWithValue("@p4", password.ToString());
                    userInsert.Parameters.AddWithValue("@p5", description.ToString());

                    sqlConnection.Open();

                    userInsert.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("User addition successful");
                }
                catch (Exception)
                {
                    sqlConnection.Close();
                    MessageBox.Show("You have logged in incorrectly...");
                }
            }
            else
            {
                MessageBox.Show("Empty Space should not be left...");
            }
            updateUserList();
        }

        //Users Listesini Güncelle
        private void updateUserList()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select Id,Name,Surname,Email,Password,Description from Users", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            CustomerDgv.DataSource = dataTable;
            sqlConnection.Close();
        }

        //Grid List bilgileri textboxa taşı
        private void CustomerDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // select Id,Name,Surname,Email,Password,Description
            UserIdTxt.Text = CustomerDgv.CurrentRow.Cells[0].Value.ToString(); //Id
            UserNameTxt.Text = CustomerDgv.CurrentRow.Cells[1].Value.ToString(); // Name
            UserSurnameTxt.Text = CustomerDgv.CurrentRow.Cells[2].Value.ToString(); // Surname
            UserEmailTxt.Text = CustomerDgv.CurrentRow.Cells[3].Value.ToString(); // Email
            UserPasswordTxt.Text = CustomerDgv.CurrentRow.Cells[4].Value.ToString(); // Password
            UserDescriptionTxt.Text = CustomerDgv.CurrentRow.Cells[5].Value.ToString(); // Description
        }

        //User Item Güncelle
        private void UserUpdateBtn_Click(object sender, EventArgs e)
        {
            var id = UserIdTxt.Text;
            var name = UserNameTxt.Text;
            var surname = UserSurnameTxt.Text;
            var email = UserEmailTxt.Text;
            var password = UserPasswordTxt.Text;
            var description = UserDescriptionTxt.Text;

            SqlCommand updateUser = new SqlCommand("Update Users Set Name=@name,Surname=@surname,Email=@email,Password=@password,Description=@description where Id=@id", sqlConnection);
            updateUser.Parameters.AddWithValue("@name", name);
            updateUser.Parameters.AddWithValue("@surname", surname);
            updateUser.Parameters.AddWithValue("@email", email);
            updateUser.Parameters.AddWithValue("@password", password);
            updateUser.Parameters.AddWithValue("@description", description);
            updateUser.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            updateUser.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Registration Updated...");

            updateUserList();
        }

        //User Item Delete
        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            var id = UserIdTxt.Text;

            SqlCommand deleteUser = new SqlCommand("delete from Users where Id=@p1", sqlConnection);
            deleteUser.Parameters.AddWithValue("@p1", id);
            sqlConnection.Open();
            deleteUser.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deleted User");

            updateUserList();
        }




        // -----------------------  DOCUMENT PART ----------------------- 
        //Document Listesini Güncelle
        private void updateDocumentList()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select Id,Name,Surname,Email,Password,Description from Document", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            DocumentGdv.DataSource = dataTable;
            sqlConnection.Close();
        }

       












        //
    }
    }
