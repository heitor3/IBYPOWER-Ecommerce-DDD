using Entities.Notifications;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("TB_PRODUTO")]
    public class Product : Notify
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PRD_NOME")]
        [Display(Name = "Nome")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column("PRD_DESCRICAO")]
        [Display(Name = "Descrição")]
        [MaxLength(150)]
        public string Description { get; set; }

        [Column("PRD_OBSERVACAO")]
        [Display(Name = "Observação")]
        [MaxLength(20000)]
        public string Note { get; set; }

        [Column("PRD_VALOR")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Column("PRD_QTD_ESTOQUE")]
        [Display(Name = "Quantidade em estoque")]
        public int StockQuantity { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Column("PRD_ESTADO")]
        [Display(Name = "Estado")]
        public bool State { get; set; }

        [Column("PRD_DATA_CADASTRO")]
        [Display(Name = "Data de Cadastro")]
        public DateTime RegistrationDate { get; set; }

        [Column("PRD_DATA_ALTERACAO")]
        [Display(Name = "Data de Atualização")]
        public DateTime UpdateDate { get; set; }

    }
}
