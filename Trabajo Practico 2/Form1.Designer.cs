namespace Practico2
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
            LDni = new Label();
            LNombre = new Label();
            LApellido = new Label();
            LNya = new Label();
            LModificar = new Label();
            TNombre = new TextBox();
            TApellido = new TextBox();
            TDni = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(49, 129);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 0;
            LDni.Text = "DNI";
            LDni.Click += label1_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(49, 174);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(49, 223);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(49, 48);
            LNya.Name = "LNya";
            LNya.Size = new Size(105, 15);
            LNya.TabIndex = 3;
            LNya.Text = "Nombre y apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.Control;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(200, 48);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "Modificar";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(200, 171);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 6;
            TNombre.Validating += TNombre_Validating;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(200, 223);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.Validating += TApellido_Validating;
            // 
            // TDni
            // 
            TDni.Location = new Point(200, 129);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 9;
            TDni.Validating += TDni_Validating;
            // 
            // TGuardar
            // 
            TGuardar.Location = new Point(49, 301);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(75, 23);
            TGuardar.TabIndex = 10;
            TGuardar.Text = "Guardar";
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Location = new Point(211, 301);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(75, 23);
            TEliminar.TabIndex = 11;
            TEliminar.Text = "Eliminar";
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 387);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(TDni);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(LDni);
            Name = "Form1";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LDni;
        private Label LNombre;
        private Label LApellido;
        private Label LNya;
        private Label LModificar;
        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TDni;
        private Button TGuardar;
        private Button TEliminar;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}
