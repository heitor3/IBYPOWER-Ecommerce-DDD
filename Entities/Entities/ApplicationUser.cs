﻿using Entities.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        [Column("USR_CPF")]
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("USR_IDADE")]
        [Display(Name = "Idade")]
        public int Age { get; set; }

        [Column("USR_NOME")]
        [MaxLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("USR_CEP")]
        [MaxLength(15)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Column("USR_ENDERECO")]
        [MaxLength(255)]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Column("USR_COMPLEMENTO_ENDERECO")]
        [MaxLength(450)]
        [Display(Name = "Complemento de Endereço")]
        public string ComplementAddress { get; set; }

        [Column("USR_CELULAR")]
        [MaxLength(20)]
        [Display(Name = "Celular")]
        public string CellPhone { get; set; }

        [Column("USR_TELEFONE")]
        [MaxLength(20)]
        [Display(Name = "Telefone")]
        public string Telephone { get; set; }

        [Column("USR_ESTADO")]
        [Display(Name = "Estado")]
        public bool State { get; set; }

        [Column("USR_TIPO")]
        [Display(Name = "Tipo")]
        public TypeUser TypeUser { get; set; }
    }
}
