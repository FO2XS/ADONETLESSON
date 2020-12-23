using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        private SqlConnection connect;
        SqlDataAdapter adapter;
        DataTable possibleBets = new DataTable();
        SqlTransaction transaction = null;

        public Form1()
        {
            InitializeComponent();

            
            connect = new SqlConnection(@"Data Source=LAPTOP-04R40VDE;Initial Catalog = FOXXS;Integrated Security=True;Connect Timeout=30");
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {

            try
            {
                
                SqlCommand command = new SqlCommand(@"select ID_Bet, ID_Event, VictoryCondition, Coef1, Coef2, MinSum, MaxSum, ID_Worker, Description from PossibleBets", connect);
               /* connect.Open();
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    int rowNumber = 0;
                    while (sqlDataReader.Read())
                    {
                        
                        /*dataPossibleBets.RowCount++;
                        dataPossibleBets.Rows[rowNumber].Cells[0] = 
                        rowNumber++;
                    }
                }*/
                adapter = new SqlDataAdapter(command);
                adapter.Fill(possibleBets);
                possibleBets.PrimaryKey = new DataColumn[] { possibleBets.Columns["ID_Bet"] };

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand(true);
                adapter.DeleteCommand = builder.GetDeleteCommand(true);
                adapter.UpdateCommand = builder.GetUpdateCommand(true);

                FillTable();
            }
            catch
            {
                MessageBox.Show("Тоби капут");

            }
            finally
            {
                connect.Close();
            }
        }

        private void FillTable()
        {
            dataPossibleBets.RowCount = 0;
            dataPossibleBets.Rows.Clear();
            int rowNum = 0;

            foreach (DataRow row in possibleBets.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                    continue;

                dataPossibleBets.RowCount++;
                dataPossibleBets.Rows[rowNum].Cells[0].Value = row["ID_Bet"].ToString();
                dataPossibleBets.Rows[rowNum].Cells[1].Value = row["ID_Event"].ToString();
                dataPossibleBets.Rows[rowNum].Cells[2].Value = row["VictoryCondition"].ToString();
                dataPossibleBets.Rows[rowNum].Cells[3].Value = row["Coef1"].ToString();
                dataPossibleBets.Rows[rowNum].Cells[4].Value = row["Coef2"].ToString();
                dataPossibleBets.Rows[rowNum].Cells[5].Value = row["MinSum"].ToString();
                dataPossibleBets.Rows[rowNum].Cells[6].Value = row["MaxSum"].ToString();
                dataPossibleBets.Rows[rowNum].Cells[7].Value = row["ID_Worker"].ToString();
                dataPossibleBets.Rows[rowNum].Cells[8].Value = row["Description"].ToString();


                rowNum++;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(dataPossibleBets.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataPossibleBets.CurrentRow.Cells[0].Value);
                DataRow row = possibleBets.Rows.Find(id);

                InsertForm update = new InsertForm(row, false);
                if (update.ShowDialog() == DialogResult.OK)
                {
                    FillTable();
                }
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            DataRow newRow = possibleBets.NewRow();

            InsertForm insert = new InsertForm(newRow, true);
            if (insert.ShowDialog() == DialogResult.OK)
            {
                possibleBets.Rows.Add(newRow);
                FillTable();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(possibleBets);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
            FillTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataPossibleBets.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataPossibleBets.CurrentRow.Cells[0].Value);
                DataRow row = possibleBets.Rows.Find(id);

                row.Delete();
                FillTable();

            }
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            if (transaction == null)
            {
                connect.Open();
                transaction = connect.BeginTransaction(IsolationLevel.ReadUncommitted);
                SqlCommand command = new SqlCommand("INSERT INTO PossibleBets VALUES(1, 1, 2, 3, 4, 5, 6, 'none')", connect, transaction);
                command.ExecuteNonQuery();
            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                transaction.Commit();
                connect.Close();
                transaction = null;
            }
        }

        private void buttonRollBack_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                transaction.Rollback();
                connect.Close();
                transaction = null;
            }
        }
    }
}
