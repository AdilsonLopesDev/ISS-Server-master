﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Encargos
    {
        public Encargos()
        {
            EncargoLinha = new HashSet<EncargoLinha>();
            EncargoPlano = new HashSet<EncargoPlano>();
            EncargosTipoConta = new HashSet<EncargosTipoConta>();
        }

        [StringLength(50)]
        public string IdEncargo { get; set; }
        [StringLength(50)]
        public string TipoEncargoId { get; set; }
        [StringLength(50)]
        public string Designacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        public double? TaxaEncargo { get; set; }
        [StringLength(50)]
        public string MoedaId { get; set; }
        [StringLength(50)]
        public string CodEncargo { get; set; }
        [StringLength(50)]
        public string ImpostoPrecarioId { get; set; }
        [StringLength(50)]
        public string TipoOperacaoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("Encargos")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("ImpostoPrecarioId")]
        [InverseProperty("Encargos")]
        public virtual ImpostoPrecario ImpostoPrecario { get; set; }
        [ForeignKey("MoedaId")]
        [InverseProperty("Encargos")]
        public virtual Moeda Moeda { get; set; }
        [ForeignKey("TipoEncargoId")]
        [InverseProperty("Encargos")]
        public virtual TipoEncargo TipoEncargo { get; set; }
        [ForeignKey("TipoOperacaoId")]
        [InverseProperty("Encargos")]
        public virtual TipoOperacao TipoOperacao { get; set; }
        [InverseProperty("Encargo")]
        public virtual ICollection<EncargoLinha> EncargoLinha { get; set; }
        [InverseProperty("Encargo")]
        public virtual ICollection<EncargoPlano> EncargoPlano { get; set; }
        [InverseProperty("Encargos")]
        public virtual ICollection<EncargosTipoConta> EncargosTipoConta { get; set; }
    }
}