
namespace OperacaoAritmetica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.calculo = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.op_soma = new System.Windows.Forms.RadioButton();
            this.operacoes = new System.Windows.Forms.GroupBox();
            this.op_quad = new System.Windows.Forms.RadioButton();
            this.op_mult = new System.Windows.Forms.RadioButton();
            this.op_med = new System.Windows.Forms.RadioButton();
            this.op_div = new System.Windows.Forms.RadioButton();
            this.op_sub = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Sair = new System.Windows.Forms.ToolStripTextBox();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Calcular = new System.Windows.Forms.ToolStripTextBox();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sobre = new System.Windows.Forms.ToolStripTextBox();
            this.operacoes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2:";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(255, 71);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(132, 23);
            this.valor1.TabIndex = 2;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(255, 157);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(132, 23);
            this.valor2.TabIndex = 3;
            // 
            // calculo
            // 
            this.calculo.Font = new System.Drawing.Font("Arial Black", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculo.Location = new System.Drawing.Point(100, 351);
            this.calculo.Name = "calculo";
            this.calculo.Size = new System.Drawing.Size(115, 39);
            this.calculo.TabIndex = 5;
            this.calculo.Text = "Calcular";
            this.calculo.UseVisualStyleBackColor = true;
            this.calculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(100, 410);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(124, 27);
            this.resultado.TabIndex = 6;
            this.resultado.Text = "Resultado:";
            // 
            // op_soma
            // 
            this.op_soma.AutoSize = true;
            this.op_soma.Location = new System.Drawing.Point(6, 32);
            this.op_soma.Name = "op_soma";
            this.op_soma.Size = new System.Drawing.Size(59, 19);
            this.op_soma.TabIndex = 7;
            this.op_soma.Text = "Somar";
            this.op_soma.UseVisualStyleBackColor = true;
            // 
            // operacoes
            // 
            this.operacoes.Controls.Add(this.op_quad);
            this.operacoes.Controls.Add(this.op_mult);
            this.operacoes.Controls.Add(this.op_med);
            this.operacoes.Controls.Add(this.op_soma);
            this.operacoes.Controls.Add(this.op_div);
            this.operacoes.Controls.Add(this.op_sub);
            this.operacoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.operacoes.Location = new System.Drawing.Point(100, 201);
            this.operacoes.Name = "operacoes";
            this.operacoes.Size = new System.Drawing.Size(301, 128);
            this.operacoes.TabIndex = 8;
            this.operacoes.TabStop = false;
            this.operacoes.Text = "Seleciona operação desejada:";
            this.operacoes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // op_quad
            // 
            this.op_quad.AutoSize = true;
            this.op_quad.Location = new System.Drawing.Point(200, 57);
            this.op_quad.Name = "op_quad";
            this.op_quad.Size = new System.Drawing.Size(78, 19);
            this.op_quad.TabIndex = 13;
            this.op_quad.Text = "Quadrado";
            this.op_quad.UseVisualStyleBackColor = true;
            // 
            // op_mult
            // 
            this.op_mult.AutoSize = true;
            this.op_mult.Location = new System.Drawing.Point(6, 78);
            this.op_mult.Name = "op_mult";
            this.op_mult.Size = new System.Drawing.Size(82, 19);
            this.op_mult.TabIndex = 10;
            this.op_mult.Text = "Multiplicar";
            this.op_mult.UseVisualStyleBackColor = true;
            this.op_mult.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // op_med
            // 
            this.op_med.AutoSize = true;
            this.op_med.Location = new System.Drawing.Point(200, 32);
            this.op_med.Name = "op_med";
            this.op_med.Size = new System.Drawing.Size(58, 19);
            this.op_med.TabIndex = 12;
            this.op_med.Text = "Média";
            this.op_med.UseVisualStyleBackColor = true;
            this.op_med.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // op_div
            // 
            this.op_div.AutoSize = true;
            this.op_div.Location = new System.Drawing.Point(6, 103);
            this.op_div.Name = "op_div";
            this.op_div.Size = new System.Drawing.Size(59, 19);
            this.op_div.TabIndex = 11;
            this.op_div.Text = "Dividir";
            this.op_div.UseVisualStyleBackColor = true;
            this.op_div.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // op_sub
            // 
            this.op_sub.AutoSize = true;
            this.op_sub.Location = new System.Drawing.Point(6, 57);
            this.op_sub.Name = "op_sub";
            this.op_sub.Size = new System.Drawing.Size(66, 19);
            this.op_sub.TabIndex = 9;
            this.op_sub.Text = "Subtrair";
            this.op_sub.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arquivo,
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Arquivo
            // 
            this.Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sair});
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Arquivo.Text = "Arquivo";
            // 
            // Sair
            // 
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(100, 23);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Calcular});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // Calcular
            // 
            this.Calcular.Name = "Calcular";
            this.Calcular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calcular.Size = new System.Drawing.Size(100, 23);
            this.Calcular.Text = "Calcular";
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // Sobre
            // 
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(100, 23);
            this.Sobre.Text = "Sobre";
            this.Sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.operacoes);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.calculo);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular operação aritmética com dois valores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.operacoes.ResumeLayout(false);
            this.operacoes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Button calculo;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.RadioButton op_soma;
        private System.Windows.Forms.GroupBox operacoes;
        private System.Windows.Forms.RadioButton op_sub;
        private System.Windows.Forms.RadioButton op_mult;
        private System.Windows.Forms.RadioButton op_div;
        private System.Windows.Forms.RadioButton op_med;
        private System.Windows.Forms.RadioButton op_quad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Arquivo;
        private System.Windows.Forms.ToolStripTextBox Sair;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Calcular;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Sobre;
    }
}

