using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador_de_Pastas.Controllers {
    static internal class BuscaPastas {
        static public List<string> Consulta(string diretorio){
            List<string> listaDePastas = new List<string>();

            string[] pastas = Directory.GetDirectories(diretorio);

            foreach (string pasta in pastas) {
                listaDePastas.Add(pasta.Substring(diretorio.Length+1));
            }

            return listaDePastas;
        }
    }
}
