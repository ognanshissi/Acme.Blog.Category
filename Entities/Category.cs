using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Acme.Blog.Category.Entities
{
    public class Category
    {
        [BsonId]
        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }
    }
}
