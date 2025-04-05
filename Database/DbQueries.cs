using Microsoft.Extensions.Options;
using OtterCMSDotNet.Database;

namespace OtterCMSDotNet.Database
{
    internal class DbQueries
    {
        /*
        public void GetAllUsers()
        {
            using (var context = new DbCmsContext())
            {
                var users = context.Users.ToList();
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.ID}, Name: {user.FirstName} {user.LastName}, Email: {user.Email}");
                }
            }
        }

        public int GetUser(int id) {
            using (var context = new DbCmsContext())
            {
                var user = context.Users.FirstOrDefault(u => u.ID == id);
                if (user != null)
                {
                    Console.WriteLine($"ID: {user.ID}, Name: {user.FirstName} {user.LastName}, Email: {user.Email}");
                    return user.ID;
                }
                else
                {
                    Console.WriteLine("User not found.");
                    return 0;
                }
            }
        }

        public void GetAllPosts()
        {
            using (var context = new DbCmsContext())
            {
                var posts = context.Posts.ToList();
                foreach (var post in posts)
                {
                    Console.WriteLine($"ID: {post.ID}, Title: {post.Title}, Author: {post.Author?.FirstName} {post.Author?.LastName}, Publish Date: {post.PublishDate}");
                }
            }
        }

        public int GetPost(int id) {
            using (var context = new DbCmsContext())
            {
                var post = context.Posts.FirstOrDefault(p => p.ID == id);
                if (post != null)
                {
                    Console.WriteLine($"ID: {post.ID}, Title: {post.Title}, Author: {post.Author?.FirstName} {post.Author?.LastName}, Publish Date: {post.PublishDate}");
                    return post.ID;
                }
                else
                {
                    Console.WriteLine("Post not found.");
                    return 0;
                }
            }
        }
        */
    }
}
