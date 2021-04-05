using GerenciadorDeMemoria.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeMemoria.View
{
    public partial class WindConfig : Form
    {
        bool firstTime;
        MemoryConfig config;
        public WindConfig(ref MemoryConfig config, bool firstTime)
        {
            InitializeComponent();
            this.firstTime = firstTime;
            this.config = config;

            txtMaxVida.Enabled = false;
            txtMemory.Enabled = false;
            txtMinVida.Enabled = false;
            trackMemory.Enabled = false;

            cmbAlocacaoMem.Items.Add("First-fit");
            cmbAlocacaoMem.Items.Add("Best-fit");
            cmbAlocacaoMem.Items.Add("Worst-fit");

            //Minimo e máximo de tamanho de mémória
            trackMemory.Minimum = 64;
            trackMemory.Maximum = 1024;

            //tamanho mínimo e máximo de vida de um processo
            trackMinProcLife.Minimum = 1;
            trackMinProcLife.Maximum = 200;
            trackMinProcLife.Minimum = 1;
            trackMaxProcLife.Maximum = 200;

            //tempo de ciclo (em milisegundos)
            cmbTempCiclo.Minimum = 10;
            cmbTempCiclo.Maximum = 2000;

            if (!firstTime)
            {

                cmbMinCiclo.Value = (int)config.TamanhoMinCiclo;
                cmbMaxCiclo.Value = config.TamanhoMaxCiclo;
                trackMemory.Value = config.TamanhoMemoria;
                trackMinProcLife.Value = config.TamanhoProcMinVida;
                trackMaxProcLife.Value = config.TamanhoProcMaxVida;
                cmbMaxProc.Value = config.TamanhoMaximoProc;
                cmbMinProc.Value = config.TamanhoMinimoProc;
                cmbTempCiclo.Value = config.TempoCiclo;
                cmbQtdProcMax.Value = config.QuantidadeMaxProc;
                cmbAlocacaoMem.SelectedIndex = config.TipoDeAlocacaoMem;
            }
            else
            {

                txtMemory.Text = trackMemory.Value.ToString() + " Bytes";// tamanho defaut
                cmbAlocacaoMem.SelectedIndex = 0;
                //quantidade mínima e máxima de ciclo
                cmbMinCiclo.Maximum = cmbMaxCiclo.Value;
                cmbMaxCiclo.Minimum = 1;
                cmbMaxCiclo.Maximum = 100;
                cmbMinCiclo.Minimum = 1;

                //tamanho mínimo e máximo de um processo 
                cmbMaxProc.Maximum = trackMemory.Value;
                cmbMinProc.Minimum = 1;


                txtMinVida.Text = "2 Ciclos"; //defaut
                txtMaxVida.Text = "100 Ciclos";//defaut

                trackMemory.Enabled = true;
                cmbMinCiclo.Value = 1;
                cmbMaxCiclo.Value = 1;
                trackMemory.Value = 64;
                trackMinProcLife.Value = 2;
                trackMaxProcLife.Value = 100;
                cmbQtdProcMax.Value = 50;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                Application.Exit();
            }
            else
            {
                Close();
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // setando as propriedades do config

            config.QuantidadeMaxProc = (int)cmbQtdProcMax.Value;
            config.TamanhoMaxCiclo = (int)cmbMaxCiclo.Value;
            config.TamanhoMaximoProc = (int)cmbMaxProc.Value;
            config.TamanhoMinCiclo = (int)cmbMinCiclo.Value;
            config.TamanhoMinimoProc = (int)cmbMinProc.Value;
            config.TamanhoMemoria = trackMemory.Value;
            config.TamanhoProcMaxVida = trackMaxProcLife.Value;
            config.TamanhoProcMinVida = trackMinProcLife.Value;
            config.TempoCiclo = (int)cmbTempCiclo.Value;

            //defindo o tipo de alocação de memória
            if (cmbAlocacaoMem.SelectedIndex == 0)
            {
                config.TipoDeAlocacaoMem = (byte)TipoDeAlocacao.FirstFit;
            }
            else if (cmbAlocacaoMem.SelectedIndex == 1)
            {
                config.TipoDeAlocacaoMem = (byte)TipoDeAlocacao.BestFit;
            }
            else if (cmbAlocacaoMem.SelectedIndex == 2)
            {
                config.TipoDeAlocacaoMem = (byte)TipoDeAlocacao.WorstFit;
            }

            MessageBox.Show("Configurações aplicadas com sucesso!", "Configurações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void trackMemory_ValueChanged(object sender, EventArgs e)
        {
            txtMemory.Text = trackMemory.Value.ToString() + " Bytes";
            cmbMaxProc.Maximum = trackMemory.Value;
        }

        private void trackMinProcLife_ValueChanged(object sender, EventArgs e)
        {
            trackMaxProcLife.Minimum = 1;
            txtMinVida.Text = trackMinProcLife.Value.ToString() + " Ciclos";
        }

        private void trackMaxProcLife_ValueChanged(object sender, EventArgs e)
        {
            txtMaxVida.Text = trackMaxProcLife.Value.ToString() + " Cliclos";
            trackMinProcLife.Maximum = trackMaxProcLife.Value;
            txtMinVida.Text = trackMinProcLife.Value.ToString() + " Ciclos";
        }

        private void cmbMaxCiclo_ValueChanged(object sender, EventArgs e)
        {
            cmbMinCiclo.Maximum = cmbMaxCiclo.Value;
        }

        private void cmbMaxProc_ValueChanged(object sender, EventArgs e)
        {
            cmbMinProc.Maximum = cmbMaxProc.Value;
        }

        private void cmbQtdProcMax_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cmbAlocacaoMem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
