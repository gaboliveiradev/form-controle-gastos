namespace SoftwareControle
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
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.lviPedidos = new System.Windows.Forms.ListView();
            this.btnPedidosInserir = new System.Windows.Forms.Button();
            this.inpValorPedido = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.inpCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.inpPedido = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.grbDespesas = new System.Windows.Forms.GroupBox();
            this.lblTotalPedidos = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.inpDespesa = new System.Windows.Forms.TextBox();
            this.lblDespesaValor = new System.Windows.Forms.Label();
            this.inpValorDespesa = new System.Windows.Forms.TextBox();
            this.btnDespesasInserir = new System.Windows.Forms.Button();
            this.lviDespesas = new System.Windows.Forms.ListView();
            this.lblTotalDespesas = new System.Windows.Forms.Label();
            this.lblValorPedidos = new System.Windows.Forms.Label();
            this.lblValorDespesas = new System.Windows.Forms.Label();
            this.grbSaldo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorSaldo = new System.Windows.Forms.Label();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grbPedidos.SuspendLayout();
            this.grbDespesas.SuspendLayout();
            this.grbSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPedidos
            // 
            this.grbPedidos.Controls.Add(this.lblValorPedidos);
            this.grbPedidos.Controls.Add(this.lblTotalPedidos);
            this.grbPedidos.Controls.Add(this.lviPedidos);
            this.grbPedidos.Controls.Add(this.btnPedidosInserir);
            this.grbPedidos.Controls.Add(this.inpValorPedido);
            this.grbPedidos.Controls.Add(this.lblValor);
            this.grbPedidos.Controls.Add(this.inpCliente);
            this.grbPedidos.Controls.Add(this.lblCliente);
            this.grbPedidos.Controls.Add(this.inpPedido);
            this.grbPedidos.Controls.Add(this.lblPedido);
            this.grbPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPedidos.Location = new System.Drawing.Point(8, 4);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Size = new System.Drawing.Size(421, 514);
            this.grbPedidos.TabIndex = 0;
            this.grbPedidos.TabStop = false;
            this.grbPedidos.Text = "Pedidos";
            // 
            // lviPedidos
            // 
            this.lviPedidos.HideSelection = false;
            this.lviPedidos.Location = new System.Drawing.Point(9, 256);
            this.lviPedidos.Name = "lviPedidos";
            this.lviPedidos.Size = new System.Drawing.Size(405, 208);
            this.lviPedidos.TabIndex = 7;
            this.lviPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // btnPedidosInserir
            // 
            this.btnPedidosInserir.Location = new System.Drawing.Point(5, 185);
            this.btnPedidosInserir.Name = "btnPedidosInserir";
            this.btnPedidosInserir.Size = new System.Drawing.Size(410, 58);
            this.btnPedidosInserir.TabIndex = 6;
            this.btnPedidosInserir.Text = "Inserir Pedido";
            this.btnPedidosInserir.UseVisualStyleBackColor = true;
            this.btnPedidosInserir.Click += new System.EventHandler(this.btnPedidosInserir_Click);
            // 
            // inpValorPedido
            // 
            this.inpValorPedido.Location = new System.Drawing.Point(222, 81);
            this.inpValorPedido.Name = "inpValorPedido";
            this.inpValorPedido.Size = new System.Drawing.Size(193, 29);
            this.inpValorPedido.TabIndex = 5;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(218, 54);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 24);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // inpCliente
            // 
            this.inpCliente.Location = new System.Drawing.Point(4, 141);
            this.inpCliente.Name = "inpCliente";
            this.inpCliente.Size = new System.Drawing.Size(411, 29);
            this.inpCliente.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(1, 115);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 24);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // inpPedido
            // 
            this.inpPedido.Location = new System.Drawing.Point(4, 80);
            this.inpPedido.Name = "inpPedido";
            this.inpPedido.Size = new System.Drawing.Size(212, 29);
            this.inpPedido.TabIndex = 1;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(1, 54);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(96, 24);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Nº Pedido";
            // 
            // grbDespesas
            // 
            this.grbDespesas.Controls.Add(this.lblValorDespesas);
            this.grbDespesas.Controls.Add(this.lblTotalDespesas);
            this.grbDespesas.Controls.Add(this.lviDespesas);
            this.grbDespesas.Controls.Add(this.btnDespesasInserir);
            this.grbDespesas.Controls.Add(this.inpValorDespesa);
            this.grbDespesas.Controls.Add(this.lblDespesaValor);
            this.grbDespesas.Controls.Add(this.inpDespesa);
            this.grbDespesas.Controls.Add(this.lblDespesas);
            this.grbDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDespesas.Location = new System.Drawing.Point(435, 4);
            this.grbDespesas.Name = "grbDespesas";
            this.grbDespesas.Size = new System.Drawing.Size(412, 514);
            this.grbDespesas.TabIndex = 1;
            this.grbDespesas.TabStop = false;
            this.grbDespesas.Text = "Despesas";
            // 
            // lblTotalPedidos
            // 
            this.lblTotalPedidos.AutoSize = true;
            this.lblTotalPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedidos.Location = new System.Drawing.Point(6, 476);
            this.lblTotalPedidos.Name = "lblTotalPedidos";
            this.lblTotalPedidos.Size = new System.Drawing.Size(184, 24);
            this.lblTotalPedidos.TabIndex = 8;
            this.lblTotalPedidos.Text = "Total dos Pedidos:";
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Location = new System.Drawing.Point(6, 54);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(84, 24);
            this.lblDespesas.TabIndex = 9;
            this.lblDespesas.Text = "Despesa";
            // 
            // inpDespesa
            // 
            this.inpDespesa.Location = new System.Drawing.Point(6, 81);
            this.inpDespesa.Name = "inpDespesa";
            this.inpDespesa.Size = new System.Drawing.Size(400, 29);
            this.inpDespesa.TabIndex = 9;
            // 
            // lblDespesaValor
            // 
            this.lblDespesaValor.AutoSize = true;
            this.lblDespesaValor.Location = new System.Drawing.Point(6, 115);
            this.lblDespesaValor.Name = "lblDespesaValor";
            this.lblDespesaValor.Size = new System.Drawing.Size(54, 24);
            this.lblDespesaValor.TabIndex = 10;
            this.lblDespesaValor.Text = "Valor";
            // 
            // inpValorDespesa
            // 
            this.inpValorDespesa.Location = new System.Drawing.Point(6, 142);
            this.inpValorDespesa.Name = "inpValorDespesa";
            this.inpValorDespesa.Size = new System.Drawing.Size(400, 29);
            this.inpValorDespesa.TabIndex = 9;
            // 
            // btnDespesasInserir
            // 
            this.btnDespesasInserir.Location = new System.Drawing.Point(6, 185);
            this.btnDespesasInserir.Name = "btnDespesasInserir";
            this.btnDespesasInserir.Size = new System.Drawing.Size(401, 58);
            this.btnDespesasInserir.TabIndex = 9;
            this.btnDespesasInserir.Text = "Inserir Despesas";
            this.btnDespesasInserir.UseVisualStyleBackColor = true;
            this.btnDespesasInserir.Click += new System.EventHandler(this.btnDespesasInserir_Click);
            // 
            // lviDespesas
            // 
            this.lviDespesas.HideSelection = false;
            this.lviDespesas.Location = new System.Drawing.Point(6, 256);
            this.lviDespesas.Name = "lviDespesas";
            this.lviDespesas.Size = new System.Drawing.Size(400, 208);
            this.lviDespesas.TabIndex = 9;
            this.lviDespesas.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotalDespesas
            // 
            this.lblTotalDespesas.AutoSize = true;
            this.lblTotalDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDespesas.Location = new System.Drawing.Point(6, 476);
            this.lblTotalDespesas.Name = "lblTotalDespesas";
            this.lblTotalDespesas.Size = new System.Drawing.Size(171, 24);
            this.lblTotalDespesas.TabIndex = 9;
            this.lblTotalDespesas.Text = "Total dos Gastos:";
            // 
            // lblValorPedidos
            // 
            this.lblValorPedidos.AutoSize = true;
            this.lblValorPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPedidos.Location = new System.Drawing.Point(187, 471);
            this.lblValorPedidos.Name = "lblValorPedidos";
            this.lblValorPedidos.Size = new System.Drawing.Size(132, 33);
            this.lblValorPedidos.TabIndex = 9;
            this.lblValorPedidos.Text = "R$ 00,00";
            // 
            // lblValorDespesas
            // 
            this.lblValorDespesas.AutoSize = true;
            this.lblValorDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDespesas.Location = new System.Drawing.Point(186, 471);
            this.lblValorDespesas.Name = "lblValorDespesas";
            this.lblValorDespesas.Size = new System.Drawing.Size(132, 33);
            this.lblValorDespesas.TabIndex = 10;
            this.lblValorDespesas.Text = "R$ 00,00";
            // 
            // grbSaldo
            // 
            this.grbSaldo.Controls.Add(this.lblValorSaldo);
            this.grbSaldo.Controls.Add(this.label2);
            this.grbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSaldo.Location = new System.Drawing.Point(10, 527);
            this.grbSaldo.Name = "grbSaldo";
            this.grbSaldo.Size = new System.Drawing.Size(419, 91);
            this.grbSaldo.TabIndex = 2;
            this.grbSaldo.TabStop = false;
            this.grbSaldo.Text = "Saldo da Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Saldo:";
            // 
            // lblValorSaldo
            // 
            this.lblValorSaldo.AutoSize = true;
            this.lblValorSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaldo.Location = new System.Drawing.Point(112, 35);
            this.lblValorSaldo.Name = "lblValorSaldo";
            this.lblValorSaldo.Size = new System.Drawing.Size(170, 42);
            this.lblValorSaldo.TabIndex = 10;
            this.lblValorSaldo.Text = "R$ 00,00";
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoLancamento.Location = new System.Drawing.Point(437, 538);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(204, 79);
            this.btnNovoLancamento.TabIndex = 3;
            this.btnNovoLancamento.Text = "Novo Lançamento";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(647, 538);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(200, 79);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Finalizar Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 623);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.grbSaldo);
            this.Controls.Add(this.grbDespesas);
            this.Controls.Add(this.grbPedidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbPedidos.ResumeLayout(false);
            this.grbPedidos.PerformLayout();
            this.grbDespesas.ResumeLayout(false);
            this.grbDespesas.PerformLayout();
            this.grbSaldo.ResumeLayout(false);
            this.grbSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPedidos;
        private System.Windows.Forms.GroupBox grbDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lviPedidos;
        private System.Windows.Forms.Button btnPedidosInserir;
        private System.Windows.Forms.TextBox inpValorPedido;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox inpCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox inpPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblTotalPedidos;
        private System.Windows.Forms.Button btnDespesasInserir;
        private System.Windows.Forms.TextBox inpValorDespesa;
        private System.Windows.Forms.Label lblDespesaValor;
        private System.Windows.Forms.TextBox inpDespesa;
        private System.Windows.Forms.Label lblDespesas;
        private System.Windows.Forms.Label lblValorPedidos;
        private System.Windows.Forms.Label lblValorDespesas;
        private System.Windows.Forms.Label lblTotalDespesas;
        private System.Windows.Forms.ListView lviDespesas;
        private System.Windows.Forms.GroupBox grbSaldo;
        private System.Windows.Forms.Label lblValorSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.Button btnFechar;
    }
}

