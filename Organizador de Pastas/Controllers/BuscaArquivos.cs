using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador_de_Pastas.Controllers {
    static internal class BuscaArquivos {
        static public List<string> Consulta(string diretorio) {
            List<string> listaDeArquivos = new List<string>();

            string[] arquivos = Directory.GetFiles(diretorio);
            foreach (string arquivo in arquivos) {
                listaDeArquivos.Add(arquivo.Substring(diretorio.Length));
            }

            return listaDeArquivos;
        }

        static public string DescobreExtensao(string arquivo) {
            return arquivo.Substring(arquivo.IndexOf("."));
        }
    }
}
