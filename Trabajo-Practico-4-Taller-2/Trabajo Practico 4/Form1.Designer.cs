namespace Trabajo_Practico_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LApellido = new Label();
            LNombre = new Label();
            LFecha = new Label();
            LSexo = new Label();
            LSaldo = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            CHombre = new CheckBox();
            CMujer = new CheckBox();
            BtnFoto = new Button();
            openFileDialog1 = new OpenFileDialog();
            TxtFoto = new TextBox();
            pictureBox2 = new PictureBox();
            BtnAgregar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = Color.Transparent;
            LApellido.Font = new Font("Papyrus", 16F);
            LApellido.ImageAlign = ContentAlignment.MiddleLeft;
            LApellido.Location = new Point(115, 96);
            LApellido.Margin = new Padding(5, 0, 5, 0);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(99, 34);
            LApellido.TabIndex = 0;
            LApellido.Text = "Apellido";
            LApellido.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = Color.Transparent;
            LNombre.Font = new Font("Papyrus", 16F);
            LNombre.ForeColor = Color.White;
            LNombre.ImageAlign = ContentAlignment.MiddleLeft;
            LNombre.Location = new Point(115, 51);
            LNombre.Margin = new Padding(5, 0, 5, 0);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(91, 34);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            LNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.BackColor = Color.Transparent;
            LFecha.ImageAlign = ContentAlignment.MiddleLeft;
            LFecha.Location = new Point(115, 148);
            LFecha.Margin = new Padding(5, 0, 5, 0);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(189, 34);
            LFecha.TabIndex = 2;
            LFecha.Text = "Fecha Nacimiento";
            LFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.BackColor = Color.Transparent;
            LSexo.ImageAlign = ContentAlignment.MiddleLeft;
            LSexo.Location = new Point(115, 193);
            LSexo.Margin = new Padding(5, 0, 5, 0);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(69, 34);
            LSexo.TabIndex = 3;
            LSexo.Text = "Sexo";
            LSexo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LSaldo
            // 
            LSaldo.AutoSize = true;
            LSaldo.BackColor = Color.Transparent;
            LSaldo.ImageAlign = ContentAlignment.MiddleLeft;
            LSaldo.Location = new Point(115, 240);
            LSaldo.Margin = new Padding(5, 0, 5, 0);
            LSaldo.Name = "LSaldo";
            LSaldo.Size = new Size(77, 34);
            LSaldo.TabIndex = 4;
            LSaldo.Text = "Saldo";
            LSaldo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(104, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 347);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 15F);
            textBox1.Location = new Point(239, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 30);
            textBox1.TabIndex = 6;
            // 
            // TxtApellido
            // 
            TxtApellido.Font = new Font("Arial", 15F);
            TxtApellido.Location = new Point(239, 94);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(238, 30);
            TxtApellido.TabIndex = 7;
            TxtApellido.Leave += TxtApellido_Leave;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Arial", 15F);
            TxtNombre.Location = new Point(239, 52);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(238, 30);
            TxtNombre.TabIndex = 8;
            TxtNombre.Leave += TxtNombre_Leave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(312, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 41);
            dateTimePicker1.TabIndex = 9;
            // 
            // CHombre
            // 
            CHombre.AutoSize = true;
            CHombre.Font = new Font("Papyrus", 10F);
            CHombre.Location = new Point(239, 193);
            CHombre.Name = "CHombre";
            CHombre.Size = new Size(82, 26);
            CHombre.TabIndex = 10;
            CHombre.Text = "Hombre";
            CHombre.UseVisualStyleBackColor = true;
            // 
            // CMujer
            // 
            CMujer.AutoSize = true;
            CMujer.Font = new Font("Papyrus", 10F);
            CMujer.Location = new Point(354, 193);
            CMujer.Name = "CMujer";
            CMujer.Size = new Size(66, 26);
            CMujer.TabIndex = 11;
            CMujer.Text = "Mujer";
            CMujer.UseVisualStyleBackColor = true;
            // 
            // BtnFoto
            // 
            BtnFoto.Font = new Font("Arial", 8.25F);
            BtnFoto.ForeColor = Color.Black;
            BtnFoto.Location = new Point(117, 297);
            BtnFoto.Name = "BtnFoto";
            BtnFoto.Size = new Size(75, 23);
            BtnFoto.TabIndex = 12;
            BtnFoto.Text = "Foto";
            BtnFoto.UseVisualStyleBackColor = true;
            BtnFoto.Click += BtnFoto_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // TxtFoto
            // 
            TxtFoto.Font = new Font("Arial", 15F);
            TxtFoto.Location = new Point(239, 290);
            TxtFoto.Name = "TxtFoto";
            TxtFoto.Size = new Size(238, 30);
            TxtFoto.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(510, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(370, 347);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Font = new Font("Arial", 8.25F);
            BtnAgregar.ForeColor = Color.Black;
            BtnAgregar.Image = (Image)resources.GetObject("BtnAgregar.Image");
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(281, 334);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(104, 37);
            BtnAgregar.TabIndex = 15;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(933, 348);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 749);
            Controls.Add(dataGridView1);
            Controls.Add(BtnAgregar);
            Controls.Add(pictureBox2);
            Controls.Add(TxtFoto);
            Controls.Add(BtnFoto);
            Controls.Add(CMujer);
            Controls.Add(CHombre);
            Controls.Add(dateTimePicker1);
            Controls.Add(TxtNombre);
            Controls.Add(TxtApellido);
            Controls.Add(textBox1);
            Controls.Add(LFecha);
            Controls.Add(LSaldo);
            Controls.Add(LSexo);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(pictureBox1);
            Font = new Font("Papyrus", 16F);
            ForeColor = Color.White;
            Margin = new Padding(5, 7, 5, 7);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Formulario con DataGrid";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LApellido;
        private Label LNombre;
        private Label LFecha;
        private Label LSexo;
        private Label LSaldo;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private DateTimePicker dateTimePicker1;
        private CheckBox CHombre;
        private CheckBox CMujer;
        private Button BtnFoto;
        private OpenFileDialog openFileDialog1;
        private TextBox TxtFoto;
        private PictureBox pictureBox2;
        private Button BtnAgregar;
        private DataGridView dataGridView1;
    }
}
