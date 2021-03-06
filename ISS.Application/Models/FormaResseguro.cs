﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class FormaResseguro
    {
        public FormaResseguro()
        {
            ModalidadeContratoNaoProporcional = new HashSet<ModalidadeContratoNaoProporcional>();
            ModalidadeContratoProporcional = new HashSet<ModalidadeContratoProporcional>();
            SubFormaResseguro = new HashSet<SubFormaResseguro>();
        }

        [StringLength(50)]
        public string IdFormaResseguro { get; set; }
        [StringLength(50)]
        public string Designacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string CodFormaResseguro { get; set; }
        [StringLength(50)]
        public string TipoResseguroId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("FormaResseguro")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("TipoResseguroId")]
        [InverseProperty("FormaResseguro")]
        public virtual TipoResseguro TipoResseguro { get; set; }
        [InverseProperty("FormaResseguro")]
        public virtual ICollection<ModalidadeContratoNaoProporcional> ModalidadeContratoNaoProporcional { get; set; }
        [InverseProperty("FormaResseguro")]
        public virtual ICollection<ModalidadeContratoProporcional> ModalidadeContratoProporcional { get; set; }
        [InverseProperty("FormaResseguro")]
        public virtual ICollection<SubFormaResseguro> SubFormaResseguro { get; set; }
    }
}