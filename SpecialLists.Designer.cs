
namespace CourseProject_TRPK
{
    partial class SpecialLists
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
            this.dataGridViewEnough = new System.Windows.Forms.DataGridView();
            this.dataGridViewNotEnough = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonToMain = new System.Windows.Forms.Button();
            this.buttonToDeps = new System.Windows.Forms.Button();
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
            this.dataGridViewEnough.Location = new System.Drawing.Point(12, 127);
            this.dataGridViewEnough.Name = "dataGridViewEnough";
            this.dataGridViewEnough.ReadOnly = true;
            this.dataGridViewEnough.RowHeadersWidth = 51;
            this.dataGridViewEnough.RowTemplate.Height = 24;
            this.dataGridViewEnough.Size = new System.Drawing.Size(534, 498);
            this.dataGridViewEnough.TabIndex = 2;
            // 
            // dataGridViewNotEnough
            // 
            this.dataGridViewNotEnough.AllowUserToAddRows = false;
            this.dataGridViewNotEnough.AllowUserToDeleteRows = false;
            this.dataGridViewNotEnough.AllowUserToOrderColumns = true;
            this.dataGridViewNotEnough.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotEnough.Location = new System.Drawing.Point(564, 127);
            this.dataGridViewNotEnough.Name = "dataGridViewNotEnough";
            this.dataGridViewNotEnough.ReadOnly = true;
            this.dataGridViewNotEnough.RowHeadersWidth = 51;
            this.dataGridViewNotEnough.RowTemplate.Height = 24;
            this.dataGridViewNotEnough.Size = new System.Drawing.Size(534, 498);
            this.dataGridViewNotEnough.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(667, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Отсутствующие лекарства";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Лекарства в наличии";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirm.Location = new System.Drawing.Point(367, 636);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(379, 66);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Подтвердить выдачу";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonToMain
            // 
            this.buttonToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToMain.Location = new System.Drawing.Point(863, 12);
            this.buttonToMain.Name = "buttonToMain";
            this.buttonToMain.Size = new System.Drawing.Size(227, 63);
            this.buttonToMain.TabIndex = 9;
            this.buttonToMain.Text = "Вернуться на главную";
            this.buttonToMain.UseVisualStyleBackColor = true;
            this.buttonToMain.Click += new System.EventHandler(this.buttonToMain_Click);
            // 
            // buttonToDeps
            // 
            this.buttonToDeps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToDeps.Location = new System.Drawing.Point(630, 12);
            this.buttonToDeps.Name = "buttonToDeps";
            this.buttonToDeps.Size = new System.Drawing.Size(227, 63);
            this.buttonToDeps.TabIndex = 10;
            this.buttonToDeps.Text = "Вернуться к выбору отделения";
            this.buttonToDeps.UseVisualStyleBackColor = true;
            this.buttonToDeps.Click += new System.EventHandler(this.buttonToDeps_Click);
            // 
            // SpecialLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 712);
            this.Controls.Add(this.buttonToDeps);
            this.Controls.Add(this.buttonToMain);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNotEnough);
            this.Controls.Add(this.dataGridViewEnough);
            this.Name = "SpecialLists";
            this.Text = "SpecialLists";
            this.Load += new System.EventHandler(this.SpecialLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnough)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotEnough)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnough;
        private System.Windows.Forms.DataGridView dataGridViewNotEnough;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonToMain;
        private System.Windows.Forms.Button buttonToDeps;
    }
}