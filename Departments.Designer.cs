
namespace CourseProject_TRPK
{
    partial class Departments
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
            this.buttonNeuro = new System.Windows.Forms.Button();
            this.buttonCardio = new System.Windows.Forms.Button();
            this.buttonSurg = new System.Windows.Forms.Button();
            this.buttonOnco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNeuro
            // 
            this.buttonNeuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNeuro.Location = new System.Drawing.Point(59, 12);
            this.buttonNeuro.Name = "buttonNeuro";
            this.buttonNeuro.Size = new System.Drawing.Size(296, 62);
            this.buttonNeuro.TabIndex = 0;
            this.buttonNeuro.Text = "Неврологическое";
            this.buttonNeuro.UseVisualStyleBackColor = true;
            this.buttonNeuro.Click += new System.EventHandler(this.buttonNeuro_Click);
            // 
            // buttonCardio
            // 
            this.buttonCardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCardio.Location = new System.Drawing.Point(59, 92);
            this.buttonCardio.Name = "buttonCardio";
            this.buttonCardio.Size = new System.Drawing.Size(296, 62);
            this.buttonCardio.TabIndex = 1;
            this.buttonCardio.Text = "Кардиологическое";
            this.buttonCardio.UseVisualStyleBackColor = true;
            this.buttonCardio.Click += new System.EventHandler(this.buttonCardio_Click);
            // 
            // buttonSurg
            // 
            this.buttonSurg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSurg.Location = new System.Drawing.Point(59, 170);
            this.buttonSurg.Name = "buttonSurg";
            this.buttonSurg.Size = new System.Drawing.Size(296, 62);
            this.buttonSurg.TabIndex = 2;
            this.buttonSurg.Text = "Хирургическое";
            this.buttonSurg.UseVisualStyleBackColor = true;
            this.buttonSurg.Click += new System.EventHandler(this.buttonSurg_Click);
            // 
            // buttonOnco
            // 
            this.buttonOnco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOnco.Location = new System.Drawing.Point(59, 247);
            this.buttonOnco.Name = "buttonOnco";
            this.buttonOnco.Size = new System.Drawing.Size(296, 62);
            this.buttonOnco.TabIndex = 3;
            this.buttonOnco.Text = "Онкологическое";
            this.buttonOnco.UseVisualStyleBackColor = true;
            this.buttonOnco.Click += new System.EventHandler(this.buttonOnco_Click);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 334);
            this.Controls.Add(this.buttonOnco);
            this.Controls.Add(this.buttonSurg);
            this.Controls.Add(this.buttonCardio);
            this.Controls.Add(this.buttonNeuro);
            this.Name = "Departments";
            this.Text = "Departments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNeuro;
        private System.Windows.Forms.Button buttonCardio;
        private System.Windows.Forms.Button buttonSurg;
        private System.Windows.Forms.Button buttonOnco;
    }
}