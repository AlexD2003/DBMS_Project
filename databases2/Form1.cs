using System;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
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
using databases2.hardwarestoreDataSetTableAdapters;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;

namespace databases2
{
    
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FTT6DNB\\SQLEXPRESS;Initial Catalog=hardwarestore;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        //SqlDataAdapter daTasks;

        DataSet ds = new DataSet();
        SqlCommandBuilder cb;
        SqlDataAdapter da=new SqlDataAdapter();
        
        
        static string case1 = ConfigurationManager.AppSettings["case"];
        static string parentName = ConfigurationManager.AppSettings["ParentTableName"+case1];
        static string childName = ConfigurationManager.AppSettings["ChildTableName" + case1];
        static int childNumberOfCollumns = int.Parse(ConfigurationManager.AppSettings["ChildNumberOfCollumns" + case1]);
        static string insertQuery = ConfigurationManager.AppSettings["ChildInsertQuery" + case1];
        static string childArr = ConfigurationManager.AppSettings["ChildArray" +case1];
        static string ChildToParentId = ConfigurationManager.AppSettings["ChildToParentID" + case1];
        static string childCollumnNames = ConfigurationManager.AppSettings["ChildCollumnNames" + case1];
        static string childCollumnTypes = ConfigurationManager.AppSettings["ChildCollumnTypes" + case1];
        static string childDeleteQuery = ConfigurationManager.AppSettings["ChildDeleteQuery"+case1];
        static string childUpdateQuery = ConfigurationManager.AppSettings["ChildUpdateQuery" + case1];
        //defs
        BindingSource bsChild = new BindingSource();
        BindingSource bsParent = new BindingSource();
        DataSet dsChild = new DataSet();
        DataSet dsParent = new DataSet();

