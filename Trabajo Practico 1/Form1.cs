namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Concatenar Apellido y Nombre y mostrar en el TextBox de resultado
            // textBox2 corresponde a Apellido y textBox1 a Nombre según Designer
            BResultado.Text = (textBox2.Text + " " + textBox1.Text).Trim();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Mantener el método por si el diseñador o código lo referencia en el futuro.
        // Actualmente el botón llama a button1_Click (ver Designer).
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BResultado.Text = (textBox2.Text + " " + textBox1.Text).Trim();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            BResultado.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);

        }
    }
}
