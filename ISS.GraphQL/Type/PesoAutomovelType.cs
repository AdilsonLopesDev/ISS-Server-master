using System.Linq;
using GraphQL.Types;
using ISS.Application.Models;
using ISS.Application.Helpers;
using ISS.GraphQL.ServiceExtentions;
using ISS.Application.Dto;

namespace ISS.GraphQL.Type
{
    public class PesoAutomovelType : ObjectGraphType<PesoAutomovel>
    {
        public PesoAutomovelType()
        {
            // Defining the name of the object
            Name = "pesoAutomovel";

            Field(x => x.IdPesoAutomovel, nullable: true);
            Field(x => x.Peso, nullable: true);
            Field(x => x.ClassificacaoAutomovelId, nullable: true);
            Field(x => x.CodPesoAutomovel, nullable: true);
            Field(x => x.DataCriacao, nullable: true, type: typeof(DateTimeGraphType));
            Field(x => x.DataAtualizacao, nullable: true, type: typeof(DateTimeGraphType));
            Field(x => x.EstadoId, nullable: true);
            FieldAsync<ClassificacaoAutomovelType>("classificacaoAutomovel", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<ClassificacaoAutomovel>(c.Source.ClassificacaoAutomovelId)));
            FieldAsync<EstadoType>("estado", resolve: async c => c.Resolve(await c.GetRepository().GetAsync<Estado>(c.Source.EstadoId)));
            
        }
    }

    public class PesoAutomovelInputType : InputObjectGraphType
	{
		public PesoAutomovelInputType()
		{
			// Defining the name of the object
			Name = "pesoAutomovelInput";
			
            //Field<StringGraphType>("idPesoAutomovel");
			Field<StringGraphType>("peso");
			Field<StringGraphType>("classificacaoAutomovelId");
			Field<StringGraphType>("codPesoAutomovel");
			Field<DateTimeGraphType>("dataCriacao");
			Field<DateTimeGraphType>("dataAtualizacao");
			Field<StringGraphType>("estadoId");
			Field<ClassificacaoAutomovelInputType>("classificacaoAutomovel");
			Field<EstadoInputType>("estado");
			
		}
	}
}