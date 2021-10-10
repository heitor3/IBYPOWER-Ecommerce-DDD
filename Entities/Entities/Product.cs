using Entities.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Product")]
    public class Product : Notify
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PRD_NOME")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("PRD_VALOR")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Column("PRD_ESTADO")]
        [Display(Name = "Estado")]
        public bool State { get; set; }
    }
}
