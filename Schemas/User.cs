using GraphQL.Types;

namespace OtterCMSDotNet.Schemas
{
    public class User
    {
        public enum UserRole
        {
            Admin = 1, // Highest level of access, can manage all aspects of the system
            Editor = 2, // Can create and edit content but has limited access to system settings
            Contributor = 3, // Can create content but cannot publish it; typically requires an Editor to review and publish
            Subscriber = 4 // Lowest level of access, typically can only view content and manage their own profile
        }
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Password { get; set; } // In a real-world application, this should be hashed and not directly stored
        public UserRole Role { get; set; } // UserRole enum to define the role of the user in the system

    }

    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(x => x.ID).Description("The unique ID of the user.");
            Field(x => x.FirstName, nullable: true).Description("The first name of the user.");
            Field(x => x.LastName, nullable: true).Description("The last name of the user.");
            Field(x => x.Email, nullable: true).Description("The email address of the user.");
            Field(x => x.CreateDate).Description("The date the user was created.");
            Field(x => x.Password, nullable: true).Description("The password of the user. In a real-world application, this should be hashed and not directly stored.");
            // Enum field for UserRole
            Field(x => x.Role, nullable: false)
                .Description("The role of the user in the system.")
                .Resolve(context =>
                {
                    // Return the role directly from the User object
                    return context.Source.Role;
                });
        }
    }

    public class UserQuery : ObjectGraphType
    {
        public UserQuery()
        {
            Field<UserType>("User")
                .Resolve(context => new User
                {
                    ID = 1,
                    FirstName = "Emmet",
                    LastName = "Otter",
                    Email = "Emmet.Otter@zootopia.com",
                    CreateDate = new DateTime(2025, 3, 29),
                    Password = "password123", // In a real-world application, this should be hashed and not directly stored
                    Role = User.UserRole.Admin // Example role, in a real-world application this would be determined by your user management logic
                });
        }
}
