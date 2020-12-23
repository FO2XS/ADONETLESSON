namespace Lesson2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textIDEvent = new System.Windows.Forms.TextBox();
            this.textCoef1 = new System.Windows.Forms.TextBox();
            this.textCoef2 = new System.Windows.Forms.TextBox();
            this.textMinBet = new System.Windows.Forms.TextBox();
            this.textMaxbet = new System.Windows.Forms.TextBox();
            this.textID_Worker = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkVictoryCOndition = new System.Windows.Forms.CheckBox();
            this.textIDBet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Макс ставка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID_Работника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "КоэфНет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "МинСтавка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Коэф-ДА";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ДА-Нет";
            // 
            // textIDEvent
            // 
            this.textIDEvent.Location = new System.Drawing.Point(167, 76);
            this.textIDEvent.Name = "textIDEvent";
            this.textIDEvent.Size = new System.Drawing.Size(100, 20);
            this.textIDEvent.TabIndex = 8;
            // 
            // textCoef1
            // 
            this.textCoef1.Location = new System.Drawing.Point(167, 149);
            this.textCoef1.Name = "textCoef1";
            this.textCoef1.Size = new System.Drawing.Size(100, 20);
            this.textCoef1.TabIndex = 10;
            // 
            // textCoef2
            // 
            this.textCoef2.Location = new System.Drawing.Point(167, 181);
            this.textCoef2.Name = "textCoef2";
            this.textCoef2.Size = new System.Drawing.Size(100, 20);
            this.textCoef2.TabIndex = 11;
            // 
            // textMinBet
            // 
            this.textMinBet.Location = new System.Drawing.Point(167, 212);
            this.textMinBet.Name = "textMinBet";
            this.textMinBet.Size = new System.Drawing.Size(100, 20);
            this.textMinBet.TabIndex = 12;
            // 
            // textMaxbet
            // 
            this.textMaxbet.Location = new System.Drawing.Point(173, 249);
            this.textMaxbet.Name = "textMaxbet";
            this.textMaxbet.Size = new System.Drawing.Size(100, 20);
            this.textMaxbet.TabIndex = 13;
            // 
            // textID_Worker
            // 
            this.textID_Worker.Location = new System.Drawing.Point(179, 278);
            this.textID_Worker.Name = "textID_Worker";
            this.textID_Worker.Size = new System.Drawing.Size(100, 20);
            this.textID_Worker.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(216, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(92, 392);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkVictoryCOndition
            // 
            this.checkVictoryCOndition.AutoSize = true;
            this.checkVictoryCOndition.Location = new System.Drawing.Point(167, 117);
            this.checkVictoryCOndition.Name = "checkVictoryCOndition";
            this.checkVictoryCOndition.Size = new System.Drawing.Size(15, 14);
            this.checkVictoryCOndition.TabIndex = 18;
            this.checkVictoryCOndition.UseVisualStyleBackColor = true;
            // 
            // textIDBet
            // 
            this.textIDBet.Location = new System.Drawing.Point(167, 40);
            this.textIDBet.Name = "textIDBet";
            this.textIDBet.Size = new System.Drawing.Size(100, 20);
            this.textIDBet.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID_Bet";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textIDBet);
            this.Controls.Add(this.checkVictoryCOndition);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textID_Worker);
            this.Controls.Add(this.textMaxbet);
            this.Controls.Add(this.textMinBet);
            this.Controls.Add(this.textCoef2);
            this.Controls.Add(this.textCoef1);
            this.Controls.Add(this.textIDEvent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIDEvent;
        private System.Windows.Forms.TextBox textCoef1;
        private System.Windows.Forms.TextBox textCoef2;
        private System.Windows.Forms.TextBox textMinBet;
        private System.Windows.Forms.TextBox textMaxbet;
        private System.Windows.Forms.TextBox textID_Worker;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkVictoryCOndition;
        private System.Windows.Forms.TextBox textIDBet;
        private System.Windows.Forms.Label label8;
    }
}