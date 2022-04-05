using Newtonsoft.Json;

Account account = new Account
{
    Name = "John Doe",
    Email = "john@nuget.org",
    DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
};

Console.WriteLine(account.Name);
Console.WriteLine(account.Email);
Console.WriteLine(account.DOB);

public class Account
{
    public string? Name { get; set; } // "?" indica que o campo pode ser nulo
    public string? Email { get; set; }
    public DateTime? DOB { get; set; }
}
