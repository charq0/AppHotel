using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.Models
{
    class Hospedagem
    {
        public Quarto quartoselecionado {get; set; }
        public int QntAdulto {  get; set; }
        public int QntCrianca {  get; set; }
        public DateTime DataCheckin {  get; set; }
        public DateTime DataCheckout { get; set; }

        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }
        public double ValorFinal
        {

            get
            {
     
                
                    double valoradulto = (QntAdulto * quartoselecionado.PrecoAdulto);
                    double valorinfantil = (QntCrianca * quartoselecionado.PrecoCrianca);

                    double valorfinall = (valoradulto + valorinfantil) * Estadia;

                    return valorfinall;
                


            }
        }

    }
}
