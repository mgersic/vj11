namespace Lab_3_2_Testiranje
{
    partial class FrmPravokutnik
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
            this.lblStranicaA = new System.Windows.Forms.Label();
            this.lblStranicaB = new System.Windows.Forms.Label();
            this.lblDijagonala = new System.Windows.Forms.Label();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.txtStranicaA = new System.Windows.Forms.TextBox();
            this.txtStranicaB = new System.Windows.Forms.TextBox();
            this.txtDijagonala = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.lblOpseg = new System.Windows.Forms.Label();
            this.gbUnos = new System.Windows.Forms.GroupBox();
            this.gbRezultati = new System.Windows.Forms.GroupBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.gbUnos.SuspendLayout();
            this.gbRezultati.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStranicaA
            // 
            this.lblStranicaA.AutoSize = true;
            this.lblStranicaA.Location = new System.Drawing.Point(6, 25);
            this.lblStranicaA.Name = "lblStranicaA";
            this.lblStranicaA.Size = new System.Drawing.Size(59, 13);
            this.lblStranicaA.TabIndex = 0;
            this.lblStranicaA.Text = "Stranica A:";
            // 
            // lblStranicaB
            // 
            this.lblStranicaB.AutoSize = true;
            this.lblStranicaB.Location = new System.Drawing.Point(6, 51);
            this.lblStranicaB.Name = "lblStranicaB";
            this.lblStranicaB.Size = new System.Drawing.Size(59, 13);
            this.lblStranicaB.TabIndex = 1;
            this.lblStranicaB.Text = "Stranica B:";
            // 
            // lblDijagonala
            // 
            this.lblDijagonala.AutoSize = true;
            this.lblDijagonala.Location = new System.Drawing.Point(5, 22);
            this.lblDijagonala.Name = "lblDijagonala";
            this.lblDijagonala.Size = new System.Drawing.Size(60, 13);
            this.lblDijagonala.TabIndex = 2;
            this.lblDijagonala.Text = "Dijagonala:";
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(5, 48);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(51, 13);
            this.lblPovrsina.TabIndex = 3;
            this.lblPovrsina.Text = "Površina:";
            // 
            // txtStranicaA
            // 
            this.txtStranicaA.Location = new System.Drawing.Point(101, 22);
            this.txtStranicaA.Name = "txtStranicaA";
            this.txtStranicaA.Size = new System.Drawing.Size(100, 20);
            this.txtStranicaA.TabIndex = 4;
            this.txtStranicaA.Text = "0,00";
            this.txtStranicaA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStranicaB
            // 
            this.txtStranicaB.Location = new System.Drawing.Point(101, 48);
            this.txtStranicaB.Name = "txtStranicaB";
            this.txtStranicaB.Size = new System.Drawing.Size(100, 20);
            this.txtStranicaB.TabIndex = 5;
            this.txtStranicaB.Text = "0,00";
            this.txtStranicaB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDijagonala
            // 
            this.txtDijagonala.Location = new System.Drawing.Point(100, 19);
            this.txtDijagonala.Name = "txtDijagonala";
            this.txtDijagonala.Size = new System.Drawing.Size(100, 20);
            this.txtDijagonala.TabIndex = 6;
            this.txtDijagonala.Text = "0,00";
            this.txtDijagonala.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(100, 45);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.Size = new System.Drawing.Size(100, 20);
            this.txtPovrsina.TabIndex = 7;
            this.txtPovrsina.Text = "0,00";
            this.txtPovrsina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(100, 71);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.Size = new System.Drawing.Size(100, 20);
            this.txtOpseg.TabIndex = 9;
            this.txtOpseg.Text = "0,00";
            this.txtOpseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOpseg
            // 
            this.lblOpseg.AutoSize = true;
            this.lblOpseg.Location = new System.Drawing.Point(5, 74);
            this.lblOpseg.Name = "lblOpseg";
            this.lblOpseg.Size = new System.Drawing.Size(41, 13);
            this.lblOpseg.TabIndex = 8;
            this.lblOpseg.Text = "Opseg:";
            // 
            // gbUnos
            // 
            this.gbUnos.Controls.Add(this.lblStranicaA);
            this.gbUnos.Controls.Add(this.lblStranicaB);
            this.gbUnos.Controls.Add(this.txtStranicaA);
            this.gbUnos.Controls.Add(this.txtStranicaB);
            this.gbUnos.Location = new System.Drawing.Point(12, 12);
            this.gbUnos.Name = "gbUnos";
            this.gbUnos.Size = new System.Drawing.Size(226, 91);
            this.gbUnos.TabIndex = 10;
            this.gbUnos.TabStop = false;
            this.gbUnos.Text = "Unos podataka";
            // 
            // gbRezultati
            // 
            this.gbRezultati.Controls.Add(this.lblDijagonala);
            this.gbRezultati.Controls.Add(this.lblPovrsina);
            this.gbRezultati.Controls.Add(this.txtOpseg);
            this.gbRezultati.Controls.Add(this.txtDijagonala);
            this.gbRezultati.Controls.Add(this.lblOpseg);
            this.gbRezultati.Controls.Add(this.txtPovrsina);
            this.gbRezultati.Location = new System.Drawing.Point(13, 109);
            this.gbRezultati.Name = "gbRezultati";
            this.gbRezultati.Size = new System.Drawing.Size(225, 100);
            this.gbRezultati.TabIndex = 11;
            this.gbRezultati.TabStop = false;
            this.gbRezultati.Text = "Rezultati";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(163, 215);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 12;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(82, 215);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 13;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FrmPravokutnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 262);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.gbRezultati);
            this.Controls.Add(this.gbUnos);
            this.Name = "FrmPravokutnik";
            this.Text = "Izračun geometrijskih svojstava pravokutnika";
            this.gbUnos.ResumeLayout(false);
            this.gbUnos.PerformLayout();
            this.gbRezultati.ResumeLayout(false);
            this.gbRezultati.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStranicaA;
        private System.Windows.Forms.Label lblStranicaB;
        private System.Windows.Forms.Label lblDijagonala;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.TextBox txtStranicaA;
        private System.Windows.Forms.TextBox txtStranicaB;
        private System.Windows.Forms.TextBox txtDijagonala;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.Label lblOpseg;
        private System.Windows.Forms.GroupBox gbUnos;
        private System.Windows.Forms.GroupBox gbRezultati;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnIzlaz;
    }
}