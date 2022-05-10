namespace TheCatsApi.DataBase.Configurations
{
    /// <summary>
    /// Interface da classe com os paremtros de configuração do BD.
    /// </summary>
    public interface IDatabaseConfig
    {
        string DatabaseName { get; set; }

        string ConnectionString { get; set; }
    }
}
