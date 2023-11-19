
namespace CourseProject_TRPK
{
    partial class GeneralLists
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
            this.dataGridViewNotEnough = new System.Windows.Forms.DataGridView();
            this.buttonDepList = new System.Windows.Forms.Button();
            this.dataGridViewEnough = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotEnough)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnough)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotEnough
            // 
            this.dataGridViewNotEnough.AllowUserToAddRows = false;
            this.dataGridViewNotEnough.AllowUserToDeleteRows = false;
            this.dataGridViewNotEnough.AllowUserToOrderColumns = true;
            this.dataGridViewNotEnough.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotEnough.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewNotEnough.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotEnough.Location = new System.Drawing.Point(12, 129);
            this.dataGridViewNotEnough.Name = "dataGridViewNotEnough";
            this.dataGridViewNotEnough.ReadOnly = true;
            this.dataGridViewNotEnough.RowHeadersWidth = 51;
            this.dataGridViewNotEnough.RowTemplate.Height = 24;
            this.dataGridViewNotEnough.Size = new System.Drawing.Size(487, 421);
            this.dataGridViewNotEnough.TabIndex = 1;
            // 
            // buttonDepList
            // 
            this.buttonDepList.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDepList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDepList.Location = new System.Drawing.Point(374, 572);
            this.buttonDepList.Name = "buttonDepList";
            this.buttonDepList.Size = new System.Drawing.Size(244, 66);
            this.buttonDepList.TabIndex = 2;
            this.buttonDepList.Text = "Список для отделения";
            this.buttonDepList.UseVisualStyleBackColor = false;
            this.buttonDepList.Click += new System.EventHandler(this.buttonDepList_Click);
            // 
            // dataGridViewEnough
            // 
            this.dataGridViewEnough.AllowUserToAddRows = false;
            this.dataGridViewEnough.AllowUserToDeleteRows = false;
            this.dataGridViewEnough.AllowUserToOrderColumns = true;
            this.dataGridViewEnough.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEnough.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewEnough.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnough.Location = new System.Drawing.Point(505, 129);
            this.dataGridViewEnough.Name = "dataGridViewEnough";
            this.dataGridViewEnough.ReadOnly = true;
            this.dataGridViewEnough.RowHeadersWidth = 51;
            this.dataGridViewEnough.RowTemplate.Height = 24;
            this.dataGridViewEnough.Size = new System.Drawing.Size(487, 421);
            this.dataGridViewEnough.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(633, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лекарства в наличии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(94, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Отсутствующие лекарства";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(302, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "grozka00@mail.ru";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.Location = new System.Drawing.Point(155, 21);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(131, 50);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonView.Location = new System.Drawing.Point(12, 21);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(131, 50);
            this.buttonView.TabIndex = 9;
            this.buttonView.Text = "Открыть";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(880, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(113, 50);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // GeneralLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEnough);
            this.Controls.Add(this.buttonDepList);
            this.Controls.Add(this.dataGridViewNotEnough);
            this.Name = "GeneralLists";
            this.Text = "Общие списки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotEnough)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnough)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotEnough;
        private System.Windows.Forms.Button buttonDepList;
        private System.Windows.Forms.DataGridView dataGridViewEnough;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonExit;
    }
}

