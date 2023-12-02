namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    partial class FormularioListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioListas));
            panel1 = new Panel();
            Confirmar = new Button();
            panel2 = new Panel();
            Cancelar = new Button();
            Titulo = new Label();
            RazaDeMascota = new Label();
            NombreAlimento = new Label();
            PrecioAlimento = new Label();
            Existencia = new Label();
            radioBtnSi = new RadioButton();
            radioBtnNo = new RadioButton();
            txtBoxNombre = new TextBox();
            txtBoxPrecio = new TextBox();
            comboBoxRazas = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(Confirmar);
            panel1.Location = new Point(175, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 101);
            panel1.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(Cancelar);
            panel2.Location = new Point(0, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 100);
            panel2.TabIndex = 1;
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
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Cursor = Cursors.Hand;
            Titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(12, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(259, 40);
            Titulo.TabIndex = 2;
            Titulo.Text = "Agregar Alimento";
            Titulo.Click += Titulo_Click;
            // 
            // RazaDeMascota
            // 
            RazaDeMascota.AutoSize = true;
            RazaDeMascota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RazaDeMascota.ForeColor = SystemColors.ControlLightLight;
            RazaDeMascota.Location = new Point(0, 63);
            RazaDeMascota.Name = "RazaDeMascota";
            RazaDeMascota.Size = new Size(116, 17);
            RazaDeMascota.TabIndex = 5;
            RazaDeMascota.Text = "Tipo De Mascota:";
            RazaDeMascota.Click += RazaDeMascota_Click;
            // 
            // NombreAlimento
            // 
            NombreAlimento.AutoSize = true;
            NombreAlimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NombreAlimento.ForeColor = SystemColors.ControlLightLight;
            NombreAlimento.Location = new Point(0, 95);
            NombreAlimento.Name = "NombreAlimento";
            NombreAlimento.Size = new Size(62, 17);
            NombreAlimento.TabIndex = 6;
            NombreAlimento.Text = "Nombre:";
            NombreAlimento.Click += NombreAlimento_Click;
            // 
            // PrecioAlimento
            // 
            PrecioAlimento.AutoSize = true;
            PrecioAlimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PrecioAlimento.ForeColor = SystemColors.ControlLightLight;
            PrecioAlimento.Location = new Point(0, 127);
            PrecioAlimento.Name = "PrecioAlimento";
            PrecioAlimento.Size = new Size(50, 17);
            PrecioAlimento.TabIndex = 7;
            PrecioAlimento.Text = "Precio:";
            PrecioAlimento.Click += PrecioAlimento_Click;
            // 
            // Existencia
            // 
            Existencia.AutoSize = true;
            Existencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Existencia.ForeColor = SystemColors.ControlLightLight;
            Existencia.Location = new Point(0, 155);
            Existencia.Name = "Existencia";
            Existencia.Size = new Size(73, 17);
            Existencia.TabIndex = 8;
            Existencia.Text = "Existencia:";
            Existencia.Click += Existencia_Click;
            // 
            // radioBtnSi
            // 
            radioBtnSi.AutoSize = true;
            radioBtnSi.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioBtnSi.ForeColor = SystemColors.ControlLightLight;
            radioBtnSi.Location = new Point(82, 155);
            radioBtnSi.Name = "radioBtnSi";
            radioBtnSi.Size = new Size(35, 19);
            radioBtnSi.TabIndex = 9;
            radioBtnSi.TabStop = true;
            radioBtnSi.Text = "Si";
            radioBtnSi.UseVisualStyleBackColor = true;
            // 
            // radioBtnNo
            // 
            radioBtnNo.AutoSize = true;
            radioBtnNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioBtnNo.ForeColor = SystemColors.ControlLightLight;
            radioBtnNo.Location = new Point(165, 155);
            radioBtnNo.Name = "radioBtnNo";
            radioBtnNo.Size = new Size(42, 19);
            radioBtnNo.TabIndex = 10;
            radioBtnNo.TabStop = true;
            radioBtnNo.Text = "No";
            radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(122, 95);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre De Alimento";
            txtBoxNombre.Size = new Size(149, 23);
            txtBoxNombre.TabIndex = 12;
            // 
            // txtBoxPrecio
            // 
            txtBoxPrecio.Location = new Point(122, 127);
            txtBoxPrecio.Name = "txtBoxPrecio";
            txtBoxPrecio.PlaceholderText = "Precio De Alimento";
            txtBoxPrecio.Size = new Size(149, 23);
            txtBoxPrecio.TabIndex = 13;
            txtBoxPrecio.KeyPress += txtBoxPrecio_KeyPress;
            // 
            // comboBoxRazas
            // 
            comboBoxRazas.Cursor = Cursors.Hand;
            comboBoxRazas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRazas.FormattingEnabled = true;
            comboBoxRazas.Items.AddRange(new object[] { "Perro", "Gato", "Hamster", "Loro", "Conejo", "Raton", "Iguana" });
            comboBoxRazas.Location = new Point(122, 63);
            comboBoxRazas.MaxDropDownItems = 5;
            comboBoxRazas.Name = "comboBoxRazas";
            comboBoxRazas.Size = new Size(149, 23);
            comboBoxRazas.TabIndex = 28;
            // 
            // FormularioListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(285, 308);
            Controls.Add(comboBoxRazas);
            Controls.Add(txtBoxPrecio);
            Controls.Add(txtBoxNombre);
            Controls.Add(radioBtnNo);
            Controls.Add(radioBtnSi);
            Controls.Add(Existencia);
            Controls.Add(PrecioAlimento);
            Controls.Add(Titulo);
            Controls.Add(NombreAlimento);
            Controls.Add(RazaDeMascota);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormularioListas";
            Text = "FormularioListas";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Titulo;
        private Button Confirmar;
        private Button Cancelar;
        private Label RazaDeMascota;
        private Label NombreAlimento;
        private Label PrecioAlimento;
        private Label Existencia;
        private RadioButton radioBtnSi;
        private RadioButton radioBtnNo;
        private TextBox txtBoxNombre;
        private TextBox txtBoxPrecio;
        private ComboBox comboBoxRazas;
    }
}