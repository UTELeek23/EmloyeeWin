using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmloyeeWin
{
    public partial class Form1 : Form
    {
        string connection = "Server=leek.database.windows.net,1433;Database=Vm;User Id=leek.sql;Password=Lak@230204;";
        SqlConnection sqlcon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vmDataSet.Emloyee' table. You can move, or remove it, as needed.
            this.emloyeeTableAdapter.Fill(this.vmDataSet.Emloyee);
            try
            {
               using(SqlConnection sqlcon = new SqlConnection(connection))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Emloyee", sqlcon);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Save_buttuon_click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(ID_Text.Text);
                string Name = Name_Text.Text;
                String Dept = Dept_Text.Text;
                using (SqlConnection sqlcon = new SqlConnection(connection))
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Emloyee (ID,Name,Role) VALUES (@ID,@Name,@Role)", sqlcon);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Role", Dept);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");
                    Form1_Load(sender, e);
                    sqlcon.Close();
                }
     

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Edit_button_click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(ID_Text.Text);
                string Name = Name_Text.Text;
                String New_Dept = Dept_Text.Text;
                using(SqlConnection sqlcon = new SqlConnection(connection))
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Emloyee SET Name=@Name,Role=@Role WHERE ID=@ID", sqlcon);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Role", New_Dept);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Delete_button_click(object sender, EventArgs e)
        {
            try
            {
                int ID_del = int.Parse(ID_Text.Text);
                using (SqlConnection sqlcon = new SqlConnection(connection))
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Emloyee WHERE ID=@ID", sqlcon);
                    cmd.Parameters.AddWithValue("@ID", ID_del);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully");
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Find_button_click(object sender, EventArgs e)
        {
            try
            {
                string Find = Find_text.Text;
                int Find_ID;

                if (int.TryParse(Find, out Find_ID))
                {
                    using (SqlConnection sqlcon = new SqlConnection(connection))
                    {
                        sqlcon.Open();
                        SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Emloyee WHERE ID=@ID", sqlcon);
                        sqlCommand.Parameters.AddWithValue("@ID", Find_ID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Gán DataTable làm nguồn dữ liệu cho DataGridView
                        dataGridView1.DataSource = dataTable;
                        // ...
                    }
                }
                else
                {
                    using (SqlConnection sqlcon = new SqlConnection(connection))
                    {
                        sqlcon.Open();
                        SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Emloyee WHERE Name=@Name OR Role=@Role", sqlcon);

                        // Thêm các tham số khác nếu cần thiết
                        sqlCommand.Parameters.AddWithValue("@Name", Find);
                        sqlCommand.Parameters.AddWithValue("@Role", Find);

                        // Thực hiện truy vấn và xử lý kết quả
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Gán DataTable làm nguồn dữ liệu cho DataGridView
                        dataGridView1.DataSource = dataTable;
                        // ...
                    }
                }
                if(Find == "")
                {
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
