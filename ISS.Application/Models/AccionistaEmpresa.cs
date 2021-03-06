﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class AccionistaEmpresa
    {
        [StringLength(50)]
        public string IdAccionistaEmpresa { get; set; }
        public double? ValorCota { get; set; }
        [Column("AccionistaID")]
        [StringLength(50)]
        public string AccionistaId { get; set; }
        [Column("EmpresaID")]
        [StringLength(50)]
        public string EmpresaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("AccionistaId")]
        [InverseProperty("AccionistaEmpresaAccionista")]
        public virtual Pessoa Accionista { get; set; }
        [ForeignKey("EmpresaId")]
        [InverseProperty("AccionistaEmpresaEmpresa")]
        public virtual Pessoa Empresa { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("AccionistaEmpresa")]
        public virtual Estado Estado { get; set; }
    }
}