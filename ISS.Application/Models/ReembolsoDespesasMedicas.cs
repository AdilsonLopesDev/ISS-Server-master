﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ReembolsoDespesasMedicas
    {
        public ReembolsoDespesasMedicas()
        {
            GarantiasAfetasDespesasMedicas = new HashSet<GarantiasAfetasDespesasMedicas>();
        }

        [StringLength(50)]
        public string IdReembolsoDespesasMedicas { get; set; }
        [StringLength(50)]
        public string CodReembolsoDespesasMedicas { get; set; }
        [StringLength(50)]
        public string Empregado { get; set; }
        [StringLength(50)]
        public string ApoliceId { get; set; }
        [StringLength(50)]
        public string PessoaSegura { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("ApoliceId")]
        [InverseProperty("ReembolsoDespesasMedicas")]
        public virtual Apolice Apolice { get; set; }
        [ForeignKey("Empregado")]
        [InverseProperty("ReembolsoDespesasMedicas")]
        public virtual Funcionario EmpregadoNavigation { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("ReembolsoDespesasMedicas")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PessoaSegura")]
        [InverseProperty("ReembolsoDespesasMedicas")]
        public virtual Pessoa PessoaSeguraNavigation { get; set; }
        [InverseProperty("ReembolsoDespesasMedicasNavigation")]
        public virtual ICollection<GarantiasAfetasDespesasMedicas> GarantiasAfetasDespesasMedicas { get; set; }
    }
}