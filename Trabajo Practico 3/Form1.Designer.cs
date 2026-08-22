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
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            BSalir = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(49, 105);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 0;
            LDni.Text = "DNI";
            LDni.Click += label1_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(49, 136);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(49, 163);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(49, 73);
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
            LModificar.Location = new Point(200, 73);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "Modificar";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(200, 133);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 6;
            TNombre.Validating += TNombre_Validating;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(200, 163);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.Validating += TApellido_Validating;
            // 
            // TDni
            // 
            TDni.Location = new Point(200, 105);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 9;
            TDni.Validating += TDni_Validating;
            // 
            // TGuardar
            // 
            TGuardar.Image = Properties.Resources.guardar2;
            TGuardar.Location = new Point(12, 333);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(118, 46);
            TGuardar.TabIndex = 10;
            TGuardar.Text = "Guardar";
            TGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Image = Properties.Resources.eliminar;
            TEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEliminar.Location = new Point(178, 333);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(124, 44);
            TEliminar.TabIndex = 11;
            TEliminar.Text = "Eliminar";
            TEliminar.TextAlign = ContentAlignment.MiddleRight;
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(386, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(367, 176);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 13;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(462, 176);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 14;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox1.Location = new Point(200, 247);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 25);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Naranja";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(200, 197);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(47, 19);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Visa";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(200, 222);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(85, 19);
            checkBox3.TabIndex = 17;
            checkBox3.Text = "Mastercard";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 201);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 18;
            label1.Text = "Tarjetas de Credito:";
            label1.Click += label1_Click_1;
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.salir;
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(418, 315);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(101, 62);
            BSalir.TabIndex = 19;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(180, 37);
            label2.TabIndex = 20;
            label2.Text = "Nuevo cliente";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 391);
            Controls.Add(label2);
            Controls.Add(BSalir);
            Controls.Add(label1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private RadioButton RBMujer;
        private RadioButton RBVaron;
        private PictureBox pictureBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label1;
        private Button BSalir;
        private Label label2;
    }
}
