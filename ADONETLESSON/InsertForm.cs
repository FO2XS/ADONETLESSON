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
    public partial class InsertForm : Form
    {
        private bool isInsert;
        private PossibleBetsRow row;
        public InsertForm(PossibleBetsRow row, bool isInsert)
        {
            InitializeComponent();

            this.row = row;
            this.isInsert = isInsert;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            row.ID_Event = Convert.ToInt32(text_IDEvent.Text);
            row.VictoryCondition = checkYesNo.Checked;
            row.Coef1 = Convert.ToInt32(text_coef1.Text);
            row.Coef2 = Convert.ToInt32(text_coef2.Text);
            row.MinSum = Convert.ToInt32(text_minbet.Text);
            row.MaxSum= Convert.ToInt32(text_maxbet.Text);
            row.ID_Worker = Convert.ToInt32(text_idWorker.Text);

            Close();

        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

            if (!isInsert)
            {
                text_IDEvent.Text = row.ID_Event.ToString();
                text_coef1.Text = row.Coef1.ToString();
                text_coef2.Text = row.Coef2.ToString();
                text_minbet.Text = row.MinSum.ToString();
                text_maxbet.Text = row.MaxSum.ToString();
                text_idWorker.Text = row.ID_Worker.ToString();
                checkYesNo.Checked = row.VictoryCondition;
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
