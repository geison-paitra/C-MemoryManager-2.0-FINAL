namespace GerenciadorDeMemoria.View
{
    partial class WindConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.trackMemory = new System.Windows.Forms.TrackBar();
            this.cmbTempCiclo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMinCiclo = new System.Windows.Forms.NumericUpDown();
            this.cmbMaxCiclo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAlocacaoMem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbQtdProcMax = new System.Windows.Forms.NumericUpDown();
            this.trackMaxProcLife = new System.Windows.Forms.TrackBar();
            this.trackMinProcLife = new System.Windows.Forms.TrackBar();
            this.txtMinVida = new System.Windows.Forms.TextBox();
            this.txtMaxVida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaxProc = new System.Windows.Forms.NumericUpDown();
            this.cmbMinProc = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTempCiclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMinCiclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaxCiclo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQtdProcMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMaxProcLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMinProcLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaxProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMinProc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho de memória: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempo de cliclo (Milisegundoss):";
            // 
            // txtMemory
            // 
            this.txtMemory.Location = new System.Drawing.Point(124, 30);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.Size = new System.Drawing.Size(123, 20);
            this.txtMemory.TabIndex = 2;
            // 
            // trackMemory
            // 
            this.trackMemory.Location = new System.Drawing.Point(6, 61);
            this.trackMemory.Name = "trackMemory";
            this.trackMemory.Size = new System.Drawing.Size(241, 45);
            this.trackMemory.TabIndex = 3;
            this.trackMemory.ValueChanged += new System.EventHandler(this.trackMemory_ValueChanged);
            // 
            // cmbTempCiclo
            // 
            this.cmbTempCiclo.Location = new System.Drawing.Point(169, 122);
            this.cmbTempCiclo.Name = "cmbTempCiclo";
            this.cmbTempCiclo.Size = new System.Drawing.Size(120, 20);
            this.cmbTempCiclo.TabIndex = 4;
            this.cmbTempCiclo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade mínima de ciclo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade máxima de ciclo: ";
            // 
            // cmbMinCiclo
            // 
            this.cmbMinCiclo.Location = new System.Drawing.Point(169, 174);
            this.cmbMinCiclo.Name = "cmbMinCiclo";
            this.cmbMinCiclo.Size = new System.Drawing.Size(120, 20);
            this.cmbMinCiclo.TabIndex = 7;
            // 
            // cmbMaxCiclo
            // 
            this.cmbMaxCiclo.Location = new System.Drawing.Point(169, 148);
            this.cmbMaxCiclo.Name = "cmbMaxCiclo";
            this.cmbMaxCiclo.Size = new System.Drawing.Size(120, 20);
            this.cmbMaxCiclo.TabIndex = 8;
            this.cmbMaxCiclo.ValueChanged += new System.EventHandler(this.cmbMaxCiclo_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbAlocacaoMem);
            this.groupBox1.Controls.Add(this.trackMemory);
            this.groupBox1.Controls.Add(this.cmbMaxCiclo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMinCiclo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMemory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTempCiclo);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 277);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memória";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tipo de alocação de mémória:";
            // 
            // cmbAlocacaoMem
            // 
            this.cmbAlocacaoMem.DisplayMember = "FirstFit";
            this.cmbAlocacaoMem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlocacaoMem.FormattingEnabled = true;
            this.cmbAlocacaoMem.Location = new System.Drawing.Point(6, 235);
            this.cmbAlocacaoMem.Name = "cmbAlocacaoMem";
            this.cmbAlocacaoMem.Size = new System.Drawing.Size(199, 21);
            this.cmbAlocacaoMem.TabIndex = 9;
            this.cmbAlocacaoMem.SelectedIndexChanged += new System.EventHandler(this.cmbAlocacaoMem_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbQtdProcMax);
            this.groupBox2.Controls.Add(this.trackMaxProcLife);
            this.groupBox2.Controls.Add(this.trackMinProcLife);
            this.groupBox2.Controls.Add(this.txtMinVida);
            this.groupBox2.Controls.Add(this.txtMaxVida);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbMaxProc);
            this.groupBox2.Controls.Add(this.cmbMinProc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(324, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 275);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Quantidade máxima de processos:";
            // 
            // cmbQtdProcMax
            // 
            this.cmbQtdProcMax.Location = new System.Drawing.Point(197, 80);
            this.cmbQtdProcMax.Name = "cmbQtdProcMax";
            this.cmbQtdProcMax.Size = new System.Drawing.Size(120, 20);
            this.cmbQtdProcMax.TabIndex = 20;
            this.cmbQtdProcMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cmbQtdProcMax.ValueChanged += new System.EventHandler(this.cmbQtdProcMax_ValueChanged);
            // 
            // trackMaxProcLife
            // 
            this.trackMaxProcLife.Location = new System.Drawing.Point(41, 143);
            this.trackMaxProcLife.Name = "trackMaxProcLife";
            this.trackMaxProcLife.Size = new System.Drawing.Size(276, 45);
            this.trackMaxProcLife.TabIndex = 19;
            this.trackMaxProcLife.ValueChanged += new System.EventHandler(this.trackMaxProcLife_ValueChanged);
            // 
            // trackMinProcLife
            // 
            this.trackMinProcLife.Location = new System.Drawing.Point(41, 224);
            this.trackMinProcLife.Name = "trackMinProcLife";
            this.trackMinProcLife.Size = new System.Drawing.Size(276, 45);
            this.trackMinProcLife.TabIndex = 18;
            this.trackMinProcLife.ValueChanged += new System.EventHandler(this.trackMinProcLife_ValueChanged);
            // 
            // txtMinVida
            // 
            this.txtMinVida.Location = new System.Drawing.Point(197, 197);
            this.txtMinVida.Name = "txtMinVida";
            this.txtMinVida.Size = new System.Drawing.Size(120, 20);
            this.txtMinVida.TabIndex = 16;
            // 
            // txtMaxVida
            // 
            this.txtMaxVida.Location = new System.Drawing.Point(197, 120);
            this.txtMaxVida.Name = "txtMaxVida";
            this.txtMaxVida.Size = new System.Drawing.Size(120, 20);
            this.txtMaxVida.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tempo de vida mínimo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tamanho máximo do processo:";
            // 
            // cmbMaxProc
            // 
            this.cmbMaxProc.Location = new System.Drawing.Point(196, 26);
            this.cmbMaxProc.Name = "cmbMaxProc";
            this.cmbMaxProc.Size = new System.Drawing.Size(120, 20);
            this.cmbMaxProc.TabIndex = 12;
            this.cmbMaxProc.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cmbMaxProc.ValueChanged += new System.EventHandler(this.cmbMaxProc_ValueChanged);
            // 
            // cmbMinProc
            // 
            this.cmbMinProc.Location = new System.Drawing.Point(197, 52);
            this.cmbMinProc.Name = "cmbMinProc";
            this.cmbMinProc.Size = new System.Drawing.Size(120, 20);
            this.cmbMinProc.TabIndex = 11;
            this.cmbMinProc.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tempo de vida máximo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tamanho mínimo do processo:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(226, 332);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 30);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Aplicar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WindConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "WindConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            ((System.ComponentModel.ISupportInitialize)(this.trackMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTempCiclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMinCiclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaxCiclo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQtdProcMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMaxProcLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMinProcLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaxProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMinProc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.TrackBar trackMemory;
        private System.Windows.Forms.NumericUpDown cmbTempCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cmbMinCiclo;
        private System.Windows.Forms.NumericUpDown cmbMaxCiclo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cmbMaxProc;
        private System.Windows.Forms.NumericUpDown cmbMinProc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackMaxProcLife;
        private System.Windows.Forms.TrackBar trackMinProcLife;
        private System.Windows.Forms.TextBox txtMaxVida;
        private System.Windows.Forms.TextBox txtMinVida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown cmbQtdProcMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAlocacaoMem;
    }
}