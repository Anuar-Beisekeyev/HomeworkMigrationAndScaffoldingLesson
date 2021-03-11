using System;
using System.Collections.Generic;

#nullable disable

namespace HomeworkMigrationAndScaffoldingLesson
{
    public partial class ArticleAuthor
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? ArticleId { get; set; }
        public Guid? AuthorId { get; set; }

        public virtual Article Article { get; set; }
        public virtual Author Author { get; set; }
    }
}
