namespace AlgoritmosGeneticos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            rbBajo = new RadioButton();
            rbMedio = new RadioButton();
            rbAlto = new RadioButton();
            groupBox2 = new GroupBox();
            rbAmarillo = new RadioButton();
            rbAzul = new RadioButton();
            rbRojo = new RadioButton();
            groupBox3 = new GroupBox();
            rbGrande = new RadioButton();
            rbNormal = new RadioButton();
            rbPequeno = new RadioButton();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            aplicaciónToolStripMenuItem = new ToolStripMenuItem();
            iniciarToolStripMenuItem = new ToolStripMenuItem();
            detenerToolStripMenuItem = new ToolStripMenuItem();
            lblGeneracion = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBajo);
            groupBox1.Controls.Add(rbMedio);
            groupBox1.Controls.Add(rbAlto);
            groupBox1.Location = new Point(30, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Altura:";
            // 
            // rbBajo
            // 
            rbBajo.AutoSize = true;
            rbBajo.Location = new Point(18, 81);
            rbBajo.Name = "rbBajo";
            rbBajo.Size = new Size(48, 19);
            rbBajo.TabIndex = 6;
            rbBajo.TabStop = true;
            rbBajo.Text = "Bajo";
            rbBajo.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            rbMedio.AutoSize = true;
            rbMedio.Location = new Point(18, 56);
            rbMedio.Name = "rbMedio";
            rbMedio.Size = new Size(59, 19);
            rbMedio.TabIndex = 5;
            rbMedio.TabStop = true;
            rbMedio.Text = "Medio";
            rbMedio.UseVisualStyleBackColor = true;
            // 
            // rbAlto
            // 
            rbAlto.AutoSize = true;
            rbAlto.CausesValidation = false;
            rbAlto.Location = new Point(18, 31);
            rbAlto.Name = "rbAlto";
            rbAlto.Size = new Size(47, 19);
            rbAlto.TabIndex = 4;
            rbAlto.TabStop = true;
            rbAlto.Text = "Alto";
            rbAlto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbAmarillo);
            groupBox2.Controls.Add(rbAzul);
            groupBox2.Controls.Add(rbRojo);
            groupBox2.Location = new Point(237, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color de flor:";
            // 
            // rbAmarillo
            // 
            rbAmarillo.AutoSize = true;
            rbAmarillo.Location = new Point(17, 81);
            rbAmarillo.Name = "rbAmarillo";
            rbAmarillo.Size = new Size(70, 19);
            rbAmarillo.TabIndex = 2;
            rbAmarillo.TabStop = true;
            rbAmarillo.Text = "Amarillo";
            rbAmarillo.UseVisualStyleBackColor = true;
            // 
            // rbAzul
            // 
            rbAzul.AutoSize = true;
            rbAzul.Location = new Point(17, 56);
            rbAzul.Name = "rbAzul";
            rbAzul.Size = new Size(48, 19);
            rbAzul.TabIndex = 1;
            rbAzul.TabStop = true;
            rbAzul.Text = "Azul";
            rbAzul.UseVisualStyleBackColor = true;
            // 
            // rbRojo
            // 
            rbRojo.AutoSize = true;
            rbRojo.Location = new Point(17, 29);
            rbRojo.Name = "rbRojo";
            rbRojo.Size = new Size(49, 19);
            rbRojo.TabIndex = 0;
            rbRojo.TabStop = true;
            rbRojo.Text = "Rojo";
            rbRojo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbGrande);
            groupBox3.Controls.Add(rbNormal);
            groupBox3.Controls.Add(rbPequeno);
            groupBox3.Location = new Point(452, 58);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(168, 113);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tamaño de flor:";
            // 
            // rbGrande
            // 
            rbGrande.AutoSize = true;
            rbGrande.Location = new Point(17, 81);
            rbGrande.Name = "rbGrande";
            rbGrande.Size = new Size(63, 19);
            rbGrande.TabIndex = 2;
            rbGrande.TabStop = true;
            rbGrande.Text = "Grande";
            rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(17, 56);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(65, 19);
            rbNormal.TabIndex = 1;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbPequeno
            // 
            rbPequeno.AutoSize = true;
            rbPequeno.Location = new Point(17, 30);
            rbPequeno.Name = "rbPequeno";
            rbPequeno.Size = new Size(72, 19);
            rbPequeno.TabIndex = 0;
            rbPequeno.TabStop = true;
            rbPequeno.Text = "Pequeño";
            rbPequeno.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicaciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(706, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(106, 22);
            cerrarToolStripMenuItem.Text = "Cerrar";
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // aplicaciónToolStripMenuItem
            // 
            aplicaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciarToolStripMenuItem, detenerToolStripMenuItem });
            aplicaciónToolStripMenuItem.Name = "aplicaciónToolStripMenuItem";
            aplicaciónToolStripMenuItem.Size = new Size(75, 20);
            aplicaciónToolStripMenuItem.Text = "Aplicación";
            // 
            // iniciarToolStripMenuItem
            // 
            iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            iniciarToolStripMenuItem.Size = new Size(115, 22);
            iniciarToolStripMenuItem.Text = "Iniciar";
            iniciarToolStripMenuItem.Click += iniciarToolStripMenuItem_Click;
            // 
            // detenerToolStripMenuItem
            // 
            detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            detenerToolStripMenuItem.Size = new Size(115, 22);
            detenerToolStripMenuItem.Text = "Detener";
            detenerToolStripMenuItem.Click += detenerToolStripMenuItem_Click;
            // 
            // lblGeneracion
            // 
            lblGeneracion.AutoSize = true;
            lblGeneracion.Location = new Point(30, 196);
            lblGeneracion.Name = "lblGeneracion";
            lblGeneracion.Size = new Size(67, 15);
            lblGeneracion.TabIndex = 4;
            lblGeneracion.Text = "Generación";
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 474);
            Controls.Add(lblGeneracion);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Algoritmos Geneticos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private ToolStripMenuItem aplicaciónToolStripMenuItem;
        private ToolStripMenuItem iniciarToolStripMenuItem;
        private ToolStripMenuItem detenerToolStripMenuItem;
        private RadioButton rbAlto;
        private RadioButton rbBajo;
        private RadioButton rbMedio;
        private RadioButton rbAmarillo;
        private RadioButton rbAzul;
        private RadioButton rbRojo;
        private RadioButton rbGrande;
        private RadioButton rbNormal;
        private RadioButton rbPequeno;
        private Label lblGeneracion;
        private System.Windows.Forms.Timer timer1;
    }
}
