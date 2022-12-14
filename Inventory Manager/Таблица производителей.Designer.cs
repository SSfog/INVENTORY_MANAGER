namespace Inventory_Manager
{
    partial class Tablitsa_proizvoditeli
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnProducer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица производителей";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProducer_name,
            this.ColumnProducer_ID});
            this.dataGridView1.Location = new System.Drawing.Point(39, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(356, 135);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnProducer_name
            // 
            this.ColumnProducer_name.HeaderText = "Имя производителя";
            this.ColumnProducer_name.MinimumWidth = 12;
            this.ColumnProducer_name.Name = "ColumnProducer_name";
            this.ColumnProducer_name.ReadOnly = true;
            this.ColumnProducer_name.Width = 250;
            // 
            // ColumnProducer_ID
            // 
            this.ColumnProducer_ID.HeaderText = "ID производителя";
            this.ColumnProducer_ID.MinimumWidth = 12;
            this.ColumnProducer_ID.Name = "ColumnProducer_ID";
            this.ColumnProducer_ID.ReadOnly = true;
            this.ColumnProducer_ID.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "<<< назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Tablitsa_proizvoditeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(946, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tablitsa_proizvoditeli";
            this.Text = "Таблица_производителей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnProducer_name;
        private DataGridViewTextBoxColumn ColumnProducer_ID;
        private Button button1;
        private NotifyIcon notifyIcon1;
        private Button button2;
    }
}