﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Contratados
    {
        public Contratados()
        {
            ContratadosAssinantes = new HashSet<ContratadosAssinantes>();
        }

        [StringLength(50)]
        public string IdContratado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string CodContratado { get; set; }
        [StringLength(50)]
        public string ContratoId { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }

        [ForeignKey("ContratoId")]
        [InverseProperty("Contratados")]
        public virtual Contrato Contrato { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("Contratados")]
        public virtual Pessoa Pessoa { get; set; }
        [InverseProperty("Contratado")]
        public virtual ICollection<ContratadosAssinantes> ContratadosAssinantes { get; set; }
    }
}