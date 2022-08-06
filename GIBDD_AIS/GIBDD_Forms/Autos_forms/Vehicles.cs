﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GIBDD_AIS.GIBDD_Forms.Autos_forms;

namespace GIBDD_AIS
{
    public partial class Vehicles : Form
    {
      
        DataBase dataBase = new DataBase();
       
        public Vehicles()
        {
            InitializeComponent();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_GIBDDDataSet1.VEHICLES". При необходимости она может быть перемещена или удалена.
            this.vEHICLESTableAdapter1.Fill(this.bD_GIBDDDataSet1.VEHICLES);

            dataBase.openConnection();
            string querystring = "SELECT Number, Brand FROM VEHICLES";

         
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring,dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];
        }

        private void SearchNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
          (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Number LIKE '%{SearchNumber_TextBox.Text}%'";
        }

        private void SearchBrand_TextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Brand LIKE '%{SearchBrand_TextBox.Text}%'";
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
          

            Int32 selectedRowCount =
             dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                
                string chosenNumber = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                string query = $"SELECT ID FROM VEHICLES WHERE Number LIKE '{chosenNumber}'";
                SqlDataReader dataReader = null;
                SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    DataBank.chosenID = dataReader[0].ToString();
                }
                dataReader.Close();
                //Show form
                Vehicle_view newForm = new Vehicle_view();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string chosenNumber = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                string query = $"SELECT ID FROM VEHICLES WHERE Number LIKE '{chosenNumber}'";
                SqlDataReader dataReader = null;
                SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    DataBank.chosenID = dataReader[0].ToString();
                }
                dataReader.Close();
                Vehicle_edit newForm = new Vehicle_edit();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Input_button_Click(object sender, EventArgs e)
        {
            this.Close();

            Vehicle_input newForm = new Vehicle_input();
            newForm.Show();

        }
    }
}