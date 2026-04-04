using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador_de_Pastas.Controllers {
    static class CriaPastas {
        public static void Criar(string caminho, string pasta) {
            Directory.CreateDirectory(caminho + pasta);
        }
        public static void Criar(string caminho) {
            List<String> pastas = new List<String>();

            pastas.Add("Documentos");
            pastas.Add("Múscias");
            pastas.Add("Fotos");
            pastas.Add("Vídeos");
            pastas.Add("Planilhas");
            pastas.Add("Pastas");
            pastas.Add("Aplicativos");
            pastas.Add("Outros Arquivos");

            foreach (string pasta in pastas) {
                Directory.CreateDirectory(caminho + pasta);
            }
        }
    }
}
