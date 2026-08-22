namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void TDni_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(TDni.Text, out _))
            {
                errorProvider1.SetError(TDni, "El DNI debe ser numérico");
                e.Cancel = true;
            }
            else
            {
                //errorProvider1.SetError(TDni, "");
            }
        }

        private void TNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                errorProvider1.SetError(TNombre, "El nombre es obligatorio");
                e.Cancel = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(TNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(TNombre, "El nombre solo puede contener letras");
                e.Cancel = true;
            }
            else
            {
                //errorProvider1.SetError(TNombre, "");
            }
        }

        private void TApellido_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                errorProvider1.SetError(TApellido, "El apellido es obligatorio");
                e.Cancel = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(TApellido.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(TApellido, "El apellido solo puede contener letras");
                e.Cancel = true;
            }
            else
            {
                //errorProvider1.SetError(TApellido, "");
            }
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TDni.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {

                    LModificar.Text = TApellido.Text + " " + TNombre.Text;

                    MessageBox.Show("El cliente " + TApellido.Text + " " + TNombre.Text + " se inserto correctamente");
                }

            }


        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Esta aputno de eliminar el cliente " + LModificar.Text, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El cliente " + TApellido.Text + " " + TNombre.Text + " se elimino correctamente");
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                LModificar.Text = " ";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.usuario;
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mujer;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
