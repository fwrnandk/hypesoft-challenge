namespace Hypesoft.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public DateTime CreatedAt { get; private set; }

    public User(string name, string email)
    {
        Validate(name, email);

        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        CreatedAt = DateTime.UtcNow;
    }

    // Construtor para ORM
    protected User() { }

    private void Validate(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nome é obrigatório.");

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email é obrigatório.");

        if (!email.Contains("@"))
            throw new ArgumentException("Email inválido.");
    }
}
