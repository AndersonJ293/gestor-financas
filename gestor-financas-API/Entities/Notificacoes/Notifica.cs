using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notificacoes;

public class Notifica
{
    [NotMapped] public string NomePropriedade { get; set; }

    [NotMapped] public string Mensagem { get; set; }

    [NotMapped] public List<Notifica> Notificacoes { get; set; } = new List<Notifica>();

    public bool ValidaPropriedadeString(string valor, string nomePropriedade)
    {
        if (!string.IsNullOrWhiteSpace(valor) && !string.IsNullOrWhiteSpace(nomePropriedade))
            return true;

        Notificacoes.Add(
            new Notifica() { Mensagem = "Campo Obrigatório", NomePropriedade = nomePropriedade }
        );
        return false;
    }

    public bool ValidaPropriedadeInt(int valor, string nomePropriedade)
    {
        if (valor >= 1 && !string.IsNullOrWhiteSpace(nomePropriedade))
            return true;

        Notificacoes.Add(
            new Notifica() { Mensagem = "Campo Obrigatório", NomePropriedade = nomePropriedade }
        );
        return false;
    }
}