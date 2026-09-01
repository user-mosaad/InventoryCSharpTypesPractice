namespace RBSRetail.Users;

enum Roles
{
    Manager,
    Cashier
}

readonly struct Users
{
    // Properties
    public static int UserId { get; set; } = 0;
    public string Name { get; init; }
    public Roles Role { get; init; }
    public int PhoneNumber { get; init; }

    // Constructor
    public Users(string name, Roles role, int phoneNumber)
    {
        Name = name;
        Role = role;
        PhoneNumber = phoneNumber;

        // Increment the user's id number
        UserId++;
    }
}
