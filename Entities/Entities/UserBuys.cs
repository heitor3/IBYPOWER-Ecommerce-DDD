using Entities.Entities.Enums;
using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_COMPRA_USUARIO")]
    public class UserBuys : Notify
    {
        [Column("CUS_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Produto")]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int IdProduct { get; set; }
        public virtual Product Product { get; set; }

        [Column("CUS_ESTADO")]
        [Display(Name = "Estado")]
        public BuyState State { get; set; }


        [Column("CUS_QTD")]
        [Display(Name = "Quantidade")]
        public int QuantityPurchased { get; set; }


        [Display(Name = "Usuário")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
