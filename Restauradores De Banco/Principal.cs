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
            Pgdmp p = new(this) ;
            this.Visible = false ; 
            p.Show();
            
        }
    }
}