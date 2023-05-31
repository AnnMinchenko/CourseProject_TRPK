
namespace CourseProject_TRPK
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
            this.dataGridViewEnough = new System.Windows.Forms.DataGridView();
            this.buttonDepList = new System.Windows.Forms.Button();
            this.dataGridViewNotEnough = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnough)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotEnough)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnough
            // 
            this.dataGridViewEnough.AllowUserToAddRows = false;
            this.dataGridViewEnough.AllowUserToDeleteRows = false;
            this.dataGridViewEnough.AllowUserToOrderColumns = true;
            this.dataGridViewEnough.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnough.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewEnough.Name = "dataGridViewEnough";
            this.dataGridViewEnough.ReadOnly = true;
            this.dataGridViewEnough.RowHeadersWidth = 51;
            this.dataGridViewEnough.RowTemplate.Height = 24;
            this.dataGridViewEnough.Size = new System.Drawing.Size(534, 498);
            this.dataGridViewEnough.TabIndex = 1;
            // 
            // buttonDepList
            // 
            this.buttonDepList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDepList.Location = new System.Drawing.Point(364, 563);
            this.buttonDepList.Name = "buttonDepList";
            this.buttonDepList.Size = new System.Drawing.Size(379, 66);
            this.buttonDepList.TabIndex = 2;
            this.buttonDepList.Text = "Списки по отделениям";
            this.buttonDepList.UseVisualStyleBackColor = true;
            this.buttonDepList.Click += new System.EventHandler(this.buttonDepList_Click);
            // 
            // dataGridViewNotEnough
            // 
            this.dataGridViewNotEnough.AllowUserToAddRows = false;
            this.dataGridViewNotEnough.AllowUserToDeleteRows = false;
            this.dataGridViewNotEnough.AllowUserToOrderColumns = true;
            this.dataGridViewNotEnough.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotEnough.Location = new System.Drawing.Point(564, 46);
            this.dataGridViewNotEnough.Name = "dataGridViewNotEnough";
            this.dataGridViewNotEnough.ReadOnly = true;
            this.dataGridViewNotEnough.RowHeadersWidth = 51;
            this.dataGridViewNotEnough.RowTemplate.Height = 24;
            this.dataGridViewNotEnough.Size = new System.Drawing.Size(534, 498);
            this.dataGridViewNotEnough.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лекарства в наличии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(692, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Отсутствующие лекарства";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNotEnough);
            this.Controls.Add(this.buttonDepList);
            this.Controls.Add(this.dataGridViewEnough);
            this.Name = "Form1";
            this.Text = "Общие списки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnough)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotEnough)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnough;
        private System.Windows.Forms.Button buttonDepList;
        private System.Windows.Forms.DataGridView dataGridViewNotEnough;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

