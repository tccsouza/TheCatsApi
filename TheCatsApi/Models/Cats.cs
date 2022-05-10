using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TheCatsApi.Models
{
    /// <summary>
    /// Classe que representa o modelo que faz interface com o DB.
    /// </summary>
    public class Cats
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string Origin { get; private set; }

        public string Temperament { get; private set; }

        public string Description { get; private set; }

        public string Image { get; private set; }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="name"></param>
        /// <param name="origin"></param>
        /// <param name="temperament"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        public Cats(string name, string origin, string temperament, string description, string image)
        {
            Id = ObjectId.GenerateNewId().ToString();
            Name = name;
            Origin = origin;
            Temperament = temperament;
            Description = description;
            Image = image;
        }
    }
}
