﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoObjectivoEstrategico
    {
        public TipoObjectivoEstrategico()
        {
            PlanoObjectivoComercial = new HashSet<PlanoObjectivoComercial>();
        }

        [StringLength(50)]
        public string IdTipoObjectivoEstrategico { get; set; }
        [Required]
        [StringLength(10)]
        public string CodTipoObjectivo { get; set; }
        [Required]
        [StringLength(50)]
        public string Designacao { get; set; }
        [Required]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoObjectivoEstrategico")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("TipoObjectivoPlano")]
        public virtual ICollection<PlanoObjectivoComercial> PlanoObjectivoComercial { get; set; }
    }
}