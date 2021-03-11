using System;
using System.Collections.Generic;

#nullable disable

namespace HomeworkMigrationAndScaffoldingLesson
{
    public partial class Article
    {
        public Article()
        {
            ArticleAuthors = new HashSet<ArticleAuthor>();
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int? Сirculation { get; set; }
        public Guid? СategoryId { get; set; }

        public virtual Category Сategory { get; set; }
        public virtual ICollection<ArticleAuthor> ArticleAuthors { get; set; }
    }
}
