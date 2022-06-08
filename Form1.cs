using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareControle
{
    public partial class Form1 : Form
    {
        double total_pedidos = 0, total_despesas = 0, saldo_empresa = 0;

        public Form1()
        {
            InitializeComponent();

            // ViewList de Pedidos
            lviPedidos.View = View.Details;
            lviPedidos.FullRowSelect = true;
            lviPedidos.GridLines = true;

            lviPedidos.Columns.Add("Nº P", 50, HorizontalAlignment.Left);
            lviPedidos.Columns.Add("Cliente", 200, HorizontalAlignment.Left);
            lviPedidos.Columns.Add("Valor", 150, HorizontalAlignment.Left);

            // ViewList de Despesas
            lviDespesas.View = View.Details;
            lviDespesas.FullRowSelect = true;
            lviDespesas.GridLines = true;

            lviDespesas.Columns.Add("Despesa", 200, HorizontalAlignment.Left);
            lviDespesas.Columns.Add("Valor", 200, HorizontalAlignment.Left);
        }

        private void btnDespesasInserir_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(inpValorDespesa.Text);

            ListViewItem itemDespesa = new ListViewItem(inpDespesa.Text);
            lviDespesas.Items.Add(itemDespesa);
            itemDespesa.SubItems.Add(inpValorDespesa.Text);

            total_despesas += valor;
            lblValorDespesas.Text = total_despesas.ToString("C");

            saldoEmpresa();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            lviPedidos.Items.Clear();
            lviDespesas.Items.Clear();
            inpCliente.Clear();
            inpPedido.Clear();
            inpValorDespesa.Clear();
            inpValorPedido.Clear();
            inpDespesa.Clear();
        }

        private void btnPedidosInserir_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(inpValorPedido.Text);

            ListViewItem itemPedido = new ListViewItem(inpPedido.Text);
            lviPedidos.Items.Add(itemPedido);
            itemPedido.SubItems.Add(inpCliente.Text);
            itemPedido.SubItems.Add(inpValorPedido.Text);

            total_pedidos += valor;
            lblValorPedidos.Text = total_pedidos.ToString("C");

            saldoEmpresa();
        }

        private void saldoEmpresa()
        {
            saldo_empresa = (total_pedidos - total_despesas);
            lblValorSaldo.Text = $"{saldo_empresa.ToString("C")}";
        }
    }
}
