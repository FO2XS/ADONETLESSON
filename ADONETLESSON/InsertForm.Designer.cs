namespace ADONETLESSON
{
    partial class InsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addingFundsTableAdapter1 = new ADONETLESSON.DataSetTableAdapters.AddingFundsTableAdapter();
            this.text_IDEvent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_coef1 = new System.Windows.Forms.TextBox();
            this.text_coef2 = new System.Windows.Forms.TextBox();
            this.text_minbet = new System.Windows.Forms.TextBox();
            this.text_maxbet = new System.Windows.Forms.TextBox();
            this.text_idWorker = new System.Windows.Forms.TextBox();
            this.checkYesNo = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID События";
            // 
            // addingFundsTableAdapter1
            // 
            this.addingFundsTableAdapter1.ClearBeforeFill = true;
            // 
            // text_IDEvent
            // 
            this.text_IDEvent.Location = new System.Drawing.Point(128, 38);
            this.text_IDEvent.Name = "text_IDEvent";
            this.text_IDEvent.Size = new System.Drawing.Size(100, 20);
            this.text_IDEvent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ДА ИЛИ НЕТ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Коэффициент ДА";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Коэффициент НЕТ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Мин ставка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Макс ставка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID работника";
            // 
            // text_coef1
            // 
            this.text_coef1.Location = new System.Drawing.Point(174, 101);
            this.text_coef1.Name = "text_coef1";
            this.text_coef1.Size = new System.Drawing.Size(100, 20);
            this.text_coef1.TabIndex = 8;
            // 
            // text_coef2
            // 
            this.text_coef2.Location = new System.Drawing.Point(174, 142);
            this.text_coef2.Name = "text_coef2";
            this.text_coef2.Size = new System.Drawing.Size(100, 20);
            this.text_coef2.TabIndex = 9;
            // 
            // text_minbet
            // 
            this.text_minbet.Location = new System.Drawing.Point(149, 179);
            this.text_minbet.Name = "text_minbet";
            this.text_minbet.Size = new System.Drawing.Size(100, 20);
            this.text_minbet.TabIndex = 10;
            // 
            // text_maxbet
            // 
            this.text_maxbet.Location = new System.Drawing.Point(149, 211);
            this.text_maxbet.Name = "text_maxbet";
            this.text_maxbet.Size = new System.Drawing.Size(100, 20);
            this.text_maxbet.TabIndex = 11;
            // 
            // text_idWorker
            // 
            this.text_idWorker.Location = new System.Drawing.Point(149, 242);
            this.text_idWorker.Name = "text_idWorker";
            this.text_idWorker.Size = new System.Drawing.Size(100, 20);
            this.text_idWorker.TabIndex = 12;
            // 
            // checkYesNo
            // 
            this.checkYesNo.AutoSize = true;
            this.checkYesNo.Location = new System.Drawing.Point(149, 71);
            this.checkYesNo.Name = "checkYesNo";
            this.checkYesNo.Size = new System.Drawing.Size(15, 14);
            this.checkYesNo.TabIndex = 13;
            this.checkYesNo.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(54, 315);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(208, 315);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkYesNo);
            this.Controls.Add(this.text_idWorker);
            this.Controls.Add(this.text_maxbet);
            this.Controls.Add(this.text_minbet);
            this.Controls.Add(this.text_coef2);
            this.Controls.Add(this.text_coef1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_IDEvent);
            this.Controls.Add(this.label1);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataSetTableAdapters.AddingFundsTableAdapter addingFundsTableAdapter1;
        private System.Windows.Forms.TextBox text_IDEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_coef1;
        private System.Windows.Forms.TextBox text_coef2;
        private System.Windows.Forms.TextBox text_minbet;
        private System.Windows.Forms.TextBox text_maxbet;
        private System.Windows.Forms.TextBox text_idWorker;
        private System.Windows.Forms.CheckBox checkYesNo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}