namespace Lab_3_2_Testiranje
{
    partial class FrmMain
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
            this.btnPravokutnik = new System.Windows.Forms.Button();
            this.btnKvadrat = new System.Windows.Forms.Button();
            this.btnTrokut = new System.Windows.Forms.Button();
            this.btnKrug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPravokutnik
            // 
            this.btnPravokutnik.Location = new System.Drawing.Point(12, 12);
            this.btnPravokutnik.Name = "btnPravokutnik";
            this.btnPravokutnik.Size = new System.Drawing.Size(347, 44);
            this.btnPravokutnik.TabIndex = 0;
            this.btnPravokutnik.Text = "Pravokutnik";
            this.btnPravokutnik.UseVisualStyleBackColor = true;
            this.btnPravokutnik.Click += new System.EventHandler(this.btnPravokutnik_Click);
            // 
            // btnKvadrat
            // 
            this.btnKvadrat.Location = new System.Drawing.Point(12, 62);
            this.btnKvadrat.Name = "btnKvadrat";
            this.btnKvadrat.Size = new System.Drawing.Size(347, 47);
            this.btnKvadrat.TabIndex = 1;
            this.btnKvadrat.Text = "Kvadrat";
            this.btnKvadrat.UseVisualStyleBackColor = true;
            this.btnKvadrat.Click += new System.EventHandler(this.btnKvadrat_Click);
            // 
            // btnTrokut
            // 
            this.btnTrokut.Location = new System.Drawing.Point(12, 115);
            this.btnTrokut.Name = "btnTrokut";
            this.btnTrokut.Size = new System.Drawing.Size(347, 47);
            this.btnTrokut.TabIndex = 2;
            this.btnTrokut.Text = "Trokut";
            this.btnTrokut.UseVisualStyleBackColor = true;
            // 
            // btnKrug
            // 
            this.btnKrug.Location = new System.Drawing.Point(12, 168);
            this.btnKrug.Name = "btnKrug";
            this.btnKrug.Size = new System.Drawing.Size(347, 50);
            this.btnKrug.TabIndex = 3;
            this.btnKrug.Text = "Krug";
            this.btnKrug.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 238);
            this.Controls.Add(this.btnKrug);
            this.Controls.Add(this.btnTrokut);
            this.Controls.Add(this.btnKvadrat);
            this.Controls.Add(this.btnPravokutnik);
            this.Name = "FrmMain";
            this.Text = "Početna forma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPravokutnik;
        private System.Windows.Forms.Button btnKvadrat;
        private System.Windows.Forms.Button btnTrokut;
        private System.Windows.Forms.Button btnKrug;
    }
}

