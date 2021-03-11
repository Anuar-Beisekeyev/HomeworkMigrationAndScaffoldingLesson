using System;
using System.Collections.Generic;

#nullable disable

namespace HomeworkMigrationAndScaffoldingLesson
{
    public partial class Author
    {
        public Author()
        {
            ArticleAuthors = new HashSet<ArticleAuthor>();
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public int Age { get; set; }
        public virtual ICollection<ArticleAuthor> ArticleAuthors { get; set; }
    }
}
