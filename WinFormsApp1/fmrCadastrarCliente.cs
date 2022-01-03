using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class fmrCadastrarCliente : Form
    {
        public fmrCadastrarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Deseja realmente limpar os campos? ")
          //      MessageBoxButtons.OK{ }
            
            //}
            
            txtNomeCompleto.Text = "";
            txtNumero.Text = "";
            txtEndereco.Text = "";
            cboEstados.Text = "Selecione";
            dtNascimento.Text = DateTime.Now.ToString();
            //dtGridEstados.Columns.Clear();
           // dtGridEstados.Visible.fa;
            
        }

        private void fmrCadastrarCliente_Load(object sender, EventArgs e)
        {
            cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "Selecione";
            dtGridEstados.DataSource = Estado.Lista();
            /*cboEstados.Items.Clear();
            foreach (Estado estado in Estado.Lista())
            {
           
                cboEstados.Items.Add(estado);
            }
            */



        }
    }
}
