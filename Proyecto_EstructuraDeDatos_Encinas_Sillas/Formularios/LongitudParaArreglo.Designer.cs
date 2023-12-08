namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    partial class LongitudParaArreglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongitudParaArreglo));
            Titulo = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            Confirmar = new Button();
            Cancelar = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Cursor = Cursors.Hand;
            Titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(23, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(187, 25);
            Titulo.TabIndex = 18;
            Titulo.Text = "Ingrese La Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 19;
            label1.Text = "Para Comenzar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(Confirmar);
            panel1.Location = new Point(133, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 101);
            panel1.TabIndex = 21;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(Cancelar);
            panel2.Location = new Point(1, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 100);
            panel2.TabIndex = 22;
            // 
            // LongitudParaArreglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(240, 205);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Titulo);
            Name = "LongitudParaArreglo";
            Text = "LongitudParaArreglo";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Button Confirmar;
        private Button Cancelar;
        private Panel panel2;
    }
}