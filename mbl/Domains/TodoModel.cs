namespace mbl.Domains {
    using System.Collections.Generic;

    public class TodoModel: EntityBaseModel, IEntityModel
    {
        public TodoModel()
        {}

        public TodoModel(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }
        
        public bool IsComplete { get; set; } = false;
    }
}
