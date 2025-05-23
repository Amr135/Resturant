﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class FrmTabelsView : SampleView
    {
        public FrmTabelsView()
        {
            InitializeComponent();
            GetDataTables();
        }
        public void GetDataTables()
        {
            string query = "select * From Tables where tableName like '%" + txtSearch.Text + "%'";
         
            DataBase.LoadData1(query, DataGridView1);
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetDataTables();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            Utility.BlurBackGround(new FrmTabelsadd());
            GetDataTables();
         //   while (DataGridView1.Rows.Count > 0) DataGridView1.Rows.RemoveAt(0);
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //another way
            if (DataGridView1.Columns[e.ColumnIndex].Name.ToString() == "Update")
            {
                string id = DataGridView1.Rows[e.RowIndex].Cells["SR"].Value.ToString();
                FrmTabelsadd f = new FrmTabelsadd(true,id);
                Utility.BlurBackGround(f);
             
                
                DataGridView1.Rows[e.RowIndex].Cells["Tname"].Value = f.tablename;
            }
            else
          if (DataGridView1.Columns[e.ColumnIndex].Name.ToString() == "Delete")
            {
                string id = DataGridView1.Rows[e.RowIndex].Cells["SR"].Value.ToString();
                string query = "delete from Tables where tableid=" + id;
                DataBase.UpdateData(query);
                DataGridView1.Rows[e.RowIndex].Visible = false;
                GetDataTables();
            }

            

        }
    }
}
