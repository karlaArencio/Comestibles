using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comestibles.BE;
namespace Comestibles.FE
{
    public partial class Form1 : Form
    {
        StockComestibles Stock = new StockComestibles();
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //Instanciar
            Comestible comestible;  //defino un objeto como clase comestible
                                    //para usarla se inicializa el objeto comestible
            //Inicializar
            comestible = new Comestible();

            comestible.Nombre = txtNombre.Text;
            comestible.Codigo = txtCodigo.Text;
            comestible.Cantidad =Convert.ToDecimal(txtCantidad.Text);

            Stock.AgregarComestible(comestible);

            lblResultado.Text = Stock.Control();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
             Comestible comestible = Stock.BuscarComestible(txtCodigo.Text);
             lblResultado.Text=comestible.Control();


        }
    }
}
 