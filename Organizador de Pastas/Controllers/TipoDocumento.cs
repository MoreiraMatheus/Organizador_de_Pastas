using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador_de_Pastas.Controllers {
    internal class TipoDocumento(string nome, string[] extensoes) {
        public string nome = nome;
        public string[] extensoes = extensoes;

        public bool validaExtensao(string arquivo) {
            string extensao = arquivo.Substring(arquivo.IndexOf("."));
            return extensoes.Contains(extensao);
        }
    }
}
