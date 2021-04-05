using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeMemoria.Control;
using GerenciadorDeMemoria.View;

namespace GerenciadorDeMemoria
{
    public partial class MainWindow : Form
    {

        //criando a memória e o processo
        Memory memory;
        WindConfig windConfig;//janela de configurações
        MemoryConfig config; // objeto de configurações
        int TamanhoMemoria = 0;
        Process proc;//processo
        int cont = 0;
        int tmpEsperaFila = 0;
        int tempoCriado = 0;
        bool firsTimeConfig = true;
        bool alocado = false;

        static Random rndCriacao; //ramdo do ciclod de criação 
        List<Label> listaLabels = new List<Label>();
        List<Process> fila = new List<Process>();

        public MainWindow()
        {
            config = new MemoryConfig();
            InitializeComponent();

            btnConfig_Click(null, null);
            firsTimeConfig = false;

            //desabilitar tudo
            btnStop.Enabled = false;
            btnClean.Enabled = false;
            txtCiclo.Enabled = false;
            txtMemory.Enabled = false;
            txtQtdProc.Enabled = false;
            txtProc.Enabled = false;

        }


        #region Métodos
        /// <summary>
        /// Delimita o tempo de criação de um processo.
        /// </summary>
        private int tempoProc()
        {
            rndCriacao = new Random();
            return rndCriacao.Next(config.TamanhoMinCiclo, config.TamanhoMaxCiclo);
        }

        public void inicializar()
        {
            //definindo o primeiro set up
            memory = new Memory(TamanhoMemoria);
        }

        /// <summary>
        /// Atualiza o flowLayoutPanel.
        /// </summary>
        private void atualizarPainelMemoria()
        {
            for (int i = 0; i < TamanhoMemoria; i++)
            {
                if (memory.Memoria[i] == 0)
                {
                    listaLabels[i].BackColor = Color.Blue;
                }
                else
                {
                    listaLabels[i].BackColor = Color.Red;
                }
            }

        }

        private void atulizarTudo()
        {
            TamanhoMemoria = config.TamanhoMemoria;
            memory = null;
            memory = new Memory(TamanhoMemoria);

            txtMemory.Text = config.TamanhoMemoria.ToString() + " Bytes";
            txtCiclo.Text = config.TempoCiclo.ToString();
            txtProc.Text = config.TamanhoMinCiclo.ToString() + "-" + config.TamanhoMaxCiclo.ToString();
            txtQtdProc.Text = memory.listProc.Count + "/" + config.QuantidadeMaxProc.ToString();

            this.Refresh();
            lblMensagem.Text = "Carregando...";

            if (firsTimeConfig)
            {
                for (int i = 0; i < TamanhoMemoria; i++)
                {

                    Panel p = new Panel();
                    p.Size = new Size(35, 15);
                    p.BackColor = Color.Blue;
                    p.Visible = true;

                    Label l = new Label();
                    //l.AutoSize = false;
                    l.AutoSize = true;
                    //l.Size = new System.Drawing.Size(35, 15);
                    l.Font = new Font("Calibre", 7f, FontStyle.Regular);
                    l.BackColor = Color.Blue;
                    l.ForeColor = Color.White;
                    l.Visible = true;
                    // l.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
                    l.Text = "0X" + (i).ToString("0000");

                    //p.Controls.Add(l);

                    //flowLayoutPanel.Controls.Add(p);
                    flowLayoutPanel.Controls.Add(l);

                    listaLabels.Add(l);
                }
            }
            lblMensagem.Text = "";
        }

        #endregion Metodos

        #region Eventos
        private void MainWindow_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //fazendo limpesa de lixo memória
            memory.GarbageCollector();
            memory.AtualizarProcessos();// atualiza o tempo de vida dos processos

            if (cont == 0) tempoCriado = tempoProc();

            int qntProc = memory.listProc.Count + fila.Count;
            txtQtdProc.Text = qntProc.ToString() + "/" + config.QuantidadeMaxProc.ToString();

            #region Criação de processo

            if ((config.QuantidadeMaxProc - 1) < qntProc)
            {
                cont = 0;
                tmpEsperaFila = 0;
            }
            if (cont >= tempoCriado) //não cria o processo se o numero de processosd atingir o especificado
            {

                //criando o processo e procurando espaço na memória
                proc = new Process(config.TamanhoProcMinVida, config.TamanhoProcMaxVida, config.TamanhoMinimoProc, config.TamanhoMaximoProc);
                if (config.TipoDeAlocacaoMem == (byte)TipoDeAlocacao.FirstFit) alocado = memory.FirstFit(proc);
                if (config.TipoDeAlocacaoMem == (byte)TipoDeAlocacao.BestFit) alocado = memory.BestFit(proc);
                if (config.TipoDeAlocacaoMem == (byte)TipoDeAlocacao.WorstFit) alocado = memory.WorstFit(proc);
                if (!alocado) fila.Add(proc);

                cont = 0;
            }
            #endregion Criação de Processo

            lblFila.Text = "Processos na Fila: " + fila.Count.ToString();
            atualizarPainelMemoria();
            cont++;
            tmpEsperaFila++;

            #region Fila
            if (tmpEsperaFila >= 2)
            {
                tmpEsperaFila = 0; // zera a cada dois ciclos

                //o primeiro da fila tenta se alocar na memória
                if (fila.Count > 1)
                {
                    proc = fila.First();
                    fila.Remove(proc);
                    if (config.TipoDeAlocacaoMem == (byte)TipoDeAlocacao.FirstFit) alocado = memory.FirstFit(proc);
                    if (config.TipoDeAlocacaoMem == (byte)TipoDeAlocacao.BestFit) alocado = memory.BestFit(proc);
                    if (config.TipoDeAlocacaoMem == (byte)TipoDeAlocacao.WorstFit) alocado = memory.WorstFit(proc);
                    if (!alocado) fila.Add(proc);
                }
            }
            #endregion Fila


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnClean.Enabled = true;
            btnStart.Text = "Continuar";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.btnStop.Enabled = true;
            btnStart.Enabled = false;
            btnClean.Enabled = false;
            btnConfig.Enabled = false;
        }

        private void btnCleam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TamanhoMemoria; i++)
            {
                memory.Memoria[i] = 0;
            }
            memory.listProc.Clear();
            fila.Clear();

            atualizarPainelMemoria();
            txtQtdProc.Text = memory.listProc.Count + "/" + config.QuantidadeMaxProc.ToString();
            lblFila.Text = "Processos na Fila: 0";

            btnClean.Enabled = false;
            btnStart.Text = "Iniciar";
            btnConfig.Enabled = true;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            windConfig = new WindConfig(ref config, firsTimeConfig);
            windConfig.ShowDialog();

            atulizarTudo();
        }

        #endregion Eventos

    }
}
