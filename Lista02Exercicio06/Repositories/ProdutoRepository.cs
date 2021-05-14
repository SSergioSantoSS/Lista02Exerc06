using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Lista02Exercicio06.Entities;

namespace Lista02Exercicio06.Repositories
{
    class ProdutoRepository
    {
        public void ExportarDados (Produto produto)
        {
            var arquivo = $"c:\\Temp\\produto_{produto.IdProduto}.json";

            var formato = JsonConvert.SerializeObject(produto, Formatting.Indented);

            using (var streamWriter = new StreamWriter(arquivo))
            {
                streamWriter.WriteLine(formato);
            }
        }
    }
}
