namespace mbl.Domains {
    using System;

    public class EntityBaseModel: IEntityModel
    {
        public int Id {get; set;}

        public bool IsActive {get; set;} = true;

        public DateTime CreatedDateTime {get; set;} = DateTime.Now;
    }
}