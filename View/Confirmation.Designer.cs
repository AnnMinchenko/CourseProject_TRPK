
namespace CourseProject_TRPK.View
{
    partial class Confirmation
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
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
            this.dataGridViewEnough.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewEnough.Name = "dataGridViewEnough";
            this.dataGridViewEnough.ReadOnly = true;
            this.dataGridViewEnough.RowHeadersWidth = 51;
            this.dataGridViewEnough.RowTemplate.Height = 24;
            this.dataGridViewEnough.Size = new System.Drawing.Size(564, 448);
            this.dataGridViewEnough.TabIndex = 3;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirm.Location = new System.Drawing.Point(147, 546);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(282, 66);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "Подтвердить выдачу";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Требуемые лекарства";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(463, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(113, 50);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(588, 624);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.dataGridViewEnough);
            this.Name = "Confirmation";
            this.Text = "Подтверждение выдачи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnough)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnough;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
    }
}