
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToMain = new System.Windows.Forms.Button();
            this.buttonToDeps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnough)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnough
            // 
            this.dataGridViewEnough.AllowUserToAddRows = false;
            this.dataGridViewEnough.AllowUserToDeleteRows = false;
            this.dataGridViewEnough.AllowUserToOrderColumns = true;
            this.dataGridViewEnough.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEnough.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewEnough.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnough.Location = new System.Drawing.Point(12, 127);
            this.dataGridViewEnough.Name = "dataGridViewEnough";
            this.dataGridViewEnough.ReadOnly = true;
            this.dataGridViewEnough.RowHeadersWidth = 51;
            this.dataGridViewEnough.RowTemplate.Height = 24;
            this.dataGridViewEnough.Size = new System.Drawing.Size(555, 485);
            this.dataGridViewEnough.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Требуемые лекарства";
            // 
            // buttonToMain
            // 
            this.buttonToMain.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToMain.Location = new System.Drawing.Point(340, 12);
            this.buttonToMain.Name = "buttonToMain";
            this.buttonToMain.Size = new System.Drawing.Size(227, 63);
            this.buttonToMain.TabIndex = 9;
            this.buttonToMain.Text = "Вернуться на главную";
            this.buttonToMain.UseVisualStyleBackColor = false;
            this.buttonToMain.Click += new System.EventHandler(this.buttonToMain_Click);
            // 
            // buttonToDeps
            // 
            this.buttonToDeps.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonToDeps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToDeps.Location = new System.Drawing.Point(12, 12);
            this.buttonToDeps.Name = "buttonToDeps";
            this.buttonToDeps.Size = new System.Drawing.Size(227, 63);
            this.buttonToDeps.TabIndex = 10;
            this.buttonToDeps.Text = "Вернуться к выбору отделения";
            this.buttonToDeps.UseVisualStyleBackColor = false;
            this.buttonToDeps.Click += new System.EventHandler(this.buttonToDeps_Click);
            // 
            // SpecialLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(588, 624);
            this.Controls.Add(this.buttonToDeps);
            this.Controls.Add(this.buttonToMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEnough);
            this.Name = "SpecialLists";
            this.Text = "Список для отделения";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnough)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnough;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToMain;
        private System.Windows.Forms.Button buttonToDeps;
    }
}