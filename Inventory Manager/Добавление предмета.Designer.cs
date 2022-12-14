namespace Inventory_Manager
{
    partial class Добавление_предмета
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnArticulNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStuffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPriceNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducerNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescriptionNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfficeNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnArticulNew,
            this.ColumnCategory,
            this.ColumnStuffName,
            this.ColumnPriceNew,
            this.ColumnProducerNew,
            this.ColumnDescriptionNew,
            this.ColumnOfficeNew,
            this.ColumnRoomNew});
            this.dataGridView1.Location = new System.Drawing.Point(11, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 112);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnArticulNew
            // 
            this.ColumnArticulNew.HeaderText = "Артикул";
            this.ColumnArticulNew.MinimumWidth = 12;
            this.ColumnArticulNew.Name = "ColumnArticulNew";
            this.ColumnArticulNew.Width = 250;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Категория";
            this.ColumnCategory.MinimumWidth = 12;
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.Width = 250;
            // 
            // ColumnStuffName
            // 
            this.ColumnStuffName.HeaderText = "Название предмета";
            this.ColumnStuffName.MinimumWidth = 12;
            this.ColumnStuffName.Name = "ColumnStuffName";
            this.ColumnStuffName.Width = 250;
            // 
            // ColumnPriceNew
            // 
            this.ColumnPriceNew.HeaderText = "Цена (руб., коп.)";
            this.ColumnPriceNew.MinimumWidth = 12;
            this.ColumnPriceNew.Name = "ColumnPriceNew";
            this.ColumnPriceNew.Width = 250;
            // 
            // ColumnProducerNew
            // 
            this.ColumnProducerNew.HeaderText = "Производитель";
            this.ColumnProducerNew.MinimumWidth = 12;
            this.ColumnProducerNew.Name = "ColumnProducerNew";
            this.ColumnProducerNew.Width = 250;
            // 
            // ColumnDescriptionNew
            // 
            this.ColumnDescriptionNew.HeaderText = "Краткое описание";
            this.ColumnDescriptionNew.MinimumWidth = 12;
            this.ColumnDescriptionNew.Name = "ColumnDescriptionNew";
            this.ColumnDescriptionNew.Width = 250;
            // 
            // ColumnOfficeNew
            // 
            this.ColumnOfficeNew.HeaderText = "Офис";
            this.ColumnOfficeNew.MinimumWidth = 12;
            this.ColumnOfficeNew.Name = "ColumnOfficeNew";
            this.ColumnOfficeNew.Width = 250;
            // 
            // ColumnRoomNew
            // 
            this.ColumnRoomNew.HeaderText = "Помещение";
            this.ColumnRoomNew.MinimumWidth = 12;
            this.ColumnRoomNew.Name = "ColumnRoomNew";
            this.ColumnRoomNew.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить предмет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавление нового предмета";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(143, 13);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Предметы >>>";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(38, 13);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(103, 25);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Меню >>>";
            // 
            // Добавление_предмета
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 795);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Добавление_предмета";
            this.Text = "Добавление_предмета";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnArticulNew;
        private DataGridViewTextBoxColumn ColumnCategory;
        private DataGridViewTextBoxColumn ColumnStuffName;
        private DataGridViewTextBoxColumn ColumnPriceNew;
        private DataGridViewTextBoxColumn ColumnProducerNew;
        private DataGridViewTextBoxColumn ColumnDescriptionNew;
        private DataGridViewTextBoxColumn ColumnOfficeNew;
        private DataGridViewTextBoxColumn ColumnRoomNew;
        private Button button1;
        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}