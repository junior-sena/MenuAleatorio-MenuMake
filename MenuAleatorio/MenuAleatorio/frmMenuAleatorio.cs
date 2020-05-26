using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuAleatorio
{
    public partial class frmMenuAleatorio : Form
    {
        MenuAleatorio menuAleatorio;
        public frmMenuAleatorio()
        {
            InitializeComponent();
        }


        // Método que gera menu aleatoriamente
        public void gerarMenuAleatorio()
        {
            menuAleatorio = new MenuAleatorio() { Randomizar = new Random()};
            lblSanduíche1.Text = menuAleatorio.getMenuAleatorio();
            lblSanduíche2.Text = menuAleatorio.getMenuAleatorio();
            lblSanduíche3.Text = menuAleatorio.getMenuAleatorio();
            lblSanduíche4.Text = menuAleatorio.getMenuAleatorio();
        }

        private void frmMenuAleatorio_Load(object sender, EventArgs e)
        {
            gerarMenuAleatorio();
        }

        private void btnGerarMenu_Click(object sender, EventArgs e)
        {
            gerarMenuAleatorio();
        }
    }
}
