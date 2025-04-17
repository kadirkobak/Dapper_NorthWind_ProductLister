﻿using Dapper;
using Dapper_NorthWind_ProductLister.Dtos.CategoryDtos;
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

namespace Dapper_NorthWind_ProductLister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection connection = new SqlConnection("Server=1LP021\\SQLEXPRESS;initial catalog=DbDapperNorthWind;" +
            "integrated security=true;TrustServerCertificate=true");


        private async void btnCategoryList_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Categories";


            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            dataGridView1.DataSource = values.ToList();
        }
    }
}
