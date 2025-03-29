using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types; // Make sure to include the GraphQL library for types

namespace OtterCMSDotNet.Schemas
{
    public class Post
    {
        public string? ID { get; set; } // Unique identifier for the post
        public string? Title { get; set; } // Title of the post
        public string? Content { get; set; } // Content of the post
        public User? Author { get; set; } // The author of the post, assuming User is another class defined in your system
        public DateTime PublishDate { get; set; } // Date when the post was published
        public bool IsPage { get; set; } // Indicates whether the post is a page or not
    }

    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(x => x.ID, nullable: true).Description("The unique ID of the post.");
            Field(x => x.Title, nullable: true).Description("The title of the post.");
            Field(x => x.Content, nullable: true).Description("The content of the post.");
            Field(x => x.Author, nullable: true).Description("The author of the post.") // Assuming Author is a User object, ensure you have UserType defined in your schema
                .Resolve(context =>
                {
                    // You can resolve the author here if needed, for example:
                    return context.Source.Author; // This assumes that the Post object has an Author property of type User
                });
            Field(x => x.PublishDate).Description("The date when the post was published.");
            Field(x => x.IsPage).Description("Indicates whether the post is a page or not.");
        }
    }

    public class PostQuery : ObjectGraphType
    {
        public PostQuery()
        {
            Field<PostType>("Post")
                .Resolve(context => new Post
                {
                    ID = "1", // Example ID, in a real-world application this would be fetched from a database
                    Title = "Welcome to OtterCMS", // Example title
                    Content = "This is a sample post content for OtterCMS.", // Example content
                    Author = new User(), // Example author, in a real-world application this would be fetched from a database
                    PublishDate = DateTime.Now, // Example publish date, in a real-world application this would be set to the actual publish date
                    IsPage = false // Example value for IsPage, in a real-world application this would be determined based on the post type
                });
        }
    }
}
