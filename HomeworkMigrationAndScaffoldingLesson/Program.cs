using System;

namespace HomeworkMigrationAndScaffoldingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new HomeworkMigrationAndScaffoldingLessonContext())
            {
                context.Add(new Author
                {
                    FullName = "Бериков.Д.Д",
                    Age = 35
                });
                context.SaveChanges();
            }
            using (var context = new HomeworkMigrationAndScaffoldingLessonContext())
            {
                context.Add(new Article
                {
                    Name = "Вулканы",
                    Publisher = "Дискавери",
                    Сirculation = 400,                    
                });
                context.SaveChanges();
            }
        }
    }
}
