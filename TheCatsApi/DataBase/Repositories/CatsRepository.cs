using MongoDB.Driver;
using TheCatsApi.DataBase.Configurations;
using TheCatsApi.Models;

namespace TheCatsApi.DataBase.Repositories
{
    /// <summary>
    /// Classe responsavel pela ações de busca realizadas com o banco de dados.
    /// </summary>
    public class CatsRepository : ICatsRepository
    {
        private readonly IMongoCollection<Cats> _cats;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="databaseConfig">Objeto contedo as configurações do banco.</param>
        public CatsRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _cats = database.GetCollection<Cats>("Cats");
        }

        /// <summary>
        /// Método que retorna todas as raças.
        /// </summary>
        /// <returns>Lista de todos as raças</returns>
        public IEnumerable<Cats> Buscar()
        {
            return _cats.Find(cat => true).ToList();
        }

        /// <summary>
        /// Método que retorna a informações do gato de acordo com a raça.
        /// </summary>
        /// <param name="name">Raça para busca</param>
        /// <returns>Informação do gato de acordo com a raça</returns>
        public Cats BuscarRaca(string name)
        {
            return _cats.Find(cat => cat.Name == name).FirstOrDefault();
        }

        /// <summary>
        /// Método que retorna as informações das raças de acordo com a origem.
        /// </summary>
        /// <param name="origin">Origem para busca</param>
        /// <returns>Lista de todas as raças que possui uma determinada origem.</returns>
        public IEnumerable<Cats> BuscarRacaOrigem(string origin)
        {
            return _cats.Find(cat => cat.Origin == origin).ToList();
        }

        /// <summary>
        /// Método que retorna as informações das raças que um determinado comportamento.
        /// </summary>
        /// <param name="temperament">Comportamento para busca</param>
        /// <returns>Lista de todas as raças que possui um determinado comportamento</returns>
        public IEnumerable<Cats> BuscarRacaTemperamento(string temperament)
        {
            var filter = Builders<Cats>.Filter.Text(temperament);
            return _cats.Find(cat => cat.Temperament.Contains(temperament)).ToList();
        }
    }
}
