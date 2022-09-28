using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauradores_De_Banco
{
    public partial class Frm_fbk_fdb : Form
    {
        public Form f;
        public string comando, nomeBanco, caminhoArquivo, porta, usuario, senha;

        private void button1_Click(object sender, EventArgs e)
        {
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txt_caminhoArquivo.Text = caminhoArquivo;
            }
        }

        public Frm_fbk_fdb(Form f_)
        {
            InitializeComponent();
            f = f_; 
        }

        private void Pgdmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Visible = true;
        }

        public void geraComando()
        {
            //usuario = "postgres";
            nomeBanco = "3834";
            caminhoArquivo = "D:\\Importacoes\\3834 - JRA Parafusos - Totall\\Backup\\arquivos\\backup\\PGSQL\\20220913\\totall_20220913 - 115201.pgdmp";
            comando = "psql -U " + usuario + "- d "+ nomeBanco + "  -f \"" + caminhoArquivo + "\"";
        }
    }
}
