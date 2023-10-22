using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lemure.Databases.Oracle;

public static class OracleTest
{
	public static async Task Execute()
	{
		var query =
			"""
			   SELECT
				liq.ID_LIQDC,
				LIQ.NUM_EMPRESA,
				LIQ.NUM_CONTRAPARTE,
				CASE
					WHEN COD_HIST_LIQDC IN (903, 904) THEN CASE
						LIQ.ID_SIT_LANC_FLUXO_CAIXA
						WHEN 'A' THEN 'L'
						ELSE LIQ.ID_SIT_LANC_FLUXO_CAIXA
					END
					ELSE LIQ.ID_SIT_LANC_FLUXO_CAIXA
				END AS ID_SIT_LANC_FLUXO_CAIXA,
				CASE
					WHEN COD_HIST_LIQDC IN (903, 904) THEN CASE
						LIQ.ID_SIT_LANC_FLUXO_CAIXA
						WHEN 'A' THEN 'LIQUIDADA'
						ELSE LIQ.DESCRICAO_SIT_LANC_FLUXO_CAIXA
					END
					ELSE LIQ.DESCRICAO_SIT_LANC_FLUXO_CAIXA
				END AS DESCRICAO_SIT_LANC_FLUXO_CAIXA,
				LIQ.IND_APROVADA,
				LIQ.NOME_APROVADOR,
				LIQ.COD_HIST_LIQDC,
				LIQ.HISTORICO_LANCAMENTO AS DESCRICAO_HIST_LIQDC,
				to_char(LIQ.DT_LIQDC, 'yyyy-mm-dd') as DT_LIQDC,
				LIQ.IND_INTEGRA_SPB,
				LIQ.ID_SIT_LANC_FLUXO_CAIXA_SPB,
				LIQ.SITUACAO_SPB,
				LIQ.MOTIVO_DEVOLUCAO
			FROM
				vts_lanc_fluxo_caixa LIQ
			WHERE
				LIQ.ID_LIQDC IN (19796109, 19799730)
			UNION
			Select
				liq.ID_LIQDC,
				liq.num_empresa,
				liq.num_contraparte,
			CASE
					WHEN liq.cod_hist_liqdc IN (903, 904) THEN CASE
						FLCX.ID_SIT_LANC_FLUXO_CAIXA
						WHEN 'A' THEN 'L'
						ELSE FLCX.ID_SIT_LANC_FLUXO_CAIXA
					END
					ELSE FLCX.ID_SIT_LANC_FLUXO_CAIXA
				END AS ID_SIT_LANC_FLUXO_CAIXA,
			CASE
					WHEN liq.COD_HIST_LIQDC IN (903, 904) THEN CASE
						FLCX.ID_SIT_LANC_FLUXO_CAIXA
						WHEN 'A' THEN 'LIQUIDADA'
						ELSE SITLC.DESCRICAO
					END
					ELSE SITLC.DESCRICAO
				END AS DESCRICAO_SIT_LANC_FLUXO_CAIXA,
				FLCX.ind_aprovada,
				liq.nome_aprovador,
				liq.cod_hist_liqdc,
				hist.descricao as DESCRICAO_HIST_LIQDC,
				to_char(LIQ.DT_LIQDC, 'yyyy-mm-dd') as DT_LIQDC,
				VLIQ.IND_INTEGRA_SPB,
				VLIQ.ID_SIT_LANC_FLUXO_CAIXA_SPB,
				VLIQ.SITUACAO_SPB,
				VLIQ.MOTIVO_DEVOLUCAO
			From
				ts_lanc_fluxo_caixa FLCX,
				ts_liqdc LIQ,
				ts_sit_lanc_fluxo_caixa SITLC,
				vts_descricao_hist_liqdc HIST,
				vts_lanc_fluxo_caixa VLIQ
			Where
				FLCX.ID_LIQDC = LIQ.ID_LIQDC
				AND FLCX.ID_SIT_LANC_FLUXO_CAIXA = sitlc.id_sit_lanc_fluxo_caixa
				AND liq.cod_hist_liqdc = hist.cod_hist_liqdc
				AND FLCX.ID_LIQDC = vliq.id_liqdc (+)
				AND FLCX.ID_LIQDC IN (19796109, 19799730);
			""";

		using (var foo = new OracleContext())
		{
			var bla = await foo.FooModels.FromSqlRaw(query).ToListAsync();
		}
	}
}
