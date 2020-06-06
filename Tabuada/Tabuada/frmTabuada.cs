using System;
using System.Linq;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        //Ação do botão calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                //limpando o listbox 
                ltbResultado.Items.Clear();

                //Convertendo string para int
                int valor = Convert.ToInt32(txtValor.Text);

                for (int i = 0; i <= 10 ; i++)
                {
                    //Realizando a multiplicação
                    int resultado = valor * i;

                    // Preenchimento do listbox
                    ltbResultado.Items.Add(valor + "x" + i + "=" + resultado);
                }
            }
        }

        private bool Validar()
        {
            bool retorno = true;

            //Validação se o valor informado e númerico.
            if (string.IsNullOrEmpty(txtValor.Text) || !IsNumeric(txtValor.Text))
            {
                retorno = false;
                MessageBox.Show("Digíte um Valor Númerico.", MessageBoxIcon.Information.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Verificação se o valor e númerico
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
