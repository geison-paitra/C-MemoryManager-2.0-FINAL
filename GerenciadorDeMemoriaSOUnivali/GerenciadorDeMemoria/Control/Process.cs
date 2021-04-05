using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeMemoria.Control
{
    public class Process
    {
        public int Tamanho { get; private set; }
        public int TempoVida { get; private set; }
        public int PosInicial { get; set; }
        public int PosFinal { get; set; }
        private static Random rnd = new Random();

        private int tamVidaMin;
        private int tamVidaMax;

        public Process(int tamVidaMin, int tamVidaMax, int tamMin, int tamMax)
        {
            this.tamVidaMin = tamVidaMin;
            this.tamVidaMax = tamVidaMax;
            
            Tamanho = (short)rnd.Next(tamMin, tamMax); //Processo definindo seu tamanho randomicamente 

            GeraTempoDeVIda();
        }

        public bool IsAlive()
        {
            if (TempoVida > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DecrementarTempoDeVida()
        {
            TempoVida -= 1;
        }

        /// <summary>
        /// Processo definindo seu tempo de vida randomicamente.
        /// </summary>
        private void GeraTempoDeVIda()
        {
            //A tendencia é ser curto
            TempoVida = (short)rnd.Next(tamVidaMin, tamVidaMax);
            if (TempoVida > 50) TempoVida = (short)rnd.Next(tamVidaMin, tamVidaMax);
            if (TempoVida > 60) TempoVida = (short)rnd.Next(tamVidaMin, tamVidaMax);
        }
    }
}
