using Restauradores_De_Banco.Classes;
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
        public Powershell power = new();
        public string comando, nomeBanco, caminhoArquivo, porta, usuario, senha;

        private void bt_buscarFBD_Click(object sender, EventArgs e)
        {
            fileDialog.CheckFileExists = false;
            fileDialog.Multiselect = false; 
            fileDialog.Filter = "Arquivos FDB (*.fdb)|*.fdb";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txt_caminhoFDB.Text = caminhoArquivo;
            }
        }

        private void bt_fbkToFdb_Click(object sender, EventArgs e)
        {
            if (radio_2.Checked)
            {
                comando = @"Fire2.0\gbak ";
            }
            else if (radio_25.Checked)
            {
                comando = @"Fire2.5\gbak ";
            }
            else if (radio_3.Checked)
            {
                comando = @"Fire3.0\gbak ";
            }
            else if (radio_4.Checked)
            {
                comando = @"Fire4.0\gbak ";
            }

            comando = comando + @" -c -user sysdba -password masterkey """ + txt_caminhoFBK.Text + @""" """ + txt_caminhoFDB.Text + @"""";
            rich_resultado.Text = "Aguarde... \n \n" + comando + "\n \n";
            
            power.PowerShell(comando);

            rich_resultado.Text = rich_resultado.Text + (File.Exists(txt_caminhoFDB.Text) ? "Processo executado com sucesso! \n \n" : "Erro \n \n");

            rich_resultado.Text = rich_resultado.Text + power.mensagem;
        }

        private void Frm_fbk_fdb_Load(object sender, EventArgs e)
        {

        }

        private void bt_buscarFBK_Click(object sender, EventArgs e)
        {
            fileDialog.CheckFileExists = false;
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Arquivos FBK (*.fbk)|*.fbk";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txt_caminhoFBK.Text = caminhoArquivo;
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
