namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    partial class FormularioColas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioColas));
            txtBoxNombre = new TextBox();
            Encargo = new Label();
            Raza = new Label();
            Titulo = new Label();
            NombreMascota = new Label();
            Cancelar = new Button();
            panel2 = new Panel();
            Confirmar = new Button();
            panel1 = new Panel();
            comboBoxRazas = new ComboBox();
            comboBoxEncargos = new ComboBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(122, 63);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre De La Mascota";
            txtBoxNombre.Size = new Size(149, 23);
            txtBoxNombre.TabIndex = 24;
            // 
            // Encargo
            // 
            Encargo.AutoSize = true;
            Encargo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Encargo.ForeColor = SystemColors.ControlLightLight;
            Encargo.Location = new Point(4, 127);
            Encargo.Name = "Encargo";
            Encargo.Size = new Size(61, 17);
            Encargo.TabIndex = 20;
            Encargo.Text = "Encargo:";
            Encargo.Click += Encargo_Click;
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Raza.ForeColor = SystemColors.ControlLightLight;
            Raza.Location = new Point(4, 98);
            Raza.Name = "Raza";
            Raza.Size = new Size(40, 17);
            Raza.TabIndex = 19;
            Raza.Text = "Raza:";
            Raza.Click += Raza_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Cursor = Cursors.Hand;
            Titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(22, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(236, 40);
            Titulo.TabIndex = 16;
            Titulo.Text = "Agregar En Cola";
            Titulo.Click += Titulo_Click;
            // 
            // NombreMascota
            // 
            NombreMascota.AutoSize = true;
            NombreMascota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NombreMascota.ForeColor = SystemColors.ControlLightLight;
            NombreMascota.Location = new Point(4, 69);
            NombreMascota.Name = "NombreMascota";
            NombreMascota.Size = new Size(62, 17);
            NombreMascota.TabIndex = 18;
            NombreMascota.Text = "Nombre:";
            NombreMascota.Click += NombreMascota_Click;
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.Red;
            Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Cancelar.ForeColor = SystemColors.ControlLightLight;
            Cancelar.Location = new Point(3, 52);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(95, 34);
            Cancelar.TabIndex = 4;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            Cancelar.Click += Cancelar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(Cancelar);
            panel2.Location = new Point(4, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 100);
            panel2.TabIndex = 15;
            // 
            // Confirmar
            // 
            Confirmar.BackColor = Color.Orange;
            Confirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Confirmar.ForeColor = SystemColors.ControlLightLight;
            Confirmar.Location = new Point(8, 52);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(95, 34);
            Confirmar.TabIndex = 3;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = false;
            Confirmar.Click += Confirmar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(Confirmar);
            panel1.Location = new Point(169, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 101);
            panel1.TabIndex = 14;
            // 
            // comboBoxRazas
            // 
            comboBoxRazas.Cursor = Cursors.Hand;
            comboBoxRazas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRazas.FormattingEnabled = true;
            comboBoxRazas.Items.AddRange(new object[] { "Perro", "Gato", "Hamster", "Loro", "Conejo", "Raton", "Iguana" });
            comboBoxRazas.Location = new Point(123, 92);
            comboBoxRazas.MaxDropDownItems = 5;
            comboBoxRazas.Name = "comboBoxRazas";
            comboBoxRazas.Size = new Size(149, 23);
            comboBoxRazas.TabIndex = 27;
            // 
            // comboBoxEncargos
            // 
            comboBoxEncargos.Cursor = Cursors.Hand;
            comboBoxEncargos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEncargos.FormattingEnabled = true;
            comboBoxEncargos.Items.AddRange(new object[] { "Baño", "Corte De Pelo", "Corte De Garras", "Lavado De Dientes" });
            comboBoxEncargos.Location = new Point(123, 127);
            comboBoxEncargos.Name = "comboBoxEncargos";
            comboBoxEncargos.Size = new Size(149, 23);
            comboBoxEncargos.TabIndex = 28;
            // 
            // FormularioColas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(281, 309);
            Controls.Add(comboBoxEncargos);
            Controls.Add(comboBoxRazas);
            Controls.Add(txtBoxNombre);
            Controls.Add(Encargo);
            Controls.Add(Raza);
            Controls.Add(Titulo);
            Controls.Add(NombreMascota);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormularioColas";
            Text = "FormularioColas";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxNombre;
        private Label Encargo;
        private Label Raza;
        private Label Titulo;
        private Label NombreMascota;
        private Button Cancelar;
        private Panel panel2;
        private Button Confirmar;
        private Panel panel1;
        private ComboBox comboBoxRazas;
        private ComboBox comboBoxEncargos;
    }
}