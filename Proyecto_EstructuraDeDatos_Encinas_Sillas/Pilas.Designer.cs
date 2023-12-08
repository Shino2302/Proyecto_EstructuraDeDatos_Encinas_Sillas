namespace Proyecto_EstructuraDeDatos_Encinas_Sillas
{
    partial class Pilas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pilas));
            Titulo = new Label();
            Eliminar = new Button();
            Modificar = new Button();
            Agregar = new Button();
            panel3 = new Panel();
            CerrarApp = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            MenuPrincipal = new Button();
            gridContenedor = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridContenedor).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(355, 11);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(104, 47);
            Titulo.TabIndex = 18;
            Titulo.Text = "Pilas";
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(217, 83, 79);
            Eliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Eliminar.ForeColor = SystemColors.ControlLightLight;
            Eliminar.Location = new Point(32, 141);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(133, 52);
            Eliminar.TabIndex = 17;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Modificar
            // 
            Modificar.BackColor = Color.FromArgb(52, 152, 219);
            Modificar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Modificar.ForeColor = SystemColors.ControlLightLight;
            Modificar.Location = new Point(241, 141);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(133, 52);
            Modificar.TabIndex = 14;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            Modificar.Click += Modificar_Click;
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.FromArgb(46, 204, 113);
            Agregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Agregar.ForeColor = SystemColors.ControlLightLight;
            Agregar.Location = new Point(132, 67);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(133, 52);
            Agregar.TabIndex = 13;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(CerrarApp);
            panel3.Location = new Point(561, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 147);
            panel3.TabIndex = 12;
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
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(297, 293);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 147);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(MenuPrincipal);
            panel1.Location = new Point(32, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 147);
            panel1.TabIndex = 10;
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
            // gridContenedor
            // 
            gridContenedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridContenedor.Location = new Point(426, 59);
            gridContenedor.Name = "gridContenedor";
            gridContenedor.RowTemplate.Height = 25;
            gridContenedor.Size = new Size(354, 218);
            gridContenedor.TabIndex = 19;
            // 
            // Pilas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(800, 450);
            Controls.Add(gridContenedor);
            Controls.Add(Titulo);
            Controls.Add(Eliminar);
            Controls.Add(Modificar);
            Controls.Add(Agregar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Pilas";
            Text = "Pilas";
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridContenedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Titulo;
        private Button Eliminar;
        private Button Modificar;
        private Button Agregar;
        private Panel panel3;
        private Button CerrarApp;
        private Panel panel2;
        private Panel panel1;
        private Button MenuPrincipal;
        private DataGridView gridContenedor;
    }
}