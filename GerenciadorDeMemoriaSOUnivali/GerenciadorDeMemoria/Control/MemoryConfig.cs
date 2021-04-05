namespace GerenciadorDeMemoria.Control
{
    /// <summary>
    /// Especifica o tipo de alocação de memória ultiliada.
    /// </summary>
    public enum TipoDeAlocacao
    {
        FirstFit,
        BestFit,
        WorstFit
    }

    public class MemoryConfig
    {
        /// <summary>
        /// tamamanho especifico da memória. 
        /// </summary>
        public int TamanhoMemoria { get; set; }
        /// <summary>
        /// Tamanho máximo de ciclo para gerar processos.
        /// </summary>
        public int TamanhoMaxCiclo { get; set; }
        /// <summary>
        /// Tamanho mínimo de ciclo para gerar processos.
        /// </summary>
        public int TamanhoMinCiclo { get; set; }
        /// <summary>
        /// Tempo de ciclo em milisegundos.
        /// </summary>
        public int TempoCiclo { get; set; }
        /// <summary>
        /// Quantidade máxima de processos
        /// </summary>
        public int QuantidadeMaxProc { get; set; }
        /// <summary>
        /// Tamanho mínimo de um processo.
        /// </summary>
        public int TamanhoMinimoProc { get; set; }
        /// <summary>
        /// Tamanho máximo de um processo.
        /// </summary>
        public int TamanhoMaximoProc { get; set; }
        /// <summary>
        /// Tamanho mínimo de vida de um processo.
        /// </summary>
        public int TamanhoProcMinVida { get; set; }
        /// <summary>
        /// Tamanho máximo de vida de um processo.
        /// </summary>
        public int TamanhoProcMaxVida { get; set; }
        /// <summary>
        /// Define o tipo de aloação realizada na memória.
        /// </summary>
        public byte TipoDeAlocacaoMem { get; set; }

        public MemoryConfig()
        {
            TamanhoMemoria = 0;
        }

    }
}
