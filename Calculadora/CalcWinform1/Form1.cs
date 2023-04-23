using Calc.Core.Interfaces;
using System.Collections.Specialized;
using System.Collections;

namespace CalcWinform1
{
    public partial class Form1 : Form
    {
        private ICalc _calc;

        private List<Button> lista;

        public Form1(ICalc calc)
        {
            _calc = calc;

            _calc.Procesando += Calc_Procesando_Demo;
            _calc.Termino += Calc_Termino_Demo;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Add(1, 1);

            label1.Text = resultado.ToString();
        }

        private void Calc_Procesando_Demo(object sender, EventArgs e)
        {
            lblEstado.Text = "Procesando....";
        }

        private void Calc_Termino_Demo(object sender, EventArgs e)
        {
            lblEstado.Text = "Termino!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lblEstado.Text = $"Resize! {DateTime.Now.ToLongTimeString()}";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEstado.Text = $"MouseMove! {DateTime.Now.ToLongTimeString()}";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Se busca remover los botones usando CollectionUtil
            Hashtable botones = CollectionsUtil.CreateCaseInsensitiveHashtable();
            botones["Sumar"] = "Suma"; //Nombre: sumar Valor: Suma
            botones["Restar"] = "Resta";
            botones["Division"] = "Dividir";
            botones["Multiplicacion"] = "Multiplicar";

            var lista = new List<Button>();

            for (int i = 0; i <= 10; i++)
            {
                var b = new Button();
                b.Text = i.ToString();

                b.Location = new Point((i * 40), (i * 40));


                panelCalc.Controls.Add(b);
                lista.Add(b);
            }

            //Creación de los botones

            var bAdd = new Button();
            bAdd.Text = botones["SumAr"].ToString(); //Muestra el valor Suma

            bAdd.Location = new Point(90, 0);
            panelCalc.Controls.Add(bAdd);

            lista.Add(bAdd);

            var bResta = new Button();
            bResta.Text = botones["RESTAr"].ToString(); //Muestra el valor Resta

            bResta.Location = new Point(180, 0);
            panelCalc.Controls.Add(bResta);

            lista.Add(bResta);

            var bMulti = new Button();
            bMulti.Text = botones["MultIPlicacion"].ToString(); //Muestra el valor Multiplicar

            bMulti.Location = new Point(180, 20);
            panelCalc.Controls.Add(bMulti);

            lista.Add(bMulti);

            var bDiv = new Button();
            bDiv.Text = botones["DivISion"].ToString(); //Muestra el valor Dividir

            bDiv.Location = new Point(270, 40);
            panelCalc.Controls.Add(bDiv);

            lista.Add(bDiv);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lista.Count != 0)
            {

                lista.Remove(lista.ElementAt(0));
                panelCalc.Controls.RemoveAt(0);
            }
   

        }
    }
}
