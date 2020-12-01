using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ComecandoTestes
{
    public class ServicoImpostoRenda : IServicoImpostoRenda
    {
        public async Task<decimal> ObterAliquota(decimal valor)
        {
            var tabelaJson = await File.ReadAllTextAsync("tabelaIR.json");
            var tabelaIR = JsonSerializer.Deserialize<TabelaIR>(tabelaJson, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });

            var faixa = tabelaIR.Faixas.First(x => (valor >= x.ValorInicial && valor <= x.ValorFinal) ||
                                          (valor >= x.ValorInicial && x.ValorFinal == null));
            return faixa.Aliquota;
        }
    }
}