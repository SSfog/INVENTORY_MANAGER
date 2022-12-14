namespace Inventory_Manager
{
    partial class Таблица_категорий
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnStuff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStuffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(25, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 41);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Меню >>>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица категорий";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStuff,
            this.ColumnStuffID});
            this.dataGridView1.Location = new System.Drawing.Point(25, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(600, 143);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnStuff
            // 
            this.ColumnStuff.HeaderText = "Предмет";
            this.ColumnStuff.MinimumWidth = 12;
            this.ColumnStuff.Name = "ColumnStuff";
            this.ColumnStuff.Width = 250;
            // 
            // ColumnStuffID
            // 
            this.ColumnStuffID.HeaderText = "ID предмета";
            this.ColumnStuffID.MinimumWidth = 12;
            this.ColumnStuffID.Name = "ColumnStuffID";
            this.ColumnStuffID.Width = 250;
            // 
            // Таблица_категорий
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Таблица_категорий";
            this.Text = "Таблица_категорий";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnStuff;
        private DataGridViewTextBoxColumn ColumnStuffID;
    }
}