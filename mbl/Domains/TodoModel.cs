namespace mbl.Domains {
    using System.Collections.Generic;
    using MongoDB.Bson.Serialization.Attributes;

    public class TodoModel: EntityBaseModel, IEntityModel
    {
        // public TodoModel()
        // {}

        // public TodoModel(string title)
        // {
        //     this.Title = title;
        // }

        [BsonRequired]
        public string Title { get; set; }
        
        public bool IsComplete { get; set; } = false;
    }
}
