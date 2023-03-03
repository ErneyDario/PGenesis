namespace PañaleraGenesis
{
    partial class Frminicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Informes = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnproveedores = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.btninventario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgenesis = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSeccionToolStripMenuItem,
            this.cerrarProgramaToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSeccionToolStripMenuItem
            // 
            this.cerrarSeccionToolStripMenuItem.Name = "cerrarSeccionToolStripMenuItem";
            this.cerrarSeccionToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.cerrarSeccionToolStripMenuItem.Text = "cerrar sesion";
            this.cerrarSeccionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeccionToolStripMenuItem_Click);
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.cerrarProgramaToolStripMenuItem.Text = "cerrar programa";
            this.cerrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.cerrarProgramaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 365);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(191, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(526, 227);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.Informes);
            this.panel3.Controls.Add(this.btnclientes);
            this.panel3.Controls.Add(this.btnproveedores);
            this.panel3.Controls.Add(this.btnventas);
            this.panel3.Controls.Add(this.btninventario);
            this.panel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(26, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 326);
            this.panel3.TabIndex = 1;
            // 
            // Informes
            // 
            this.Informes.BackColor = System.Drawing.Color.Silver;
            this.Informes.Location = new System.Drawing.Point(18, 244);
            this.Informes.Name = "Informes";
            this.Informes.Size = new System.Drawing.Size(123, 35);
            this.Informes.TabIndex = 0;
            this.Informes.Text = "Informes";
            this.Informes.UseVisualStyleBackColor = false;
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.Silver;
            this.btnclientes.Location = new System.Drawing.Point(18, 183);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(123, 35);
            this.btnclientes.TabIndex = 0;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = false;
            // 
            // btnproveedores
            // 
            this.btnproveedores.BackColor = System.Drawing.Color.Silver;
            this.btnproveedores.Location = new System.Drawing.Point(18, 127);
            this.btnproveedores.Name = "btnproveedores";
            this.btnproveedores.Size = new System.Drawing.Size(123, 37);
            this.btnproveedores.TabIndex = 0;
            this.btnproveedores.Text = "Proveedores";
            this.btnproveedores.UseVisualStyleBackColor = false;
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.Silver;
            this.btnventas.Location = new System.Drawing.Point(18, 70);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(123, 40);
            this.btnventas.TabIndex = 0;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = false;
            // 
            // btninventario
            // 
            this.btninventario.BackColor = System.Drawing.Color.Silver;
            this.btninventario.Location = new System.Drawing.Point(18, 18);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(123, 33);
            this.btninventario.TabIndex = 0;
            this.btninventario.Text = "Inventario";
            this.btninventario.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblgenesis);
            this.panel2.Location = new System.Drawing.Point(188, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 93);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(254, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pañalera y variedades";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblgenesis
            // 
            this.lblgenesis.AutoSize = true;
            this.lblgenesis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblgenesis.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblgenesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblgenesis.Location = new System.Drawing.Point(101, 12);
            this.lblgenesis.Name = "lblgenesis";
            this.lblgenesis.Size = new System.Drawing.Size(162, 39);
            this.lblgenesis.TabIndex = 0;
            this.lblgenesis.Text = "Génesis";
            // 
            // Frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frminicio";
            this.Text = "vista3";
            this.Load += new System.EventHandler(this.Frminicio_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarSeccionToolStripMenuItem;
        private ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Button Informes;
        private Button btnclientes;
        private Button btnproveedores;
        private Button btnventas;
        private Button btninventario;
        private Panel panel2;
        private Label lblgenesis;
        private Label label1;
    }
}