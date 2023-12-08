namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    partial class FormularioPilas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPilas));
            Titulo = new Label();
            txtBoxNotas = new TextBox();
            txtBoxNombre = new TextBox();
            Nota = new Label();
            NombreMascota = new Label();
            panel2 = new Panel();
            Cancelar = new Button();
            Confirmar = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Cursor = Cursors.Hand;
            Titulo.Font = new Font("Segoe UI", 22.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(23, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(240, 41);
            Titulo.TabIndex = 19;
            Titulo.Text = "Agregar En Pila";
            // 
            // txtBoxNotas
            // 
            txtBoxNotas.Location = new Point(129, 119);
            txtBoxNotas.Name = "txtBoxNotas";
            txtBoxNotas.PlaceholderText = "Pendiente Con La Mascota";
            txtBoxNotas.Size = new Size(143, 23);
            txtBoxNotas.TabIndex = 30;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(129, 80);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre De la Mascota";
            txtBoxNombre.Size = new Size(143, 23);
            txtBoxNombre.TabIndex = 29;
            // 
            // Nota
            // 
            Nota.AutoSize = true;
            Nota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Nota.ForeColor = SystemColors.ControlLightLight;
            Nota.Location = new Point(13, 125);
            Nota.Name = "Nota";
            Nota.Size = new Size(42, 17);
            Nota.TabIndex = 28;
            Nota.Text = "Nota:";
            // 
            // NombreMascota
            // 
            NombreMascota.AutoSize = true;
            NombreMascota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NombreMascota.ForeColor = SystemColors.ControlLightLight;
            NombreMascota.Location = new Point(13, 86);
            NombreMascota.Name = "NombreMascota";
            NombreMascota.Size = new Size(62, 17);
            NombreMascota.TabIndex = 27;
            NombreMascota.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(Cancelar);
            panel2.Location = new Point(3, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 100);
            panel2.TabIndex = 32;
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
            panel1.Location = new Point(168, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 101);
            panel1.TabIndex = 31;
            // 
            // FormularioPilas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 282);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtBoxNotas);
            Controls.Add(txtBoxNombre);
            Controls.Add(Nota);
            Controls.Add(NombreMascota);
            Controls.Add(Titulo);
            Name = "FormularioPilas";
            Text = "FormularioPilas";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private TextBox txtBoxNotas;
        private TextBox txtBoxNombre;
        private Label Nota;
        private Label NombreMascota;
        private Panel panel2;
        private Button Cancelar;
        private Button Confirmar;
        private Panel panel1;
    }
}