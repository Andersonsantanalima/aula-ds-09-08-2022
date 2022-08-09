using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_ds_09_08_2022
{
    class Protudo
    {
       public string  nome;
       public int     quant;
       public double  valor;
       public double valorTotal;
        public double desconto;

      public double calcTotal()
        {
            this.valorTotal = this.valor * this.quant;
            return this.valorTotal;
        }
        public double calcdesconto()
        {
            if(this.quant >= 10)
            {
                this.desconto = this.valorTotal -(this.valorTotal *0.10);
            }
            else
            {
                 if (this.quant <=5)
                 {
                    this.desconto = this.valorTotal - (this.valorTotal * 0.05);
                }
            }

            return this.desconto;
        }
    }
}
