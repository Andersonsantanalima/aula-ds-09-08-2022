using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_ds_09_08_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            Protudo p = new Protudo();

            p.nome = txtNome.Text;
            p.quant = Convert.ToInt32(txtQuant.Text);
            p.valor = Convert.ToDouble(txtValor.Text);

            p.calcTotal();
            txtResltadoNome.Text = p.nome.ToString();
            txtResltadoEstoque.Text =p.quant.ToString();
            txtResltadoValor.Text = p.valor.ToString();
            txtResltadoTotal.Text = p.valorTotal.ToString();

            p.calcdesconto();
            txtResltadoDesconto.Text = p.desconto.ToString();
        }
    }
}
