using Restauradores_De_Banco.Firebird;

namespace Restauradores_De_Banco
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void bt_pgdmp_Click(object sender, EventArgs e)
        {
            Pgdmp p = new(this);
            this.Visible = false ; 
            p.Show();
            
        }

        private void bt_fbk_fdb_Click(object sender, EventArgs e)
        {
            Frm_fbk_fdb f = new(this);
            this.Visible = false ;
            f.Show();
        }

        private void bt_gbk_gdb_Click(object sender, EventArgs e)
        {
            Frm_gbk_gdb f = new(this);
            this.Visible = false;
            f.Show();
        }
    }
}