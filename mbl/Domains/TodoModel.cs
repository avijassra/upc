namespace mbl.Domains {
    using System.Collections.Generic;
    using MongoDB.Bson.Serialization.Attributes;

    public class TodoModel: EntityBaseModel, IEntityModel
    {
        [BsonRequired]
        public string Title { get; set; }
        
        public bool IsComplete { get; set; } = false;
    }
}
