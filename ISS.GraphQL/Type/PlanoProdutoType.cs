using System.Linq;
using GraphQL.Types;
using ISS.Application.Models;
using ISS.Application.Helpers;
using ISS.GraphQL.ServiceExtentions;
using ISS.Application.Dto;

namespace ISS.GraphQL.Type
{
    public class PlanoProdutoType : ObjectGraphType<PlanoProduto>
    {
        public PlanoProdutoType()
        {
            // Defining the name of the object
            Name = "planoProduto";

            Field(x => x.IdPlano, nullable: true);
            Field(x => x.Designacao, nullable: true);
            Field(x => x.AmbitoPlano, nullable: true);
            Field(x => x.EstadoId, nullable: true);
            Field(x => x.LinhaProdutoId, nullable: true);
            Field(x => x.RefPlano, nullable: true);
            Field(x => x.DescricaoAmbitoGeografico, nullable: true);
            Field(x => x.CodPlanoProduto, nullable: true);
            Field(x => x.DataCriacao, nullable: true, type: typeof(DateTimeGraphType));
            Field(x => x.DataAtualizacao, nullable: true, type: typeof(DateTimeGraphType));
            Field(x => x.NumMinPessoas, nullable: true, type: typeof(IntGraphType));
            Field(x => x.NumMaxPessoas, nullable: true, type: typeof(IntGraphType));
            Field(x => x.CarregamentoSeguranca, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.CustoApolice, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.IsValorJusto, nullable: true, type: typeof(BooleanGraphType));
            Field(x => x.UltModificacaoPorId, nullable: true);
            Field(x => x.SubContaId, nullable: true);
            Field(x => x.CaminhoUrl, nullable: true);
            Field(x => x.CaminhoWeb, nullable: true);
            Field(x => x.Contabiliza, nullable: true, type: typeof(BooleanGraphType));
            Field(x => x.DataInicio, nullable: true, type: typeof(DateTimeGraphType));
            Field(x => x.DataFim, nullable: true, type: typeof(DateTimeGraphType));
            Field(x => x.Vantagem, nullable: true);
            Field(x => x.PossuiResponsabilidadeCivil, nullable: true);
            Field(x => x.PrazoAceitacao, nullable: true, type: typeof(IntGraphType));
            Field(x => x.ModalidadeReembolsoId, nullable: true);
            Field(x => x.OperacoesPagamentoId, nullable: true);
            Field(x => x.ValorAgregado, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.PrazoId, nullable: true);
            Field(x => x.IsObrigatorio, nullable: true, type: typeof(BooleanGraphType));
            Field(x => x.CaminhoImagem, nullable: true);
            Field(x => x.CaminhoIcone, nullable: true);
            Field(x => x.CobrancaMin, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.MediacaoMin, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.CorretagemMin, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.CobrancaMax, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.MediacaoMax, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.CorretagemMax, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.DescontoMinimo, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.DescontoMaximo, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.PercentagemAatribuir, nullable: true, type: typeof(FloatGraphType));
            Field(x => x.Definicao, nullable: true);
            Field(x => x.IconeDefinicao, nullable: true);
            Field(x => x.Utilidade, nullable: true);
            Field(x => x.ImagemInformacaoAdicional, nullable: true);
            Field(x => x.InformacaoAdicional, nullable: true);
            FieldAsync<EstadoType>("estado", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Estado>(c.Source.EstadoId)));
            FieldAsync<LinhaProdutoType>("linhaProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<LinhaProduto>(c.Source.LinhaProdutoId)));
            FieldAsync<ModalidadeReembolsoType>("modalidadeReembolso", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ModalidadeReembolso>(c.Source.ModalidadeReembolsoId)));
            FieldAsync<OperacoesPagamentoType>("operacoesPagamento", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<OperacoesPagamento>(c.Source.OperacoesPagamentoId)));
            FieldAsync<OpcaoType>("possuiResponsabilidadeCivilNavigation", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Opcao>(c.Source.PossuiResponsabilidadeCivil)));
            FieldAsync<PrazosCurtosType>("prazo", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PrazosCurtos>(c.Source.PrazoId)));
            FieldAsync<PlanoContasType>("subConta", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PlanoContas>(c.Source.SubContaId)));
            FieldAsync<ListGraphType<ActividadePlanoType>>("actividadePlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ActividadePlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<AgendaPlanoType>>("agendaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<AgendaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<AgravamentoPessoaType>>("agravamentoPessoa", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<AgravamentoPessoa>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<AgravamentoPlanoType>>("agravamentoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<AgravamentoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<AmbitoType>>("ambito", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Ambito>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<AmbitoPlanoType>>("ambitoPlanoNavigation", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<AmbitoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ApoliceType>>("apolice", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Apolice>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<BalcaoPlanoType>>("balcaoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<BalcaoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<BonusType>>("bonus", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Bonus>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<CaePlanoType>>("caePlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<CaePlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<CanalPlanoType>>("canalPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<CanalPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<CaraterizacaoEventualType>>("caraterizacaoEventual", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<CaraterizacaoEventual>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<CarenciaType>>("carencia", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Carencia>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<CasoClassificacaoType>>("casoClassificacao", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<CasoClassificacao>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<CoberturaPlanoType>>("coberturaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<CoberturaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ComissaoPlanoType>>("comissaoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ComissaoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ComissionamentoType>>("comissionamento", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Comissionamento>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ComissionamentoPlanoType>>("comissionamentoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ComissionamentoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ContinentePlanoType>>("continentePlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ContinentePlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ContratoPlanoType>>("contratoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ContratoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DescaraterizacaoEventualType>>("descaraterizacaoEventual", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DescaraterizacaoEventual>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DescontoType>>("desconto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Desconto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DescontoApoliceGrupoPlanoType>>("descontoApoliceGrupoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DescontoApoliceGrupoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DescontoPessoaType>>("descontoPessoa", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DescontoPessoa>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DescontoPessoaPlanoType>>("descontoPessoaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DescontoPessoaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DescontoPlanoType>>("descontoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DescontoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DescricaoBeneficioCoberturaType>>("descricaoBeneficioCobertura", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DescricaoBeneficioCobertura>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DespesaPlanoType>>("despesaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DespesaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DesvalorizacaoPlanoType>>("desvalorizacaoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DesvalorizacaoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DetalhePlanoType>>("detalhePlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DetalhePlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DocumentosObrigatorioPlanoType>>("documentosObrigatorioPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DocumentosObrigatorioPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DuracaoPremiosAcidentesPessoaisTemporarioType>>("duracaoPremiosAcidentesPessoaisTemporario", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DuracaoPremiosAcidentesPessoaisTemporario>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<DuracaoTipoContratoPlanoType>>("duracaoTipoContratoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<DuracaoTipoContratoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<EncargoPlanoType>>("encargoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<EncargoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<EnderecoPlanoType>>("enderecoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<EnderecoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<EstadoCivilPlanoType>>("estadoCivilPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<EstadoCivilPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ExcepcoesType>>("excepcoes", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Excepcoes>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ExcepcoesPlanoType>>("excepcoesPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ExcepcoesPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ExclusoesType>>("exclusoes", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Exclusoes>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ExclusoesPlanoType>>("exclusoesPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ExclusoesPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ExclusoesSelecionadaApoliceType>>("exclusoesSelecionadaApolice", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ExclusoesSelecionadaApolice>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ExclusoesSelecionadaPlanoType>>("exclusoesSelecionadaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ExclusoesSelecionadaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<FidelizacaoPlanoType>>("fidelizacaoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<FidelizacaoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<FormaContratacaoPlanoType>>("formaContratacaoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<FormaContratacaoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<FormaLiquidacaoPremioPlanoType>>("formaLiquidacaoPremioPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<FormaLiquidacaoPremioPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<FormaPagamentoPlanoType>>("formaPagamentoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<FormaPagamentoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<FraccionamentoPlanoType>>("fraccionamentoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<FraccionamentoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<GarantiaPlanoType>>("garantiaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<GarantiaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<GeneroPlanoType>>("generoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<GeneroPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<HablitacoesLiterariasPlanoType>>("hablitacoesLiterariasPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<HablitacoesLiterariasPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<HistoricoPrecarioProdutoType>>("historicoPrecarioProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<HistoricoPrecarioProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ImagemProdutoType>>("imagemProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ImagemProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ImpostoPlanoType>>("impostoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ImpostoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<LeadType>>("lead", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Lead>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<LocalAplicacaoPlanoType>>("localAplicacaoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<LocalAplicacaoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<MargemVendaProdutoType>>("margemVendaProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<MargemVendaProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<MediacaoComissaoType>>("mediacaoComissao", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<MediacaoComissao>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ModalidadeAtrasoViagemType>>("modalidadeAtrasoViagem", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ModalidadeAtrasoViagem>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<MovimentoPlanoType>>("movimentoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<MovimentoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<NacionalidadePessoaPlanoType>>("nacionalidadePessoaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<NacionalidadePessoaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ObjectivoPlanoType>>("objectivoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ObjectivoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<OfertaPlanoType>>("ofertaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<OfertaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<OperacaoType>>("operacao", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Operacao>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<OperacaoPlanoType>>("operacaoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<OperacaoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<OperacoesRecebimentoType>>("operacoesRecebimento", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<OperacoesRecebimento>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<OutrosSegurosType>>("outrosSeguros", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<OutrosSeguros>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<PaisesPlanoProdutoType>>("paisesPlanoProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PaisesPlanoProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<PapelPlanoType>>("papelPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PapelPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<PeriodoCalculoType>>("periodoCalculo", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PeriodoCalculo>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<PeriodoPlanoPlanoType>>("periodoPlanoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PeriodoPlanoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<PlanoObjectivoComercialType>>("planoObjectivoComercial", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PlanoObjectivoComercial>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<PrecarioProdutoType>>("precarioProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PrecarioProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<PressupostoAcidentePessoalType>>("pressupostoAcidentePessoal", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PressupostoAcidentePessoal>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<PrestadorServicoType>>("prestadorServico", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<PrestadorServico>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ProfissaoPlanoType>>("profissaoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ProfissaoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ProvinciaPlanoType>>("provinciaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ProvinciaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<RapelProdutorType>>("rapelProdutor", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<RapelProdutor>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<RendimentosPessoaType>>("rendimentosPessoa", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<RendimentosPessoa>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<RiscoType>>("risco", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Risco>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<RiscoPlanoProdutoType>>("riscoPlanoProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<RiscoPlanoProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<SectorActividadePlanoType>>("sectorActividadePlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<SectorActividadePlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<SegmentoProdutoType>>("segmentoProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<SegmentoProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<SegmentoProdutoPlanoType>>("segmentoProdutoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<SegmentoProdutoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ServicoPlanoType>>("servicoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ServicoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ServicosAdicionaisType>>("servicosAdicionais", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ServicosAdicionais>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<ServicosBaseType>>("servicosBase", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ServicosBase>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<SexoPlanoType>>("sexoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<SexoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<SimulacaoType>>("simulacao", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Simulacao>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<SinistroType>>("sinistro", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Sinistro>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<SubRamoType>>("subRamo", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<SubRamo>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<TarefaPlanoType>>("tarefaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<TarefaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<TarifaType>>("tarifa", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Tarifa>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<TipoEntidadePlanoType>>("tipoEntidadePlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<TipoEntidadePlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<TipoFacturacaoPlanoProdutoType>>("tipoFacturacaoPlanoProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<TipoFacturacaoPlanoProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<TipoPessoaPlanoType>>("tipoPessoaPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<TipoPessoaPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<TipoSegmentoPlanoType>>("tipoSegmentoPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<TipoSegmentoPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<TipoSociedadePlanoType>>("tipoSociedadePlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<TipoSociedadePlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<TipoTarifaPlanoProdutoType>>("tipoTarifaPlanoProduto", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<TipoTarifaPlanoProduto>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            FieldAsync<ListGraphType<VantagemPlanoType>>("vantagemPlano", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<VantagemPlano>(x => x.Where(e => e.HasValue(c.Source.IdPlano)))));
            
        }
    }

    public class PlanoProdutoInputType : InputObjectGraphType
	{
		public PlanoProdutoInputType()
		{
			// Defining the name of the object
			Name = "planoProdutoInput";
			
            //Field<StringGraphType>("idPlano");
			Field<StringGraphType>("designacao");
			Field<StringGraphType>("ambitoPlano");
			Field<StringGraphType>("estadoId");
			Field<StringGraphType>("linhaProdutoId");
			Field<StringGraphType>("refPlano");
			Field<StringGraphType>("descricaoAmbitoGeografico");
			Field<StringGraphType>("codPlanoProduto");
			Field<DateTimeGraphType>("dataCriacao");
			Field<DateTimeGraphType>("dataAtualizacao");
			Field<IntGraphType>("numMinPessoas");
			Field<IntGraphType>("numMaxPessoas");
			Field<FloatGraphType>("carregamentoSeguranca");
			Field<FloatGraphType>("custoApolice");
			Field<BooleanGraphType>("isValorJusto");
			Field<StringGraphType>("ultModificacaoPorId");
			Field<StringGraphType>("subContaId");
			Field<StringGraphType>("caminhoUrl");
			Field<StringGraphType>("caminhoWeb");
			Field<BooleanGraphType>("contabiliza");
			Field<DateTimeGraphType>("dataInicio");
			Field<DateTimeGraphType>("dataFim");
			Field<StringGraphType>("vantagem");
			Field<StringGraphType>("possuiResponsabilidadeCivil");
			Field<IntGraphType>("prazoAceitacao");
			Field<StringGraphType>("modalidadeReembolsoId");
			Field<StringGraphType>("operacoesPagamentoId");
			Field<FloatGraphType>("valorAgregado");
			Field<StringGraphType>("prazoId");
			Field<BooleanGraphType>("isObrigatorio");
			Field<StringGraphType>("caminhoImagem");
			Field<StringGraphType>("caminhoIcone");
			Field<FloatGraphType>("cobrancaMin");
			Field<FloatGraphType>("mediacaoMin");
			Field<FloatGraphType>("corretagemMin");
			Field<FloatGraphType>("cobrancaMax");
			Field<FloatGraphType>("mediacaoMax");
			Field<FloatGraphType>("corretagemMax");
			Field<FloatGraphType>("descontoMinimo");
			Field<FloatGraphType>("descontoMaximo");
			Field<FloatGraphType>("percentagemAatribuir");
			Field<StringGraphType>("definicao");
			Field<StringGraphType>("iconeDefinicao");
			Field<StringGraphType>("utilidade");
			Field<StringGraphType>("imagemInformacaoAdicional");
			Field<StringGraphType>("informacaoAdicional");
			Field<EstadoInputType>("estado");
			Field<LinhaProdutoInputType>("linhaProduto");
			Field<ModalidadeReembolsoInputType>("modalidadeReembolso");
			Field<OperacoesPagamentoInputType>("operacoesPagamento");
			Field<OpcaoInputType>("possuiResponsabilidadeCivilNavigation");
			Field<PrazosCurtosInputType>("prazo");
			Field<PlanoContasInputType>("subConta");
			Field<ListGraphType<ActividadePlanoInputType>>("actividadePlano");
			Field<ListGraphType<AgendaPlanoInputType>>("agendaPlano");
			Field<ListGraphType<AgravamentoPessoaInputType>>("agravamentoPessoa");
			Field<ListGraphType<AgravamentoPlanoInputType>>("agravamentoPlano");
			Field<ListGraphType<AmbitoInputType>>("ambito");
			Field<ListGraphType<AmbitoPlanoInputType>>("ambitoPlanoNavigation");
			Field<ListGraphType<ApoliceInputType>>("apolice");
			Field<ListGraphType<BalcaoPlanoInputType>>("balcaoPlano");
			Field<ListGraphType<BonusInputType>>("bonus");
			Field<ListGraphType<CaePlanoInputType>>("caePlano");
			Field<ListGraphType<CanalPlanoInputType>>("canalPlano");
			Field<ListGraphType<CaraterizacaoEventualInputType>>("caraterizacaoEventual");
			Field<ListGraphType<CarenciaInputType>>("carencia");
			Field<ListGraphType<CasoClassificacaoInputType>>("casoClassificacao");
			Field<ListGraphType<CoberturaPlanoInputType>>("coberturaPlano");
			Field<ListGraphType<ComissaoPlanoInputType>>("comissaoPlano");
			Field<ListGraphType<ComissionamentoInputType>>("comissionamento");
			Field<ListGraphType<ComissionamentoPlanoInputType>>("comissionamentoPlano");
			Field<ListGraphType<ContinentePlanoInputType>>("continentePlano");
			Field<ListGraphType<ContratoPlanoInputType>>("contratoPlano");
			Field<ListGraphType<DescaraterizacaoEventualInputType>>("descaraterizacaoEventual");
			Field<ListGraphType<DescontoInputType>>("desconto");
			Field<ListGraphType<DescontoApoliceGrupoPlanoInputType>>("descontoApoliceGrupoPlano");
			Field<ListGraphType<DescontoPessoaInputType>>("descontoPessoa");
			Field<ListGraphType<DescontoPessoaPlanoInputType>>("descontoPessoaPlano");
			Field<ListGraphType<DescontoPlanoInputType>>("descontoPlano");
			Field<ListGraphType<DescricaoBeneficioCoberturaInputType>>("descricaoBeneficioCobertura");
			Field<ListGraphType<DespesaPlanoInputType>>("despesaPlano");
			Field<ListGraphType<DesvalorizacaoPlanoInputType>>("desvalorizacaoPlano");
			Field<ListGraphType<DetalhePlanoInputType>>("detalhePlano");
			Field<ListGraphType<DocumentosObrigatorioPlanoInputType>>("documentosObrigatorioPlano");
			Field<ListGraphType<DuracaoPremiosAcidentesPessoaisTemporarioInputType>>("duracaoPremiosAcidentesPessoaisTemporario");
			Field<ListGraphType<DuracaoTipoContratoPlanoInputType>>("duracaoTipoContratoPlano");
			Field<ListGraphType<EncargoPlanoInputType>>("encargoPlano");
			Field<ListGraphType<EnderecoPlanoInputType>>("enderecoPlano");
			Field<ListGraphType<EstadoCivilPlanoInputType>>("estadoCivilPlano");
			Field<ListGraphType<ExcepcoesInputType>>("excepcoes");
			Field<ListGraphType<ExcepcoesPlanoInputType>>("excepcoesPlano");
			Field<ListGraphType<ExclusoesInputType>>("exclusoes");
			Field<ListGraphType<ExclusoesPlanoInputType>>("exclusoesPlano");
			Field<ListGraphType<ExclusoesSelecionadaApoliceInputType>>("exclusoesSelecionadaApolice");
			Field<ListGraphType<ExclusoesSelecionadaPlanoInputType>>("exclusoesSelecionadaPlano");
			Field<ListGraphType<FidelizacaoPlanoInputType>>("fidelizacaoPlano");
			Field<ListGraphType<FormaContratacaoPlanoInputType>>("formaContratacaoPlano");
			Field<ListGraphType<FormaLiquidacaoPremioPlanoInputType>>("formaLiquidacaoPremioPlano");
			Field<ListGraphType<FormaPagamentoPlanoInputType>>("formaPagamentoPlano");
			Field<ListGraphType<FraccionamentoPlanoInputType>>("fraccionamentoPlano");
			Field<ListGraphType<GarantiaPlanoInputType>>("garantiaPlano");
			Field<ListGraphType<GeneroPlanoInputType>>("generoPlano");
			Field<ListGraphType<HablitacoesLiterariasPlanoInputType>>("hablitacoesLiterariasPlano");
			Field<ListGraphType<HistoricoPrecarioProdutoInputType>>("historicoPrecarioProduto");
			Field<ListGraphType<ImagemProdutoInputType>>("imagemProduto");
			Field<ListGraphType<ImpostoPlanoInputType>>("impostoPlano");
			Field<ListGraphType<LeadInputType>>("lead");
			Field<ListGraphType<LocalAplicacaoPlanoInputType>>("localAplicacaoPlano");
			Field<ListGraphType<MargemVendaProdutoInputType>>("margemVendaProduto");
			Field<ListGraphType<MediacaoComissaoInputType>>("mediacaoComissao");
			Field<ListGraphType<ModalidadeAtrasoViagemInputType>>("modalidadeAtrasoViagem");
			Field<ListGraphType<MovimentoPlanoInputType>>("movimentoPlano");
			Field<ListGraphType<NacionalidadePessoaPlanoInputType>>("nacionalidadePessoaPlano");
			Field<ListGraphType<ObjectivoPlanoInputType>>("objectivoPlano");
			Field<ListGraphType<OfertaPlanoInputType>>("ofertaPlano");
			Field<ListGraphType<OperacaoInputType>>("operacao");
			Field<ListGraphType<OperacaoPlanoInputType>>("operacaoPlano");
			Field<ListGraphType<OperacoesRecebimentoInputType>>("operacoesRecebimento");
			Field<ListGraphType<OutrosSegurosInputType>>("outrosSeguros");
			Field<ListGraphType<PaisesPlanoProdutoInputType>>("paisesPlanoProduto");
			Field<ListGraphType<PapelPlanoInputType>>("papelPlano");
			Field<ListGraphType<PeriodoCalculoInputType>>("periodoCalculo");
			Field<ListGraphType<PeriodoPlanoPlanoInputType>>("periodoPlanoPlano");
			Field<ListGraphType<PlanoObjectivoComercialInputType>>("planoObjectivoComercial");
			Field<ListGraphType<PrecarioProdutoInputType>>("precarioProduto");
			Field<ListGraphType<PressupostoAcidentePessoalInputType>>("pressupostoAcidentePessoal");
			Field<ListGraphType<PrestadorServicoInputType>>("prestadorServico");
			Field<ListGraphType<ProfissaoPlanoInputType>>("profissaoPlano");
			Field<ListGraphType<ProvinciaPlanoInputType>>("provinciaPlano");
			Field<ListGraphType<RapelProdutorInputType>>("rapelProdutor");
			Field<ListGraphType<RendimentosPessoaInputType>>("rendimentosPessoa");
			Field<ListGraphType<RiscoInputType>>("risco");
			Field<ListGraphType<RiscoPlanoProdutoInputType>>("riscoPlanoProduto");
			Field<ListGraphType<SectorActividadePlanoInputType>>("sectorActividadePlano");
			Field<ListGraphType<SegmentoProdutoInputType>>("segmentoProduto");
			Field<ListGraphType<SegmentoProdutoPlanoInputType>>("segmentoProdutoPlano");
			Field<ListGraphType<ServicoPlanoInputType>>("servicoPlano");
			Field<ListGraphType<ServicosAdicionaisInputType>>("servicosAdicionais");
			Field<ListGraphType<ServicosBaseInputType>>("servicosBase");
			Field<ListGraphType<SexoPlanoInputType>>("sexoPlano");
			Field<ListGraphType<SimulacaoInputType>>("simulacao");
			Field<ListGraphType<SinistroInputType>>("sinistro");
			Field<ListGraphType<SubRamoInputType>>("subRamo");
			Field<ListGraphType<TarefaPlanoInputType>>("tarefaPlano");
			Field<ListGraphType<TarifaInputType>>("tarifa");
			Field<ListGraphType<TipoEntidadePlanoInputType>>("tipoEntidadePlano");
			Field<ListGraphType<TipoFacturacaoPlanoProdutoInputType>>("tipoFacturacaoPlanoProduto");
			Field<ListGraphType<TipoPessoaPlanoInputType>>("tipoPessoaPlano");
			Field<ListGraphType<TipoSegmentoPlanoInputType>>("tipoSegmentoPlano");
			Field<ListGraphType<TipoSociedadePlanoInputType>>("tipoSociedadePlano");
			Field<ListGraphType<TipoTarifaPlanoProdutoInputType>>("tipoTarifaPlanoProduto");
			Field<ListGraphType<VantagemPlanoInputType>>("vantagemPlano");
			
		}
	}
}