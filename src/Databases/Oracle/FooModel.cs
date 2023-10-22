using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lemure.Databases.Oracle;

public class FooModel
{
	[Key]
	[Column("ID_LIQDC")]
	public int? ID_LIQDC_Variable { get; set; }

	[Column("NUM_EMPRESA")]
	public int? NUM_EMPRESA_Variable { get; set; }

	[Column("NUM_CONTRAPARTE")]
	public int? NUM_CONTRAPARTE_Variable { get; set; }

	[Column("ID_SIT_LANC_FLUXO_CAIXA")]
	public string? ID_SIT_LANC_FLUXO_CAIXA_Variable { get; set; }

	[Column("DESCRICAO_SIT_LANC_FLUXO_CAIXA")]
	public string? DESCRICAO_SIT_LANC_FLUXO_CAIXA_Variable { get; set; }

	[Column("IND_APROVADA")]
	public string? IND_APROVADA_Variable { get; set; }

	[Column("NOME_APROVADOR")]
	public string? NOME_APROVADOR_Variable { get; set; }

	[Column("COD_HIST_LIQDC")]
	public int? COD_HIST_LIQDC_Variable { get; set; }

	[Column("DESCRICAO_HIST_LIQDC")]
	public string? DESCRICAO_HIST_LIQDC_Variable { get; set; }

	[Column("DT_LIQDC")]
	public string? DT_LIQDC_Variable { get; set; }

	[Column("IND_intEGRA_SPB")]
	public string? IND_intEGRA_SPB_Variable { get; set; }

	[Column("ID_SIT_LANC_FLUXO_CAIXA_SPB")]
	public int? ID_SIT_LANC_FLUXO_CAIXA_SPB_Variable { get; set; }

	[Column("SITUACAO_SPB")]
	public string? SITUACAO_SPB_Variable { get; set; }

	[Column("MOTIVO_DEVOLUCAO")]
	public string? MOTIVO_DEVOLUCAO_Variable { get; set; }
}
