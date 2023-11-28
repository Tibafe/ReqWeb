using Req231123_V1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Req231123_V1.Controllers;


[Table("Requisicoes")]
public class Requisicao
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Data Atual")]
    [DataType(DataType.Date)]
    public DateTime Data { get; set; }

    public int ProdutoId { get; set; }
    public virtual Produto Produtos { get; set; }


}
