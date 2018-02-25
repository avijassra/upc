namespace mbl.Domains {
    using System;

    public interface IEntityModel
    {
        int Id {get; set;}

        bool IsActive {get; set;}

        DateTime CreatedDateTime {get; set;}
    }
}