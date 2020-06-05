﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoContrato
    {
        public TipoContrato()
        {
            ClassificacaoContratoResseguro = new HashSet<ClassificacaoContratoResseguro>();
            Contrato = new HashSet<Contrato>();
            MediacaoComissao = new HashSet<MediacaoComissao>();
            TipoContratoEmpresa = new HashSet<TipoContratoEmpresa>();
        }

        [StringLength(50)]
        public string IdTipoContrato { get; set; }
        [StringLength(100)]
        public string Designacao { get; set; }
        [StringLength(50)]
        public string CodTipoContrato { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string TipoServicoId { get; set; }
        [StringLength(50)]
        public string CodDesignacao { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoContrato")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("TipoServicoId")]
        [InverseProperty("TipoContrato")]
        public virtual TipoServico TipoServico { get; set; }
        [InverseProperty("TipoContrato")]
        public virtual ICollection<ClassificacaoContratoResseguro> ClassificacaoContratoResseguro { get; set; }
        [InverseProperty("TipoContrato")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [InverseProperty("TipoContrato")]
        public virtual ICollection<MediacaoComissao> MediacaoComissao { get; set; }
        [InverseProperty("TipoContrato")]
        public virtual ICollection<TipoContratoEmpresa> TipoContratoEmpresa { get; set; }
    }
}