using Organizador_de_Pastas.Controllers;

namespace Organizador_de_Pastas
{
    public partial class F_Main : Form {
        public F_Main() {
            InitializeComponent();
        }

        private void btn_selecionar_pasta_Click(object sender, EventArgs e) {
            fbd_Bucasdor.ShowDialog();
            tb_caminho.Text = fbd_Bucasdor.SelectedPath + "\\";
        }

        private void btn_organizar_Click(object sender, EventArgs e) {
            string caminho = tb_caminho.Text;

            //Buscar por pastas para colocar os arquivos (por hora não será tão útil, mas quero dar a opção do usuário criar novas pastas, portanto essa função será util)
            //List<string> pastas = BuscaPastas.Consulta(caminho);

            //se não tiver pastas para os arquivos deverá criar
            CriaPastas.Criar(caminho);

            //Varrer os arquivos um por um e pegar suas estensões
            List<string> arquivos = BuscaArquivos.Consulta(caminho);

            //Mover os arquivos para as pastas designadas
            for (int i = 0; i < arquivos.Count; i++) {
                MoveArquivos.separar(caminho, arquivos[i]);
            }
            MessageBox.Show("Arquivos movidos");

        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            tb_caminho.Text = string.Empty;
        }
    }
}
