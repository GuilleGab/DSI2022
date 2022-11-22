namespace Patron_Bridge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su dinero esta siendo falsificado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string divisa;
            int denominacion;
            denominacion = int.Parse(comboBox2.Text);
            divisa = comboBox1.Text;


            moneda dolar = new moneda();
            dolar.Papel = "algodon";
            dolar.Ancho = 15.5f;
            dolar.Alto = 8.6f;

            moneda peso = new moneda();
            peso.Papel = "mixto";
            peso.Ancho = 14.78f;
            peso.Alto = 9.05f;

            denominacion veinte = new denominacion();
            veinte.NumeroDenominacion = 20;

            denominacion cincuenta = new denominacion();
            cincuenta.NumeroDenominacion = 50;

            denominacion cien = new denominacion();
            cien.NumeroDenominacion = 100;

            denominacion doscientos = new denominacion();
            doscientos.NumeroDenominacion = 200;

            denominacion quinientos = new denominacion();
            quinientos.NumeroDenominacion = 500;

            denominacion mil = new denominacion();
            mil.NumeroDenominacion = 1000;


            try
            {
                if (divisa=="Dolar")
                    {
                    if (denominacion == 20)
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\20dolares.jpg");
                    }
                    if (denominacion == 50)
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\50dolares.jpg");
                    }
                    if (denominacion == 100)
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\100dolares.jpg");
                    }
                    else
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\noDisponible.jpg");
                    }
                }
                if (divisa == "Peso")
                {
                    if (denominacion == 100)
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\100pesos.jpg");
                    }
                    if (denominacion == 200)
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\200pesos.jpg");
                    }
                    if (denominacion == 500)
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\500pesos.jpg");
                    }
                    if (denominacion == 1000)
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\1000pesos.jpg");
                    }
                    else
                    {
                        string imagen = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\matit\OneDrive\Escritorio\Patron Bridge\noDisponible.jpg");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("el tipo de divisa y denominacion no es un tipo disponible");
            }
            
            if (divisa == "Dolar")
            {

                datosBillete.Text = "Tipo de Papel: " + dolar.Papel + "\nAncho de Billete: " + dolar.Ancho + "\nAlto del Billete: " + dolar.Alto;
            }
            else if (divisa == "Peso")
            {
                datosBillete.Text = "Tipo de Papel: " + peso.Papel + "\nAncho de Billete: " + peso.Ancho + "\nAlto del Billete: " + peso.Alto;
            }


        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void datosBillete_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}