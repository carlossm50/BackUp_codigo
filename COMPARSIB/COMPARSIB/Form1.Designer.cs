namespace COMPARSIB
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArchivos = new System.Windows.Forms.ComboBox();
            this.Cargar_archivoBanke = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Cargar_archivoCli = new System.Windows.Forms.Button();
            this.OdgArchivos = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCombinarCta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaseDatos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbArchivos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de archivo a cargar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archvo";
            // 
            // cbArchivos
            // 
            this.cbArchivos.FormattingEnabled = true;
            this.cbArchivos.Items.AddRange(new object[] {
            "DE11",
            "DE13",
            "DE15",
            "DE21",
            "DE23",
            "DE25"});
            this.cbArchivos.Location = new System.Drawing.Point(58, 19);
            this.cbArchivos.Name = "cbArchivos";
            this.cbArchivos.Size = new System.Drawing.Size(161, 21);
            this.cbArchivos.TabIndex = 0;
            // 
            // Cargar_archivoBanke
            // 
            this.Cargar_archivoBanke.Location = new System.Drawing.Point(351, 67);
            this.Cargar_archivoBanke.Name = "Cargar_archivoBanke";
            this.Cargar_archivoBanke.Size = new System.Drawing.Size(148, 33);
            this.Cargar_archivoBanke.TabIndex = 1;
            this.Cargar_archivoBanke.Text = "Cargar archivo Banke";
            this.Cargar_archivoBanke.UseVisualStyleBackColor = true;
            this.Cargar_archivoBanke.Click += new System.EventHandler(this.Cargar_archivo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 382);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Cargar_archivoCli
            // 
            this.Cargar_archivoCli.Location = new System.Drawing.Point(505, 67);
            this.Cargar_archivoCli.Name = "Cargar_archivoCli";
            this.Cargar_archivoCli.Size = new System.Drawing.Size(148, 33);
            this.Cargar_archivoCli.TabIndex = 3;
            this.Cargar_archivoCli.Text = "Cargar archivo cliente";
            this.Cargar_archivoCli.UseVisualStyleBackColor = true;
            this.Cargar_archivoCli.Click += new System.EventHandler(this.Cargar_archivoCli_Click);
            // 
            // OdgArchivos
            // 
            this.OdgArchivos.FileName = "openFileDialog1";
            this.OdgArchivos.Filter = "Archivo de texto|*.txt|Todo los archivo|*.asc";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(505, 120);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(502, 382);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(333, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(659, 71);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(348, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCombinarCta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbBaseDatos);
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 45);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Combinar cuentas";
            // 
            // btnCombinarCta
            // 
            this.btnCombinarCta.Location = new System.Drawing.Point(312, 12);
            this.btnCombinarCta.Name = "btnCombinarCta";
            this.btnCombinarCta.Size = new System.Drawing.Size(75, 23);
            this.btnCombinarCta.TabIndex = 7;
            this.btnCombinarCta.Text = "Combinar";
            this.btnCombinarCta.UseVisualStyleBackColor = true;
            this.btnCombinarCta.Click += new System.EventHandler(this.btnCombinarCta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Base de datos";
            // 
            // cbBaseDatos
            // 
            this.cbBaseDatos.FormattingEnabled = true;
            this.cbBaseDatos.Items.AddRange(new object[] {
            "DE21",
            "DE23",
            "DE25"});
            this.cbBaseDatos.Location = new System.Drawing.Point(88, 14);
            this.cbBaseDatos.Name = "cbBaseDatos";
            this.cbBaseDatos.Size = new System.Drawing.Size(202, 21);
            this.cbBaseDatos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Cargar_archivoCli);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Cargar_archivoBanke);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Comparador de Archivos SIB";
            this.Load += new System.EventHandler(this.Cargar_DB);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbArchivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cargar_archivoBanke;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Cargar_archivoCli;
        private System.Windows.Forms.OpenFileDialog OdgArchivos;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCombinarCta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaseDatos;

    }
}

