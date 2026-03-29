using Organizador_de_Pastas.Controllers;

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
            List<string> pastas = BuscaPastas.Consulta(tb_caminho.Text);

            //se não tiver pastas para os arquivos deverá criar
                //Documentos (docx, pdf, html)
                //Músicas (mp3)
                //Fotos (jpg, jpeg, img, ico, png)
                //Vídeos (mp4)
                //Planilhas (xlsx, xls, csv)
                //Outros arquivos 

            //Varrer os arquivos um por um e pegar suas estensões

            //Mover os arquivos para as pastas designadas

        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            tb_caminho.Text = string.Empty;
        }
    }
}
