namespace mbl.Domains {
    using System;
    using MongoDB.Bson.Serialization.Attributes;

    public class EntityBaseModel: IEntityModel
    {
        [BsonId]
        public int Id {get; set;}

        public bool IsActive {get; set;} = true;

        public DateTime CreatedDateTime {get; set;} = DateTime.Now;
    }
}