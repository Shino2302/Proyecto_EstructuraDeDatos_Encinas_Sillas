namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    partial class FormularioArreglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioArreglo));
            Titulo = new Label();
            NombreProducto = new Label();
            Cancelar = new Button();
            panel2 = new Panel();
            Confirmar = new Button();
            panel1 = new Panel();
            txtBoxNombre = new TextBox();
            txtBoxPrecio = new TextBox();
            btnInsertarAlFinal = new Button();
            panel3 = new Panel();
            btnInsertarEnMedio = new Button();
            panel4 = new Panel();
            PrecioP = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Cursor = Cursors.Hand;
            Titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(21, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(257, 40);
            Titulo.TabIndex = 17;
            Titulo.Text = "Agregar Producto";
            Titulo.Click += Titulo_Click;
            // 
            // NombreProducto
            // 
            NombreProducto.AutoSize = true;
            NombreProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NombreProducto.ForeColor = SystemColors.ControlLightLight;
            NombreProducto.Location = new Point(12, 74);
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Size = new Size(141, 17);
            NombreProducto.TabIndex = 20;
            NombreProducto.Text = "Nombre de Producto:";
            NombreProducto.Click += NombreProducto_Click;
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
            panel2.Location = new Point(12, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 100);
            panel2.TabIndex = 23;
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
            panel1.Location = new Point(173, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 101);
            panel1.TabIndex = 22;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(159, 68);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre Del Producto";
            txtBoxNombre.Size = new Size(119, 23);
            txtBoxNombre.TabIndex = 25;
            // 
            // txtBoxPrecio
            // 
            txtBoxPrecio.Location = new Point(159, 107);
            txtBoxPrecio.Name = "txtBoxPrecio";
            txtBoxPrecio.PlaceholderText = "Precio Del Producto";
            txtBoxPrecio.Size = new Size(119, 23);
            txtBoxPrecio.TabIndex = 26;
            txtBoxPrecio.KeyPress += txtBoxPrecio_KeyPress;
            // 
            // btnInsertarAlFinal
            // 
            btnInsertarAlFinal.BackColor = Color.Orange;
            btnInsertarAlFinal.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnInsertarAlFinal.ForeColor = SystemColors.ControlLightLight;
            btnInsertarAlFinal.Location = new Point(8, 35);
            btnInsertarAlFinal.Name = "btnInsertarAlFinal";
            btnInsertarAlFinal.Size = new Size(95, 51);
            btnInsertarAlFinal.TabIndex = 3;
            btnInsertarAlFinal.Text = "Insertar Al Final";
            btnInsertarAlFinal.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(btnInsertarAlFinal);
            panel3.Location = new Point(12, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(110, 101);
            panel3.TabIndex = 23;
            // 
            // btnInsertarEnMedio
            // 
            btnInsertarEnMedio.BackColor = Color.Orange;
            btnInsertarEnMedio.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnInsertarEnMedio.ForeColor = SystemColors.ControlLightLight;
            btnInsertarEnMedio.Location = new Point(8, 44);
            btnInsertarEnMedio.Name = "btnInsertarEnMedio";
            btnInsertarEnMedio.Size = new Size(95, 52);
            btnInsertarEnMedio.TabIndex = 3;
            btnInsertarEnMedio.Text = "InsertarEnMedio";
            btnInsertarEnMedio.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(btnInsertarEnMedio);
            panel4.Location = new Point(173, 276);
            panel4.Name = "panel4";
            panel4.Size = new Size(110, 101);
            panel4.TabIndex = 24;
            // 
            // PrecioP
            // 
            PrecioP.AutoSize = true;
            PrecioP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PrecioP.ForeColor = SystemColors.ControlLightLight;
            PrecioP.Location = new Point(12, 113);
            PrecioP.Name = "PrecioP";
            PrecioP.Size = new Size(133, 17);
            PrecioP.TabIndex = 27;
            PrecioP.Text = "Precio del Producto:";
            // 
            // FormularioArreglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(295, 403);
            Controls.Add(PrecioP);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(txtBoxPrecio);
            Controls.Add(txtBoxNombre);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(NombreProducto);
            Controls.Add(Titulo);
            Name = "FormularioArreglo";
            Text = "FormularioArreglo";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label NombreProducto;
        private Button Cancelar;
        private Panel panel2;
        private Button Confirmar;
        private Panel panel1;
        private TextBox txtBoxNombre;
        private TextBox txtBoxPrecio;
        private Button btnInsertarAlFinal;
        private Panel panel3;
        private Button btnInsertarEnMedio;
        private Panel panel4;
        private Label PrecioP;
    }
}