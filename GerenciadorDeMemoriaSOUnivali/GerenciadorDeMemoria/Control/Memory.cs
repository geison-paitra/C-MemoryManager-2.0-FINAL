using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeMemoria.Control
{
    public class Memory
    {
        public Byte[] Memoria { get; private set; }
        public int TamanhoMem { get; private set; }
        public List<Process> listProc { get; set; }

        /// <summary>
        /// Classe que simula a memória.
        /// </summary>
        /// <param name="tamanho">Tamanho da memória</param>
        public Memory(int tamanho)
        {
            this.TamanhoMem = tamanho;
            Memoria = new byte[tamanho];
            listProc = new List<Process>();

            //Inicializando as posições da memória
            for (int i = 0; i < tamanho; i++)
            {
                Memoria[i] = new byte();
                Memoria[i] = 0;
            }
        }


        /// <summary>
        /// Procura pela primeira lacuna com tamanho suficiente.
        /// </summary>
        /// <param name="proc">Processo Atual.</param>
        public bool FirstFit(Process proc)
        {
            int contEspaco = 0; //variável que conta os espaços livres
            int tamanhoProc = proc.Tamanho;
            int? posInicial = null;

            //Buscando lacuna na memória por FirstFit
            for (int i = 0; i < TamanhoMem; i++)
            {


                if (Memoria[i] == 0)
                {
                    if (contEspaco == 0) posInicial = i;
                    contEspaco++;

                    if (contEspaco >= tamanhoProc)
                    {
                        break;
                    }
                }


                if (i < (TamanhoMem - 2)) // -2 para não pegar uma posição inexistente após a ultima posição do array
                {
                    if (Memoria[i + 1] == 1)
                    {
                        contEspaco = 0;
                        posInicial = null;
                    }
                }
            }

            if ((posInicial + (tamanhoProc - 1)) < TamanhoMem && posInicial != null) //está dentro dos limites da memória
            {
                // Definindo propriedades do processo.
                proc.PosInicial = (int)posInicial;
                proc.PosFinal = (int)posInicial + (tamanhoProc - 1);

                listProc.Add(proc); //Joga na lista de processos ativos
                AlocarMemoria(proc); //Aloca na memória
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Procura a lacuna que resultar na menor sóbra.
        /// </summary>
        /// <param name="tamanhoProc">Processo Atual.</param>
        public bool BestFit(Process proc)
        {
            int contEspaco = 0; //variável que conta os espaços livres
            int contMenorEspaco = 0;
            int tamanhoProc = proc.Tamanho;
            int? posInicial = null;
            int? melhorPosInicial = null;
            bool achouAlgum = false;
            bool primeiro = true;

            for (int i = 0; i < TamanhoMem; i++)
            {
                if (Memoria[i] == 0)
                {
                    if (contEspaco == 0) posInicial = i;
                    contEspaco++;


                    if ((i + 1) <= (TamanhoMem - 1) && ((i + 1) == 1) && contEspaco >= tamanhoProc)
                    {
                        if (contMenorEspaco > contEspaco)
                        {
                            
                            melhorPosInicial = posInicial;
                        }
                    }

                    if (contEspaco > (tamanhoProc - 1) && primeiro)
                    {
                        achouAlgum = true;
                        primeiro = false; 
                        melhorPosInicial = posInicial;
                                
                        if ((i + 1) == 1 || (i+1)>TamanhoMem-1)
                            {
                                  contMenorEspaco = contEspaco; 
                                
                            }

                    }               

                }
                else
                {
                    contEspaco = 0;
                }
            }

            if (achouAlgum)
            {
                // Definindo propriedades do processo.
                proc.PosInicial = (int)melhorPosInicial;
                proc.PosFinal = (int)melhorPosInicial + (tamanhoProc - 1);
                AlocarMemoria(proc);
                listProc.Add(proc); //Joga na lista de processos ativos
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Procura a lacuna que resultar na maior sóbra.
        /// </summary>
        /// <param name="tamanhoProc">Processo Atual.</param>
        public bool WorstFit(Process proc)
        {
            int contEspaco = 0; //variável que conta os espaços livres
            int maiorContEspaço = 0; //armazena o espaço maior
            int tamanhoProc = proc.Tamanho;
            int? posInicial = null;
            int? melhorPosInicial = null;
            bool achouAlgum = false;

            //Buscando lacuna na memória por FirstFit
            for (int i = 0; i < TamanhoMem; i++)
            {


                if (Memoria[i] == 0)
                {

                    if (contEspaco == 0) posInicial = i;
                    contEspaco++;

                    if (i == (TamanhoMem - 1))
                    {
                        if (maiorContEspaço < contEspaco && contEspaco > tamanhoProc)
                        {
                            maiorContEspaço = contEspaco;
                            contEspaco = 0;
                            melhorPosInicial = posInicial;
                            posInicial = null;
                        }

                        if ((melhorPosInicial + (tamanhoProc - 1)) < TamanhoMem)//está dentro dos limites da memória
                        {
                            achouAlgum = true;
                        }
                    }
                    else if (i < (TamanhoMem - 2))
                    {
                        if (Memoria[i + 1] == 1) //proxima for um e o atual não for a ultima posição
                        {
                            if (maiorContEspaço < contEspaco && contEspaco > tamanhoProc)
                            {
                                maiorContEspaço = contEspaco;
                                contEspaco = 0;
                                melhorPosInicial = posInicial;
                                posInicial = null;
                            }

                            if ((melhorPosInicial + (tamanhoProc - 1)) < TamanhoMem)//está dentro dos limites da memória
                            {
                                achouAlgum = true;
                            }
                            else
                            {
                                maiorContEspaço = 0;
                                melhorPosInicial = null;
                            }
                        }

                    }

                }
                else
                {
                    contEspaco = 0;
                    posInicial = null;
                }

            }


            if (achouAlgum)
            {
                // Definindo propriedades do processo.
                proc.PosInicial = (int)melhorPosInicial;
                proc.PosFinal = (int)melhorPosInicial + (tamanhoProc - 1);
                if (proc.PosFinal > TamanhoMem - 1) return false;
                AlocarMemoria(proc);
                listProc.Add(proc); //Joga na lista de processos ativos
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Faz a simulação de uma alocação de memória.
        /// </summary>
        /// <param name="proc"></param>
        private void AlocarMemoria(Process proc)
        {
            for (int i = proc.PosInicial; i <= (proc.PosFinal); i++)
            {
                Memoria[i] = 1; //Alocando a lacuna de memória escolhida 
            }
        }

        /// <summary>
        /// Recolhe o lixo de memória.
        /// </summary>
        public void GarbageCollector()
        {
            try
            {
                foreach (var item in listProc)
                {
                    if (!item.IsAlive())
                    {
                        for (int i = item.PosInicial; i <= item.PosFinal; i++)
                        {
                            Memoria[i] = 0; //limpando a memória
                        }

                        listProc.Remove(item); //Excluindo o item da lista
                    }
                }
            }
            catch (Exception)
            {
                //Lista provavelmente está vazia 
            }

        }

        /// <summary>
        /// Atualiza o tempo de vida dos processos.
        /// </summary>
        public void AtualizarProcessos()
        {
            foreach (var item in listProc)
            {
                item.DecrementarTempoDeVida();
            }
        }
    }
}
