using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_CalculoDeComissao
{
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
        }

        public void ativarBotao() // Criei um método sem parâmetro e sem retorno
        {
            btnCalcularComissao.Enabled = true; // Quando chamado o método o botão é ativado
        }

        private void BtnCalcularComissao_Click(object sender, EventArgs e)
        {
            cl_Comissao comissao = new cl_Comissao(); // Chama-se a classe e se atribui o nome comissao nesse formulário

            double ValorDeVenda = double.Parse(txtValorVenda.Text); // Declaro a variável ValorDeVenda que puxa um valor do textBox
            double CategoriaVendedor; // É criada uma variável para receber a categoria do vendedor

            if (rdbCategoriaA.Checked) // Estrutura condicional basica para atribuir o valor de uma variável conforme o radioButton selecionado
            {
                CategoriaVendedor = 0;
                ativarBotao(); // Chama-se o método acima declarado.
            }
            else if (rdbCategoriaB.Checked)
            {
                CategoriaVendedor = 1;
                ativarBotao();
            }
            else
            {
                CategoriaVendedor = 2;
                ativarBotao();
            }

            double valorComissao = comissao.CalcularComissao(ValorDeVenda, CategoriaVendedor); // Declara-se uma variável valorComissao e logo após chama-se o método inserindo os atributos
            txtValorComissao.Text = valorComissao.ToString("C"); // Declara o valor transformando-o em moeda.
        }

        private void TxtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Caso seja digitado letras ou caractéres especiais não seriam aceitos
            }
        }
    }
}
