namespace Organizador_de_Pastas
{
    public partial class F_Main : Form {
        public F_Main() {
            InitializeComponent();
        }

        private void btn_selecionar_pasta_Click(object sender, EventArgs e) {
            fbd_Bucasdor.ShowDialog();
            tb_caminho.Text = fbd_Bucasdor.SelectedPath;
        }

        private void btn_organizar_Click(object sender, EventArgs e) {
            //Buscar por pastas para colocar os arquivos
            //se não tiver pastas para os arquivos deverá criar
            //Varrer os arquivos um por um e pegar suas estensões
            //Mover os arquivos para as pastas designadas 
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            tb_caminho.Text = string.Empty;
        }
    }
}
