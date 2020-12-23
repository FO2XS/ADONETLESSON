namespace Lesson2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataPossibleBets = new System.Windows.Forms.DataGridView();
            this.ID_Bet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VictoryCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coef1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coef2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonRollBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPossibleBets)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPossibleBets
            // 
            this.dataPossibleBets.AllowUserToAddRows = false;
            this.dataPossibleBets.AllowUserToDeleteRows = false;
            this.dataPossibleBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPossibleBets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Bet,
            this.ID_Event,
            this.VictoryCondition,
            this.Coef1,
            this.Coef2,
            this.MinSum,
            this.MaxSum,
            this.ID_Worker,
            this.Description});
            this.dataPossibleBets.Location = new System.Drawing.Point(7, 106);
            this.dataPossibleBets.Name = "dataPossibleBets";
            this.dataPossibleBets.Size = new System.Drawing.Size(946, 150);
            this.dataPossibleBets.TabIndex = 0;
            // 
            // ID_Bet
            // 
            this.ID_Bet.HeaderText = "ID Ставки";
            this.ID_Bet.Name = "ID_Bet";
            // 
            // ID_Event
            // 
            this.ID_Event.HeaderText = "ID События";
            this.ID_Event.Name = "ID_Event";
            // 
            // VictoryCondition
            // 
            this.VictoryCondition.HeaderText = "Да-Нет";
            this.VictoryCondition.Name = "VictoryCondition";
            // 
            // Coef1
            // 
            this.Coef1.HeaderText = "КоэфДА";
            this.Coef1.Name = "Coef1";
            // 
            // Coef2
            // 
            this.Coef2.HeaderText = "КоэфНет";
            this.Coef2.Name = "Coef2";
            // 
            // MinSum
            // 
            this.MinSum.HeaderText = "МинСтавка";
            this.MinSum.Name = "MinSum";
            // 
            // MaxSum
            // 
            this.MaxSum.HeaderText = "МаксСтавка";
            this.MaxSum.Name = "MaxSum";
            // 
            // ID_Worker
            // 
            this.ID_Worker.HeaderText = "ID Работника";
            this.ID_Worker.Name = "ID_Worker";
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(23, 315);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Показать";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 357);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(124, 315);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Вставить";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(215, 315);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(302, 357);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(738, 282);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonBegin.TabIndex = 6;
            this.buttonBegin.Text = "Begin";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(738, 328);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(75, 23);
            this.buttonCommit.TabIndex = 7;
            this.buttonCommit.Text = "Commit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // buttonRollBack
            // 
            this.buttonRollBack.Location = new System.Drawing.Point(738, 373);
            this.buttonRollBack.Name = "buttonRollBack";
            this.buttonRollBack.Size = new System.Drawing.Size(75, 23);
            this.buttonRollBack.TabIndex = 8;
            this.buttonRollBack.Text = "Rollback";
            this.buttonRollBack.UseVisualStyleBackColor = true;
            this.buttonRollBack.Click += new System.EventHandler(this.buttonRollBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.buttonRollBack);
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.dataPossibleBets);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataPossibleBets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPossibleBets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Bet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn VictoryCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coef1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coef2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Button buttonRollBack;
    }
}

