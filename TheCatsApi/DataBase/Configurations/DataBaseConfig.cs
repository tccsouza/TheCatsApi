namespace TheCatsApi.DataBase.Configurations
{
    /// <summary>
    /// Classe que possui os parametros de configuração do BD.
    /// </summary>
    public class DataBaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get ; set ; }
        public string ConnectionString { get ; set ; }
    }
}
