using Microsoft.EntityFrameworkCore;

namespace Lemure.Databases.Oracle;
public class OracleContext : DbContext
{
	public DbSet<FooModel> FooModels { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString = "User Id=maxwell_sene;Password=Singulare59;Connection Timeout=320;Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = SRVH-ORAMAT-01)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = MATERAH)))";

		optionsBuilder.UseOracle(connectionString);
	}
}
