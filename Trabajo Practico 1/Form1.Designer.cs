namespace Practico1
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
            BGuardar = new Button();
            BEliminar = new Button();
            BNombre = new Label();
            BApellido = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            BResultado = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(57, 175);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 0;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += button1_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(171, 175);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 1;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BNombre
            // 
            BNombre.AutoSize = true;
            BNombre.Location = new Point(57, 64);
            BNombre.Name = "BNombre";
            BNombre.Size = new Size(51, 15);
            BNombre.TabIndex = 2;
            BNombre.Text = "Nombre";
            BNombre.Click += label1_Click;
            // 
            // BApellido
            // 
            BApellido.AutoSize = true;
            BApellido.Location = new Point(57, 115);
            BApellido.Name = "BApellido";
            BApellido.Size = new Size(51, 15);
            BApellido.TabIndex = 3;
            BApellido.Text = "Apellido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 23);
            textBox2.TabIndex = 5;
            // 
            // BResultado
            // 
            BResultado.Location = new Point(302, 64);
            BResultado.Multiline = true;
            BResultado.Name = "BResultado";
            BResultado.Size = new Size(170, 151);
            BResultado.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(12, 226);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(BSalir);
            Controls.Add(BResultado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BApellido);
            Controls.Add(BNombre);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi primer Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Button BEliminar;
        private Label BNombre;
        private Label BApellido;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox BResultado;
        private Button BSalir;
    }
}
