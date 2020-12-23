namespace ADONETLESSON
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
            this.components = new System.ComponentModel.Container();
            this.PossibleBets = new System.Windows.Forms.DataGridView();
            this.iDBetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victoryConditionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coef1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coef2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.possibleBetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new ADONETLESSON.DataSet();
            this.possibleBetsTableAdapter = new ADONETLESSON.DataSetTableAdapters.PossibleBetsTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PossibleBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possibleBetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PossibleBets
            // 
            this.PossibleBets.AllowUserToAddRows = false;
            this.PossibleBets.AllowUserToDeleteRows = false;
            this.PossibleBets.AutoGenerateColumns = false;
            this.PossibleBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PossibleBets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBetDataGridViewTextBoxColumn,
            this.iDEventDataGridViewTextBoxColumn,
            this.victoryConditionDataGridViewCheckBoxColumn,
            this.coef1DataGridViewTextBoxColumn,
            this.coef2DataGridViewTextBoxColumn,
            this.minSumDataGridViewTextBoxColumn,
            this.maxSumDataGridViewTextBoxColumn,
            this.iDWorkerDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.PossibleBets.DataSource = this.possibleBetsBindingSource;
            this.PossibleBets.Location = new System.Drawing.Point(37, 36);
            this.PossibleBets.Name = "PossibleBets";
            this.PossibleBets.ReadOnly = true;
            this.PossibleBets.RowHeadersWidth = 20;
            this.PossibleBets.Size = new System.Drawing.Size(946, 332);
            this.PossibleBets.TabIndex = 0;
            // 
            // iDBetDataGridViewTextBoxColumn
            // 
            this.iDBetDataGridViewTextBoxColumn.DataPropertyName = "ID_Bet";
            this.iDBetDataGridViewTextBoxColumn.HeaderText = "ID_Bet";
            this.iDBetDataGridViewTextBoxColumn.Name = "iDBetDataGridViewTextBoxColumn";
            this.iDBetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDEventDataGridViewTextBoxColumn
            // 
            this.iDEventDataGridViewTextBoxColumn.DataPropertyName = "ID_Event";
            this.iDEventDataGridViewTextBoxColumn.HeaderText = "ID_Event";
            this.iDEventDataGridViewTextBoxColumn.Name = "iDEventDataGridViewTextBoxColumn";
            this.iDEventDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // victoryConditionDataGridViewCheckBoxColumn
            // 
            this.victoryConditionDataGridViewCheckBoxColumn.DataPropertyName = "VictoryCondition";
            this.victoryConditionDataGridViewCheckBoxColumn.HeaderText = "VictoryCondition";
            this.victoryConditionDataGridViewCheckBoxColumn.Name = "victoryConditionDataGridViewCheckBoxColumn";
            this.victoryConditionDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // coef1DataGridViewTextBoxColumn
            // 
            this.coef1DataGridViewTextBoxColumn.DataPropertyName = "Coef1";
            this.coef1DataGridViewTextBoxColumn.HeaderText = "Coef1";
            this.coef1DataGridViewTextBoxColumn.Name = "coef1DataGridViewTextBoxColumn";
            this.coef1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coef2DataGridViewTextBoxColumn
            // 
            this.coef2DataGridViewTextBoxColumn.DataPropertyName = "Coef2";
            this.coef2DataGridViewTextBoxColumn.HeaderText = "Coef2";
            this.coef2DataGridViewTextBoxColumn.Name = "coef2DataGridViewTextBoxColumn";
            this.coef2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minSumDataGridViewTextBoxColumn
            // 
            this.minSumDataGridViewTextBoxColumn.DataPropertyName = "MinSum";
            this.minSumDataGridViewTextBoxColumn.HeaderText = "MinSum";
            this.minSumDataGridViewTextBoxColumn.Name = "minSumDataGridViewTextBoxColumn";
            this.minSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxSumDataGridViewTextBoxColumn
            // 
            this.maxSumDataGridViewTextBoxColumn.DataPropertyName = "MaxSum";
            this.maxSumDataGridViewTextBoxColumn.HeaderText = "MaxSum";
            this.maxSumDataGridViewTextBoxColumn.Name = "maxSumDataGridViewTextBoxColumn";
            this.maxSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDWorkerDataGridViewTextBoxColumn
            // 
            this.iDWorkerDataGridViewTextBoxColumn.DataPropertyName = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.HeaderText = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.Name = "iDWorkerDataGridViewTextBoxColumn";
            this.iDWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // possibleBetsBindingSource
            // 
            this.possibleBetsBindingSource.DataMember = "PossibleBets";
            this.possibleBetsBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // possibleBetsTableAdapter
            // 
            this.possibleBetsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(37, 400);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Save";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(134, 400);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(224, 400);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(323, 400);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 572);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.PossibleBets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PossibleBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possibleBetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PossibleBets;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource possibleBetsBindingSource;
        private DataSetTableAdapters.PossibleBetsTableAdapter possibleBetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn victoryConditionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coef1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coef2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}

