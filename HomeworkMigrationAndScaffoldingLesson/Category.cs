using System;
using System.Collections.Generic;

#nullable disable

namespace HomeworkMigrationAndScaffoldingLesson
{
    public partial class Category
    {
        public Category()
        {
            Articles = new HashSet<Article>();
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
