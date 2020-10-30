namespace LanguageDetect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.FromRow = new System.Windows.Forms.TextBox();
            this.ToRow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.yb_masterlistDataSet3 = new LanguageDetect.yb_masterlistDataSet3();
            this.spGetmasterlist1000BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Getmasterlist1000TableAdapter = new LanguageDetect.yb_masterlistDataSet3TableAdapters.sp_Getmasterlist1000TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTISTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLBUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lABELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSRCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPISWCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPWRITERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPCUSTOMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTILEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langViDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yb_masterlistDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetmasterlist1000BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.aRTISTDataGridViewTextBoxColumn,
            this.aLBUMDataGridViewTextBoxColumn,
            this.lABELDataGridViewTextBoxColumn,
            this.iSRCDataGridViewTextBoxColumn,
            this.cOMPIDDataGridViewTextBoxColumn,
            this.cOMPTITLEDataGridViewTextBoxColumn,
            this.cOMPISWCDataGridViewTextBoxColumn,
            this.cOMPWRITERSDataGridViewTextBoxColumn,
            this.cOMPCUSTOMIDDataGridViewTextBoxColumn,
            this.qUANTILEDataGridViewTextBoxColumn,
            this.indentDataGridViewTextBoxColumn,
            this.langViDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.spGetmasterlist1000BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1260, 507);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "langdect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FromRow
            // 
            this.FromRow.Location = new System.Drawing.Point(98, 5);
            this.FromRow.Name = "FromRow";
            this.FromRow.Size = new System.Drawing.Size(100, 20);
            this.FromRow.TabIndex = 5;
            this.FromRow.Text = "1";
            // 
            // ToRow
            // 
            this.ToRow.Location = new System.Drawing.Point(98, 31);
            this.ToRow.Name = "ToRow";
            this.ToRow.Size = new System.Drawing.Size(100, 20);
            this.ToRow.TabIndex = 6;
            this.ToRow.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FromRow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ToRow";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "ToExcel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(204, 5);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(112, 23);
            this.LoadData.TabIndex = 10;
            this.LoadData.Text = "Load fRow-tRow";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duyệt qua từng record fRow -tRow kiểm tra nếu là tiếng việt sẽ update cột Langvi " +
    "= 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(850, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lấy dữ liệu từ storeProcedure theo điều kiện 3 và cột Langvi =1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(853, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Điều kiện 3 - vi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // yb_masterlistDataSet3
            // 
            this.yb_masterlistDataSet3.DataSetName = "yb_masterlistDataSet3";
            this.yb_masterlistDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetmasterlist1000BindingSource
            // 
            this.spGetmasterlist1000BindingSource.DataMember = "sp_Getmasterlist1000";
            this.spGetmasterlist1000BindingSource.DataSource = this.yb_masterlistDataSet3;
            // 
            // sp_Getmasterlist1000TableAdapter
            // 
            this.sp_Getmasterlist1000TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            // 
            // aRTISTDataGridViewTextBoxColumn
            // 
            this.aRTISTDataGridViewTextBoxColumn.DataPropertyName = "ARTIST";
            this.aRTISTDataGridViewTextBoxColumn.HeaderText = "ARTIST";
            this.aRTISTDataGridViewTextBoxColumn.Name = "aRTISTDataGridViewTextBoxColumn";
            // 
            // aLBUMDataGridViewTextBoxColumn
            // 
            this.aLBUMDataGridViewTextBoxColumn.DataPropertyName = "ALBUM";
            this.aLBUMDataGridViewTextBoxColumn.HeaderText = "ALBUM";
            this.aLBUMDataGridViewTextBoxColumn.Name = "aLBUMDataGridViewTextBoxColumn";
            // 
            // lABELDataGridViewTextBoxColumn
            // 
            this.lABELDataGridViewTextBoxColumn.DataPropertyName = "LABEL";
            this.lABELDataGridViewTextBoxColumn.HeaderText = "LABEL";
            this.lABELDataGridViewTextBoxColumn.Name = "lABELDataGridViewTextBoxColumn";
            // 
            // iSRCDataGridViewTextBoxColumn
            // 
            this.iSRCDataGridViewTextBoxColumn.DataPropertyName = "ISRC";
            this.iSRCDataGridViewTextBoxColumn.HeaderText = "ISRC";
            this.iSRCDataGridViewTextBoxColumn.Name = "iSRCDataGridViewTextBoxColumn";
            // 
            // cOMPIDDataGridViewTextBoxColumn
            // 
            this.cOMPIDDataGridViewTextBoxColumn.DataPropertyName = "COMP_ID";
            this.cOMPIDDataGridViewTextBoxColumn.HeaderText = "COMP_ID";
            this.cOMPIDDataGridViewTextBoxColumn.Name = "cOMPIDDataGridViewTextBoxColumn";
            // 
            // cOMPTITLEDataGridViewTextBoxColumn
            // 
            this.cOMPTITLEDataGridViewTextBoxColumn.DataPropertyName = "COMP_TITLE";
            this.cOMPTITLEDataGridViewTextBoxColumn.HeaderText = "COMP_TITLE";
            this.cOMPTITLEDataGridViewTextBoxColumn.Name = "cOMPTITLEDataGridViewTextBoxColumn";
            // 
            // cOMPISWCDataGridViewTextBoxColumn
            // 
            this.cOMPISWCDataGridViewTextBoxColumn.DataPropertyName = "COMP_ISWC";
            this.cOMPISWCDataGridViewTextBoxColumn.HeaderText = "COMP_ISWC";
            this.cOMPISWCDataGridViewTextBoxColumn.Name = "cOMPISWCDataGridViewTextBoxColumn";
            // 
            // cOMPWRITERSDataGridViewTextBoxColumn
            // 
            this.cOMPWRITERSDataGridViewTextBoxColumn.DataPropertyName = "COMP_WRITERS";
            this.cOMPWRITERSDataGridViewTextBoxColumn.HeaderText = "COMP_WRITERS";
            this.cOMPWRITERSDataGridViewTextBoxColumn.Name = "cOMPWRITERSDataGridViewTextBoxColumn";
            // 
            // cOMPCUSTOMIDDataGridViewTextBoxColumn
            // 
            this.cOMPCUSTOMIDDataGridViewTextBoxColumn.DataPropertyName = "COMP_CUSTOM_ID";
            this.cOMPCUSTOMIDDataGridViewTextBoxColumn.HeaderText = "COMP_CUSTOM_ID";
            this.cOMPCUSTOMIDDataGridViewTextBoxColumn.Name = "cOMPCUSTOMIDDataGridViewTextBoxColumn";
            // 
            // qUANTILEDataGridViewTextBoxColumn
            // 
            this.qUANTILEDataGridViewTextBoxColumn.DataPropertyName = "QUANTILE";
            this.qUANTILEDataGridViewTextBoxColumn.HeaderText = "QUANTILE";
            this.qUANTILEDataGridViewTextBoxColumn.Name = "qUANTILEDataGridViewTextBoxColumn";
            // 
            // indentDataGridViewTextBoxColumn
            // 
            this.indentDataGridViewTextBoxColumn.DataPropertyName = "Indent";
            this.indentDataGridViewTextBoxColumn.HeaderText = "Indent";
            this.indentDataGridViewTextBoxColumn.Name = "indentDataGridViewTextBoxColumn";
            this.indentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // langViDataGridViewCheckBoxColumn
            // 
            this.langViDataGridViewCheckBoxColumn.DataPropertyName = "LangVi";
            this.langViDataGridViewCheckBoxColumn.HeaderText = "LangVi";
            this.langViDataGridViewCheckBoxColumn.Name = "langViDataGridViewCheckBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 593);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToRow);
            this.Controls.Add(this.FromRow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yb_masterlistDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetmasterlist1000BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FromRow;
        private System.Windows.Forms.TextBox ToRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private yb_masterlistDataSet3 yb_masterlistDataSet3;
        private System.Windows.Forms.BindingSource spGetmasterlist1000BindingSource;
        private yb_masterlistDataSet3TableAdapters.sp_Getmasterlist1000TableAdapter sp_Getmasterlist1000TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRTISTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLBUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lABELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSRCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPISWCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPWRITERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPCUSTOMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTILEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn langViDataGridViewCheckBoxColumn;
    }
}