        System.Windows.Forms.TextBox[] textBoxes = new System.Windows.Forms.TextBox[childNumberOfCollumns];
        Label[] labels = new Label[childNumberOfCollumns];
        public Form1()
        {
            
            //Console.WriteLine(a);
            InitializeComponent();
            string[] names = childCollumnNames.Split(new char[] { ',' });
            Console.WriteLine(childNumberOfCollumns);
            for (int i = 0; i < childNumberOfCollumns; i++)
            {
                labels[i] = new Label();
                textBoxes[i] = new System.Windows.Forms.TextBox();


                labels[i].Text = names[i];
                labels[i].Location = new Point(1, 1 + i * 50);

                textBoxes[i].Text = "";
                textBoxes[i].Location = new Point(1, 25 + i * 50); 


            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < childNumberOfCollumns; i++)
            {
                this.Controls.Add(labels[i]);
                this.Controls.Add(textBoxes[i]);
            }
            PopulateParentDataGridView();
            PopulateChildGridView();
        }
        private void PopulateParentDataGridView()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM " + parentName;
                SqlCommand getAll = new SqlCommand(query, conn);
                /*SqlDataAdapter da = new SqlDataAdapter(getAll);
                da.Fill(dsParent, ConfigurationManager.AppSettings["ParentTableName"]);
                dataGridView1.DataSource = dsParent.Tables[ConfigurationManager.AppSettings["ParentTableName"]];
                dataGridView1.Refresh();*/
                da.SelectCommand = new SqlCommand(query, conn);
                dsParent.Clear();
                da.Fill(dsParent);
                dataGridView1.DataSource = dsParent.Tables[0];
                bsParent.DataSource = dsParent.Tables[0];
                bsParent.MoveLast();
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateChildGridView()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM " + childName;
                /*SqlCommand getAll = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(getAll);
                da.Fill(dsChild, ConfigurationManager.AppSettings["ChildTableName"]);
                dataGridView3.DataSource = dsChild.Tables[ConfigurationManager.AppSettings["ChildTableName"]];
                dataGridView3.Refresh();*/
                da.SelectCommand = new SqlCommand(query, conn);
                dsChild.Clear();
                da.Fill(dsChild);
                dataGridView3.DataSource = dsChild.Tables[0];
                bsChild.DataSource = dsChild.Tables[0];
                bsChild.MoveLast();
                conn.Close ();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                string sqlCommand = "select * from " + childName +" where " + ChildToParentId +"=@"+ ChildToParentId;
                SqlCommand getProductsByOrder = new SqlCommand(sqlCommand, conn);
                getProductsByOrder.Parameters.AddWithValue("@"+ ChildToParentId, id);
                DataSet ds = new DataSet();
                SqlDataAdapter dataAd = new SqlDataAdapter(getProductsByOrder);
                dataAd.Fill(ds, "Tasks");
                dataGridView3.DataSource = ds.Tables["Tasks"];
                dataGridView3.Refresh ();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not proper id selected:" + ex);
            }
        }
       

        private void b1click(object sender, EventArgs e)
        {
            /*int taskId2;
            if (!int.TryParse(taskId.Text, out taskId2))
            {
                MessageBox.Show("Please enter a valid Task ID.", "Error");
                return;
            }
            string taskDesc2 = taskDesc.Text;
            int selectedEmployeeId = (int)dataGridView1.CurrentRow.Cells["eidDataGridViewTextBoxColumn"].Value;
            AddTask(selectedEmployeeId, taskId2, taskDesc2);*/
            AddTask();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddTask()
        {
            conn.Open();
            da.InsertCommand = new SqlCommand(insertQuery,conn);
            da.InsertCommand.Parameters.AddWithValue("@"+ChildToParentId,SqlDbType.Int).Value =  dsParent.Tables[dataGridView1.CurrentCell.ColumnIndex].Rows[dataGridView1.CurrentCell.RowIndex][0];
            string[] args = childArr.Split(new char[] { ',' });
            string[] types = childCollumnTypes.Split(new char[] { ',' });
            try {
                for (int i = 0; i < childNumberOfCollumns; i++) {
                    Console.WriteLine(args[i]);
                    Console.WriteLine(types[i]);
                    switch (types[i]) {
                        case "int":
                            da.InsertCommand.Parameters.AddWithValue(args[i], SqlDbType.Int).Value = int.Parse(textBoxes[i].Text);
                            break;
                        case "string":
                            da.InsertCommand.Parameters.AddWithValue(args[i], SqlDbType.VarChar).Value = textBoxes[i].Text;
                            break;
                        case "date":
                            da.InsertCommand.Parameters.AddWithValue(args[i], SqlDbType.Date).Value = textBoxes[i].Text;
                            break;
                        default:
                            MessageBox.Show("Wrong input!");
                            break;
                    }
                }
            }
            catch (Exception e){
                MessageBox.Show(e.Message);
            }
            da.InsertCommand.ExecuteNonQuery();
            dsChild.Clear();
            conn.Close();
            da.Fill(dsChild);
            PopulateChildGridView();


        }

        private void deleteClick(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells.Count == 0) {
                MessageBox.Show("No selected cells!");
                return;
            }
            if (dataGridView3.SelectedCells.Count > 1)
            {
                MessageBox.Show("Too many selected cells!");
                return;
            }
            da.DeleteCommand = new SqlCommand(childDeleteQuery, conn);
            da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = dsChild.Tables[0].Rows[dataGridView3.CurrentCell.RowIndex][0];
            conn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            conn.Close();
            dsChild.Clear();
            da.Fill(dsChild);
        }


        private void updateClick(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells.Count == 0)
            {
                MessageBox.Show("No selected cells!");
                return;
            }
            if (dataGridView3.SelectedCells.Count > 1)
            {
                MessageBox.Show("Too many selected cells!");
                return;
            }
            int x;
            da.UpdateCommand = new SqlCommand(childUpdateQuery, conn);
            string[] args = childArr.Split(new char[] { ',' });
            string[] types = childCollumnTypes.Split(new char[] { ',' });
            da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = dsChild.Tables[0].Rows[dataGridView3.CurrentCell.RowIndex][0];
            da.UpdateCommand.Parameters.Add("@" + ChildToParentId, SqlDbType.Int).Value = int.Parse(getParentId.Text);
            try
            {
                for (int i = 1; i < childNumberOfCollumns; i++) {
                    Console.WriteLine(dsParent.Tables[0].Rows[dataGridView1.CurrentCell.RowIndex][0]);
                    Console.WriteLine(types[i]);
                    switch (types[i])
                    {
                        case "string":
                            da.UpdateCommand.Parameters.Add(args[i], SqlDbType.VarChar).Value = textBoxes[i].Text;
                            break;
                        case "int":
                            da.UpdateCommand.Parameters.Add(args[i], SqlDbType.Int).Value = int.Parse(textBoxes[i].Text);
                            break;
                        case "date":
                            da.UpdateCommand.Parameters.Add(args[i], SqlDbType.Date).Value = textBoxes[i].Text;
                            break;
                        default:
                            MessageBox.Show("Smthg went wrong");
                            break;
                    }

                }
            }
            catch (Exception ex) {  MessageBox.Show(ex.Message); }
            conn.Open();
            Console.WriteLine(da.UpdateCommand.CommandText);
            x=da.UpdateCommand.ExecuteNonQuery();
            conn.Close();
            dsChild.Clear();
            da.Fill(dsChild);
            if (x >= 1) {
                MessageBox.Show("Succes!");
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }

}