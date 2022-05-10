using TheCatsApi.Models;

namespace TheCatsApi.DataBase.Repositories
{
    /// <summary>
    /// Interface da classe respository.
    /// </summary>
    public interface ICatsRepository
    {
        /// <summary>
        /// Método que retorna todas as raças.
        /// </summary>
        /// <returns>Lista de todos as raças</returns>
        IEnumerable<Cats> Buscar();

        /// <summary>
        /// Método que retorna a informações do gato de acordo com a raça.
        /// </summary>
        /// <param name="name">Raça para busca</param>
        /// <returns>Informação do gato de acordo com a raça</returns>
        Cats BuscarRaca(string name);

        /// <summary>
        /// Método que retorna as informações das raças que um determinado comportamento.
        /// </summary>
        /// <param name="temperament">Comportamento para busca</param>
        /// <returns>Lista de todas as raças que possui um determinado comportamento</returns>
        IEnumerable<Cats> BuscarRacaTemperamento(string temperament);

        /// <summary>
        /// Método que retorna as informações das raças de acordo com a origem.
        /// </summary>
        /// <param name="origin">Origem para busca</param>
        /// <returns>Lista de todas as raças que possui uma determinada origem.</returns>
        IEnumerable<Cats> BuscarRacaOrigem(string origin);
    }
}
