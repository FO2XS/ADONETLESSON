using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class InsertForm : Form
    {
        private bool isInsert;
        private DataRow row;
        public InsertForm(DataRow row, bool isInsert)
        {
            InitializeComponent();

            this.row = row;
            this.isInsert = isInsert;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            row["ID_Bet"] = Convert.ToInt32(textIDBet.Text);
            row["ID_Event"] = Convert.ToInt32(textIDEvent.Text);
            row["VictoryCondition"] = checkVictoryCOndition.Checked;
            row["Coef1"] = Convert.ToInt32(textCoef1.Text);
            row["Coef2"]= Convert.ToInt32(textCoef2.Text);
            row["MinSum"]= Convert.ToInt32(textMinBet.Text);
            row["MaxSum"] = Convert.ToInt32(textMaxbet.Text);
            row["ID_Worker"]= Convert.ToInt32(textID_Worker.Text);


            Close();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            if (!isInsert)
            {
                textIDBet.Text = row["ID_Bet"].ToString();
                textIDBet.ReadOnly = true;
                textIDEvent.Text = row["ID_Event"].ToString();
                textCoef1.Text = row["Coef1"].ToString();
                textCoef2.Text = row["Coef2"].ToString();
                textMinBet.Text = row["MinSum"].ToString();
                textMaxbet.Text = row["MaxSum"].ToString();
                textID_Worker.Text = row["ID_Worker"].ToString();
                checkVictoryCOndition.Checked = (bool)row["VictoryCondition"];
            }
        }

    }
}
