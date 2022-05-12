using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AtividadeTabuadaCPF.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CPF.TelaCPF cpf = new CPF.TelaCPF();
            cpf.ShowDialog();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            Tabuada.TelaTabuada tabuada = new Tabuada.TelaTabuada();
            tabuada.ShowDialog();
        }
    }
}
