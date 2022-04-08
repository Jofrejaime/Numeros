using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;


namespace Números
{
    public partial class nNumeros : Form
    {
        Operações op = new Operações();
        public nNumeros()
        {
            InitializeComponent();
        }

        private void nNumeros_Load(object sender, EventArgs e)
        {
            this.op.apresentar(dtgv);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
        this.op.somar(txtnum1, txtnum2, dtgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos Vazios ou argumentos não aceites", "Argumentos Errados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
            this.op.pesquisar(dtgv, txtPesquisar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não existe uma condição de pesquisa Valida", "Imposivel pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }
    }
}
