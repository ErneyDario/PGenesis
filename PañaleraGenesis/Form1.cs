namespace PañaleraGenesis
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e) 
        {   String usuario, contrasena;

            usuario= txtusuario.Text;
            contrasena=txtcontrasena.Text;

            if (usuario == "usuarioc#" && contrasena == "123")
            {
                Frminicio principal= new Frminicio();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("los datos ingresados son incorrectos intentelo de nuevo");
            }    
                
        
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtcontrasena.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿segur(a) que desea salir del sistema?",
                    "consulta",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit();

            }



        }
    }
}