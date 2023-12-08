namespace Proyecto_EstructuraDeDatos_Encinas_Sillas
{
    partial class Arreglos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arreglos));
            Titulo = new Label();
            Eliminar = new Button();
            OrdenarDescendente = new Button();
            OrdenarAscendente = new Button();
            Modificar = new Button();
            Agregar = new Button();
            MenuPrincipal = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            CerrarApp = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(326, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(166, 47);
            Titulo.TabIndex = 28;
            Titulo.Text = "Arreglos";
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(217, 83, 79);
            Eliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Eliminar.ForeColor = SystemColors.ControlLightLight;
            Eliminar.Location = new Point(21, 207);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(133, 52);
            Eliminar.TabIndex = 27;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            // 
            // OrdenarDescendente
            // 
            OrdenarDescendente.BackColor = Color.Gold;
            OrdenarDescendente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrdenarDescendente.ForeColor = SystemColors.ControlLightLight;
            OrdenarDescendente.Location = new Point(237, 207);
            OrdenarDescendente.Name = "OrdenarDescendente";
            OrdenarDescendente.Size = new Size(133, 52);
            OrdenarDescendente.TabIndex = 26;
            OrdenarDescendente.Text = "Ordenar Descendente";
            OrdenarDescendente.UseVisualStyleBackColor = false;
            // 
            // OrdenarAscendente
            // 
            OrdenarAscendente.BackColor = Color.Gold;
            OrdenarAscendente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrdenarAscendente.ForeColor = SystemColors.ControlLightLight;
            OrdenarAscendente.Location = new Point(237, 138);
            OrdenarAscendente.Name = "OrdenarAscendente";
            OrdenarAscendente.Size = new Size(133, 52);
            OrdenarAscendente.TabIndex = 25;
            OrdenarAscendente.Text = "Ordenar Ascendente";
            OrdenarAscendente.UseVisualStyleBackColor = false;
            // 
            // Modificar
            // 
            Modificar.BackColor = Color.FromArgb(52, 152, 219);
            Modificar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Modificar.ForeColor = SystemColors.ControlLightLight;
            Modificar.Location = new Point(21, 138);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(133, 52);
            Modificar.TabIndex = 24;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.FromArgb(46, 204, 113);
            Agregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Agregar.ForeColor = SystemColors.ControlLightLight;
            Agregar.Location = new Point(132, 67);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(133, 52);
            Agregar.TabIndex = 23;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.BackColor = Color.FromArgb(52, 73, 94);
            MenuPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MenuPrincipal.ForeColor = SystemColors.ControlLightLight;
            MenuPrincipal.Location = new Point(77, 71);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(95, 60);
            MenuPrincipal.TabIndex = 8;
            MenuPrincipal.Text = "Menú Principal";
            MenuPrincipal.UseVisualStyleBackColor = false;
            MenuPrincipal.Click += MenuPrincipal_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(297, 293);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 147);
            panel2.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(MenuPrincipal);
            panel1.Location = new Point(32, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 147);
            panel1.TabIndex = 20;
            // 
            // CerrarApp
            // 
            CerrarApp.BackColor = Color.FromArgb(52, 73, 94);
            CerrarApp.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            CerrarApp.ForeColor = SystemColors.ControlLightLight;
            CerrarApp.Location = new Point(65, 71);
            CerrarApp.Name = "CerrarApp";
            CerrarApp.Size = new Size(95, 60);
            CerrarApp.TabIndex = 9;
            CerrarApp.Text = "Cerrar App";
            CerrarApp.UseVisualStyleBackColor = false;
            CerrarApp.Click += CerrarApp_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(CerrarApp);
            panel3.Location = new Point(561, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 147);
            panel3.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(451, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(309, 192);
            dataGridView1.TabIndex = 29;
            // 
            // Arreglos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Titulo);
            Controls.Add(Eliminar);
            Controls.Add(OrdenarDescendente);
            Controls.Add(OrdenarAscendente);
            Controls.Add(Modificar);
            Controls.Add(Agregar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Arreglos";
            Text = "Arreglos";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Titulo;
        private Button Eliminar;
        private Button OrdenarDescendente;
        private Button OrdenarAscendente;
        private Button Modificar;
        private Button Agregar;
        private Button MenuPrincipal;
        private Panel panel2;
        private Panel panel1;
        private Button CerrarApp;
        private Panel panel3;
        private DataGridView dataGridView1;
    }
}