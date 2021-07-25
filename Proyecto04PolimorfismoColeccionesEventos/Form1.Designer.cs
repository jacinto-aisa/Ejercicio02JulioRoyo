
namespace Proyecto04
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAcero = new System.Windows.Forms.Button();
            this.buttonBronce = new System.Windows.Forms.Button();
            this.buttonGominola = new System.Windows.Forms.Button();
            this.buttonPapel = new System.Windows.Forms.Button();
            this.buttonChip = new System.Windows.Forms.Button();
            this.buttonEscoba = new System.Windows.Forms.Button();
            this.buttonHigo = new System.Windows.Forms.Button();
            this.labelKgPnoI = new System.Windows.Forms.Label();
            this.labelCantMat = new System.Windows.Forms.Label();
            this.labelProNoP = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMateriales = new System.Windows.Forms.ListBox();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAcero
            // 
            this.buttonAcero.Location = new System.Drawing.Point(47, 26);
            this.buttonAcero.Name = "buttonAcero";
            this.buttonAcero.Size = new System.Drawing.Size(75, 23);
            this.buttonAcero.TabIndex = 0;
            this.buttonAcero.Text = "Acero";
            this.buttonAcero.UseVisualStyleBackColor = true;
            this.buttonAcero.Click += new System.EventHandler(this.ButtonPantalla_Click);
            // 
            // buttonBronce
            // 
            this.buttonBronce.Location = new System.Drawing.Point(171, 26);
            this.buttonBronce.Name = "buttonBronce";
            this.buttonBronce.Size = new System.Drawing.Size(75, 23);
            this.buttonBronce.TabIndex = 1;
            this.buttonBronce.Text = "Bronce";
            this.buttonBronce.UseVisualStyleBackColor = true;
            this.buttonBronce.Click += new System.EventHandler(this.ButtonPantalla_Click);
            // 
            // buttonGominola
            // 
            this.buttonGominola.Location = new System.Drawing.Point(282, 26);
            this.buttonGominola.Name = "buttonGominola";
            this.buttonGominola.Size = new System.Drawing.Size(75, 23);
            this.buttonGominola.TabIndex = 2;
            this.buttonGominola.Text = "Gominola";
            this.buttonGominola.UseVisualStyleBackColor = true;
            this.buttonGominola.Click += new System.EventHandler(this.ButtonPantalla_Click);
            // 
            // buttonPapel
            // 
            this.buttonPapel.Location = new System.Drawing.Point(282, 67);
            this.buttonPapel.Name = "buttonPapel";
            this.buttonPapel.Size = new System.Drawing.Size(75, 23);
            this.buttonPapel.TabIndex = 3;
            this.buttonPapel.Text = "Papel";
            this.buttonPapel.UseVisualStyleBackColor = true;
            this.buttonPapel.Click += new System.EventHandler(this.ButtonPantalla_Click);
            // 
            // buttonChip
            // 
            this.buttonChip.Location = new System.Drawing.Point(171, 67);
            this.buttonChip.Name = "buttonChip";
            this.buttonChip.Size = new System.Drawing.Size(75, 23);
            this.buttonChip.TabIndex = 4;
            this.buttonChip.Text = "Chip";
            this.buttonChip.UseVisualStyleBackColor = true;
            this.buttonChip.Click += new System.EventHandler(this.ButtonPantalla_Click);
            // 
            // buttonEscoba
            // 
            this.buttonEscoba.Location = new System.Drawing.Point(47, 67);
            this.buttonEscoba.Name = "buttonEscoba";
            this.buttonEscoba.Size = new System.Drawing.Size(75, 23);
            this.buttonEscoba.TabIndex = 5;
            this.buttonEscoba.Text = "Escoba";
            this.buttonEscoba.UseVisualStyleBackColor = true;
            this.buttonEscoba.Click += new System.EventHandler(this.ButtonPantalla_Click);
            // 
            // buttonHigo
            // 
            this.buttonHigo.Location = new System.Drawing.Point(47, 108);
            this.buttonHigo.Name = "buttonHigo";
            this.buttonHigo.Size = new System.Drawing.Size(75, 23);
            this.buttonHigo.TabIndex = 6;
            this.buttonHigo.Text = "Higo";
            this.buttonHigo.UseVisualStyleBackColor = true;
            this.buttonHigo.Click += new System.EventHandler(this.ButtonPantalla_Click);
            // 
            // labelKgPnoI
            // 
            this.labelKgPnoI.AutoSize = true;
            this.labelKgPnoI.Location = new System.Drawing.Point(47, 180);
            this.labelKgPnoI.Name = "labelKgPnoI";
            this.labelKgPnoI.Size = new System.Drawing.Size(71, 13);
            this.labelKgPnoI.TabIndex = 7;
            this.labelKgPnoI.Text = "Kg mat P no I";
            // 
            // labelCantMat
            // 
            this.labelCantMat.AutoSize = true;
            this.labelCantMat.Location = new System.Drawing.Point(171, 179);
            this.labelCantMat.Name = "labelCantMat";
            this.labelCantMat.Size = new System.Drawing.Size(114, 13);
            this.labelCantMat.TabIndex = 8;
            this.labelCantMat.Text = "Cantidad de materiales";
            // 
            // labelProNoP
            // 
            this.labelProNoP.AutoSize = true;
            this.labelProNoP.Location = new System.Drawing.Point(327, 180);
            this.labelProNoP.Name = "labelProNoP";
            this.labelProNoP.Size = new System.Drawing.Size(126, 13);
            this.labelProNoP.TabIndex = 9;
            this.labelProNoP.Text = "Media de productos no P";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad de \r\nMateriales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(327, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Media de KG de productos\r\n no perecederos del total\r\nde productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kg materiales Perecederos \r\nno Inflamables";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxMateriales
            // 
            this.listBoxMateriales.FormattingEnabled = true;
            this.listBoxMateriales.Location = new System.Drawing.Point(656, 12);
            this.listBoxMateriales.Name = "listBoxMateriales";
            this.listBoxMateriales.Size = new System.Drawing.Size(120, 225);
            this.listBoxMateriales.TabIndex = 13;
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.Location = new System.Drawing.Point(511, 180);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(15, 13);
            this.labelPorcentaje.TabIndex = 14;
            this.labelPorcentaje.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Porcentaje de productos \r\nno perecederos \r\nrespecto del total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPorcentaje);
            this.Controls.Add(this.listBoxMateriales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProNoP);
            this.Controls.Add(this.labelCantMat);
            this.Controls.Add(this.labelKgPnoI);
            this.Controls.Add(this.buttonHigo);
            this.Controls.Add(this.buttonEscoba);
            this.Controls.Add(this.buttonChip);
            this.Controls.Add(this.buttonPapel);
            this.Controls.Add(this.buttonGominola);
            this.Controls.Add(this.buttonBronce);
            this.Controls.Add(this.buttonAcero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcero;
        private System.Windows.Forms.Button buttonBronce;
        private System.Windows.Forms.Button buttonGominola;
        private System.Windows.Forms.Button buttonPapel;
        private System.Windows.Forms.Button buttonChip;
        private System.Windows.Forms.Button buttonEscoba;
        private System.Windows.Forms.Button buttonHigo;
        private System.Windows.Forms.Label labelKgPnoI;
        private System.Windows.Forms.Label labelCantMat;
        private System.Windows.Forms.Label labelProNoP;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListBox listBoxMateriales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.Label label4;
    }
}

