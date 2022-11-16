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

namespace Restauradores_De_Banco.Firebird
{
    public partial class Frm_gbk_gdb : Form
    {
        public Frm_gbk_gdb()
        {
            InitializeComponent();
        }

        public Form f;
        public Powershell power = new();
        public string comando, nomeBanco, caminhoArquivo, porta, usuario, senha;

        private void Frm_gbk_gdb_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Visible = true;
        }

        public Frm_gbk_gdb(Form f_)
        {
            InitializeComponent();
            f = f_;
        }

        private void bt_buscarGBK_Click(object sender, EventArgs e)
        {
            fileDialog.CheckFileExists = false;
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Arquivos FBK (*.fbk)|*.fbk";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txt_caminhoGBK.Text = caminhoArquivo;
            }
        }

        private void bt_buscarGDB_Click(object sender, EventArgs e)
        {
            fileDialog.CheckFileExists = false;
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Arquivos FDB (*.fdb)|*.fdb";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txt_caminhoGDB.Text = caminhoArquivo;
            }
        }

        private void bt_gbkToGdb_Click(object sender, EventArgs e)
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

            comando = comando + @" -r -user SYSDBA -password masterkey """ + txt_caminhoGBK.Text + @""" """ + txt_caminhoGDB.Text + @"""";
            rich_resultado.Text = "Aguarde... \n \n" + comando + "\n \n";

            power.PowerShell(comando);

            rich_resultado.Text = rich_resultado.Text + (File.Exists(txt_caminhoGDB.Text) ? "Processo executado com sucesso! \n \n" : "Erro \n \n");

            rich_resultado.Text = rich_resultado.Text + power.mensagem;
        }
    }
}

/*

gbak -r -user SYSDBA -password masterkey "D:\Importacoes\3800 - Mercado Lider - Ecocentauro\Backup\eco.gbk" "D:\Importacoes\3800 - Mercado Lider - Ecocentauro\Backup\eco.gbd" 


*/
