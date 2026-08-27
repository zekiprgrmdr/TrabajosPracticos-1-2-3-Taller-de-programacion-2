using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Trabajo_Practico_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Punto 1: Formatos transparentes de etiquetas y radiobuttons
            LApellido.Parent = pictureBox1;
            LApellido.BackColor = Color.Transparent;
            LApellido.Location = new Point(20, 60);

            LNombre.Parent = pictureBox1;
            LNombre.BackColor = Color.Transparent;
            LNombre.Location = new Point(20, 20);

            LFecha.Parent = pictureBox1;
            LFecha.BackColor = Color.Transparent;
            LFecha.Location = new Point(20, 110);

            LSexo.Parent = pictureBox1;
            LSexo.BackColor = Color.Transparent;
            LSexo.Location = new Point(20, 150);

            LSaldo.Parent = pictureBox1;
            LSaldo.BackColor = Color.Transparent;
            LSaldo.Location = new Point(20, 200);

            CMujer.Parent = pictureBox1;
            CMujer.BackColor = Color.Transparent;
            CMujer.Location = new Point(130, 160);

            CHombre.Parent = pictureBox1;
            CHombre.BackColor = Color.Transparent;
            CHombre.Location = new Point(230, 160);

            // Limpiar columnas previas
            dataGridView1.Columns.Clear();

            // Crear columnas del DataGridView
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            dataGridView1.Columns.Add("Sexo", "Sexo");

            // Columna de botón Eliminar (Punto 7)
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEliminar);

            dataGridView1.Columns.Add("Saldo", "Saldo");

            // Columna de Imagen para la Foto
            DataGridViewImageColumn colFoto = new DataGridViewImageColumn();
            colFoto.Name = "Foto";
            colFoto.HeaderText = "Foto";
            colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(colFoto);

            dataGridView1.Columns.Add("Ruta", "Ruta");

            // Formatos generales
            dataGridView1.DefaultCellStyle.ForeColor = Color.DarkGreen;
            dataGridView1.RowTemplate.Height = 45; // Opcional: da más espacio a la foto

            // Punto 6: Fuentes distintas para Apellido y Nombre
            dataGridView1.Columns["Apellido"].DefaultCellStyle.Font = new Font("Monotype Corsiva", 16, FontStyle.Italic);
            dataGridView1.Columns["Nombre"].DefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
        }

        // Punto 4: Botón para seleccionar y copiar foto
        private void BtnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.bmp;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);

                string cadena = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);
                string archivo = Path.GetFileName(openFileDialog1.FileName);
                string destination = Path.Combine(cadena, "Fotos", archivo);

                string carpetaFotos = Path.Combine(cadena, "Fotos");
                if (!Directory.Exists(carpetaFotos))
                {
                    Directory.CreateDirectory(carpetaFotos);
                }

                if (!File.Exists(destination))
                {
                    File.Copy(openFileDialog1.FileName, destination);
                }

                TxtFoto.Text = destination;
            }
        }

        // Punto 5: Mayúscula en la primera letra
        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                string texto = TxtNombre.Text.Trim().ToLower();
                TxtNombre.Text = char.ToUpper(texto[0]) + texto.Substring(1);
            }
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtApellido.Text))
            {
                string texto = TxtApellido.Text.Trim().ToLower();
                TxtApellido.Text = char.ToUpper(texto[0]) + texto.Substring(1);
            }
        }

        // Punto 7, 8, 10 y 11: Guardar registro
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Determinar sexo según CheckBox/RadioButton seleccionados
            string sexo = CHombre.Checked ? "Hombre" : (CMujer.Checked ? "Mujer" : "");

            // Cargar la imagen elegida (o null si no hay)
            Image fotoTemp = pictureBox2.Image;

            // CAPTURA EL ÍNDICE REAL DE LA FILA CREADA (devuelve 0 para la primera, 1 para la segunda, etc.)
            int indiceFila = dataGridView1.Rows.Add(
                TxtApellido.Text,
                TxtNombre.Text,
                dateTimePicker1.Value.ToShortDateString(),
                sexo,
                "Eliminar",
                textBox1.Text, // Saldo
                fotoTemp,
                TxtFoto.Text
            );

            // Usa 'indiceFila' en lugar de un número fijo como '5'
            if (decimal.TryParse(textBox1.Text, out decimal saldo))
            {
                if (saldo < 50)
                {
                    dataGridView1.Rows[indiceFila].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[indiceFila].DefaultCellStyle.ForeColor = Color.White;
                }
            }

            // PUNTO 11: Restaurar la imagen por defecto
            string rutaAvatar = Path.Combine(Application.StartupPath, "Fotos", "avatar.jpg");
            if (File.Exists(rutaAvatar))
            {
                pictureBox2.Image = Image.FromFile(rutaAvatar);
            }
            TxtFoto.Text = "";
        }

        // Punto 7 y 9: Evento para eliminar fila con confirmación
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        // Punto 10: Seleccionar RadioButton según la celda/fila clickeada en la tabla
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            object valorSexo = dataGridView1.Rows[e.RowIndex].Cells["Sexo"].Value;

            if (valorSexo != null)

            {
                string sexoSeleccionado = valorSexo.ToString();

                if (sexoSeleccionado == "Hombre")
                {
                    CHombre.Checked = true;
                }
                else if (sexoSeleccionado == "Mujer")
                {
                    CMujer.Checked = true;
                }
            }
        }
    }
}