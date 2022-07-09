namespace ConversorTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // DECLARAR AS VARI�VEIS
          
            int TempC, TempK, TempF;

            //LER A TEMPERATURA EM CELSIUS A SER CONVERTIDA
            // AQUI TAMB�M CONVERTEMOS A STRING PARA INT
            TempC = int.Parse(txtCelsius.Text);

            //CALCULANDO AS CONVERS�ES
            TempK = TempC + 273; //KELVIN
            TempF = TempC + (((TempC * 9) / 5) + 32); //FAHRENHEIT

            /*CONVERTER O RESULTADO DO C�LCULO ACIMA (INT) PARA STRING
             DESSA FORMA EXIBIR� O RESULTADO NOS LABELS*/

            lblResultKel.Text = TempK.ToString();
            lblResultFah.Text = TempF.ToString();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}  
     