using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Con = new Function();
            ShowSection();
        }
        Function Con;
        
        private void ShowSection()
        {
            string Query = "Select * from SectionTbl";
            SectionList.DataSource = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(SNameTb.Text == "" || CostTb.Text == "" || CapacityTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = SNameTb.Text;
                    string Cap = CapacityTb.Text;
                    string Cost = CostTb.Text;
                    string Desc = DescTb.Text;
                    string Query = "insert into SectionTbl values('{0}',{1},{2},'{3}')";
                    Query = string.Format(Query, Name, Cap, Cost, Desc);
                    Con.SetData(Query);
                    MessageBox.Show("Section Added!!");
                    ShowSection();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void SectionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = SectionList.CurrentRow.Index;
            SNameTb.Text = SectionList.Rows[baris].Cells[1].Value.ToString();
            CapacityTb.Text = SectionList.Rows[baris].Cells[2].Value.ToString();
            CostTb.Text = SectionList.Rows[baris].Cells[3].Value.ToString();
            DescTb.Text = SectionList.Rows[baris].Cells[4].Value.ToString();
            if (SNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SectionList.Rows[baris].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Section!!");
            }
            else
            {
                try
                {
                    string Name = SNameTb.Text;
                    string Cap = CapacityTb.Text;
                    string Cost = CostTb.Text;
                    string Desc = DescTb.Text;
                    string Query = "delete from SectionTbl where SCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Section Deleted!!");
                    ShowSection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || CostTb.Text == "" || CapacityTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = SNameTb.Text;
                    string Cap = CapacityTb.Text;
                    string Cost = CostTb.Text;
                    string Desc = DescTb.Text;
                    string Query = "Update SectionTbl set SName = '{0}',Capacity = {1},Cost = {2},SDescription = '{3}' where SCode = {4}";
                    Query = string.Format(Query, Name, Cap, Cost, Desc,Key);
                    Con.SetData(Query);
                    MessageBox.Show("Section Updated!!");
                    ShowSection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SNameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CapacityTb_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
