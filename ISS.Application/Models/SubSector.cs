﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class SubSector
    {
        public SubSector()
        {
            SectorActividade = new HashSet<SectorActividade>();
        }

        [StringLength(50)]
        public string IdSubSector { get; set; }
        [StringLength(50)]
        public string Designacao { get; set; }
        [StringLength(50)]
        public string CaiId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string CodSubSector { get; set; }

        [ForeignKey("CaiId")]
        [InverseProperty("SubSector")]
        public virtual Cae Cai { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("SubSector")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("SubSector")]
        public virtual ICollection<SectorActividade> SectorActividade { get; set; }
    }
}