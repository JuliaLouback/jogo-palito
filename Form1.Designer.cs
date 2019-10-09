namespace jogoPalito
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantPalito = new System.Windows.Forms.NumericUpDown();
            this.jogar = new System.Windows.Forms.Button();
            this.retirar = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantPalito)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 433);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha a quantidade de palitos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantos palitos deseja retirar?";
            // 
            // quantPalito
            // 
            this.quantPalito.Location = new System.Drawing.Point(262, 19);
            this.quantPalito.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.quantPalito.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.quantPalito.Name = "quantPalito";
            this.quantPalito.Size = new System.Drawing.Size(120, 20);
            this.quantPalito.TabIndex = 3;
            this.quantPalito.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // jogar
            // 
            this.jogar.Location = new System.Drawing.Point(404, 16);
            this.jogar.Name = "jogar";
            this.jogar.Size = new System.Drawing.Size(75, 23);
            this.jogar.TabIndex = 4;
            this.jogar.Text = "Jogar";
            this.jogar.UseVisualStyleBackColor = true;
            this.jogar.Click += new System.EventHandler(this.Jogar_Click);
            // 
            // retirar
            // 
            this.retirar.Location = new System.Drawing.Point(404, 55);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(75, 23);
            this.retirar.TabIndex = 6;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.Retirar_Click);
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(262, 57);
            this.valor.Mask = "0";
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(120, 20);
            this.valor.TabIndex = 7;
            this.valor.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.jogar);
            this.Controls.Add(this.quantPalito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo do Palito";
            ((System.ComponentModel.ISupportInitialize)(this.quantPalito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quantPalito;
        private System.Windows.Forms.Button jogar;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.MaskedTextBox valor;
    }
}

