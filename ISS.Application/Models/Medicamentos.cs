﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Medicamentos
    {
        public Medicamentos()
        {
            PrecosMedicamentos = new HashSet<PrecosMedicamentos>();
        }

        [StringLength(50)]
        public string IdMedicamento { get; set; }
        [StringLength(50)]
        public string CodigoMedicamento { get; set; }
        [Column("EAN")]
        [StringLength(50)]
        public string Ean { get; set; }
        [StringLength(50)]
        public string Descricao { get; set; }
        [StringLength(50)]
        public string FamiliaConta { get; set; }
        [StringLength(50)]
        public string PrincipioAtivo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        public int? DataEntrada { get; set; }

        [InverseProperty("IdMedicamentoNavigation")]
        public virtual ICollection<PrecosMedicamentos> PrecosMedicamentos { get; set; }
    }
}