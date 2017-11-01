using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bazy2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (var db = new BlogContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a title and content for a new Post: ");
                var title = Console.ReadLine();
                var content = Console.ReadLine();

                var post = new Post { Title= title,Content=content,BlogId=1};
                db.Posts.Add(post);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from p in db.Posts
                            orderby p.Title
                            select p;

                Console.WriteLine("All posts in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Title);
                    Console.WriteLine(item.Content);
                    Console.WriteLine("________________");
                }

                Console.WriteLine("Press any key to exit...");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new BlogForm());
                //Console.ReadKey();
            }
        }
    }
}
