using System.ComponentModel.DataAnnotations;
using Entities.Notificacoes;

namespace Entities.Entidades;

public class Base : Notifica
{
    [Display(Name = "Código")] public int Id { get; set; }

    [Display(Name = "Nome")] public string Nome { get; set; }
}