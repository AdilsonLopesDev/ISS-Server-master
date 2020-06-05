﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ResponsavelBalcao
    {
        [StringLength(50)]
        public string IdResponsavelBalcao { get; set; }
        [Column("ResponsavelID")]
        [StringLength(50)]
        public string ResponsavelId { get; set; }
        [Column("BalcaoID")]
        [StringLength(50)]
        public string BalcaoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("BalcaoId")]
        [InverseProperty("ResponsavelBalcao")]
        public virtual Balcao Balcao { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("ResponsavelBalcao")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("ResponsavelId")]
        [InverseProperty("ResponsavelBalcao")]
        public virtual Funcionario Responsavel { get; set; }
    }
}