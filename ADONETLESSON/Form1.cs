using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ADONETLESSON.DataSet;

namespace ADONETLESSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.PossibleBets". При необходимости она может быть перемещена или удалена.
            this.possibleBetsTableAdapter.Fill(this.dataSet.PossibleBets);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.possibleBetsTableAdapter.Update(this.dataSet.PossibleBets);
            }
            catch 
            {
                MessageBox.Show("Не удалось сохранить изменения");
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            PossibleBetsRow row = dataSet.PossibleBets.NewPossibleBetsRow();
            InsertForm insertForm = new InsertForm(row, true);

            if(insertForm.ShowDialog() == DialogResult.OK)
            {
                dataSet.PossibleBets.AddPossibleBetsRow(row);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (PossibleBets.CurrentRow != null)
            {
                int id = (int)PossibleBets.CurrentRow.Cells[0].Value;

                var row = dataSet.PossibleBets.FindByID_Bet(id);

                InsertForm insertForm = new InsertForm(row, false);
                if (insertForm.ShowDialog() == DialogResult.OK)
                    PossibleBets.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (PossibleBets.CurrentRow != null)
            {
                int id = (int)PossibleBets.CurrentRow.Cells[0].Value;

                var row = dataSet.PossibleBets.FindByID_Bet(id);

                row.Delete();
            }
        }
    }
}
