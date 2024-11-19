namespace LoginProgramaPrincipal
{
    public partial class Form1 : Form
    {
        // Lista de usuarios predefinidos
        private Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "ALEJANDRA", "123a" },
            { "ISRAEL", "5678L" },
            { "MARLON", "abcd2024" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contrasena)
            {
                MessageBox.Show($"Bienvenido, {usuario}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Facturacion facturacion = new Facturacion();
                facturacion.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

