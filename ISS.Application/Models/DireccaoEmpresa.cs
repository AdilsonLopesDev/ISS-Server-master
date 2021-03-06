﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class DireccaoEmpresa
    {
        public DireccaoEmpresa()
        {
            DireccaoEmpresaDepartamento = new HashSet<DireccaoEmpresaDepartamento>();
        }

        [StringLength(50)]
        public string IdDireccaoEmpresa { get; set; }
        [StringLength(50)]
        public string DireccaoId { get; set; }
        [StringLength(50)]
        public string CodDireccaoEmpresa { get; set; }
        [StringLength(50)]
        public string EmpresaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("DireccaoId")]
        [InverseProperty("DireccaoEmpresa")]
        public virtual Direccao Direccao { get; set; }
        [ForeignKey("EmpresaId")]
        [InverseProperty("DireccaoEmpresa")]
        public virtual Empresa Empresa { get; set; }
        [InverseProperty("DireccaoEmpresa")]
        public virtual ICollection<DireccaoEmpresaDepartamento> DireccaoEmpresaDepartamento { get; set; }
    }
}