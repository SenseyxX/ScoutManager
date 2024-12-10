using ScoutManager.Entites.Abstractions;

namespace ScoutManager.Entities.User;

public sealed class User : Aggregate
{
    public User(Guid id,
        string name,
        string lastName,
        byte[] passwordHash,
        string email,
        string phoneNumber,
        PermissionLevel permissionLevel,
        State state,
        Guid? squadId,
        Guid? teamId)
        : base(id)
    {
        Name = name;
        LastName = lastName;
        PasswordHash = passwordHash;
        Email = email;
        PhoneNumber = phoneNumber;
        PermissionLevel = permissionLevel;
        State = state;
        SquadId = squadId;
        TeamId = teamId;
        OwnedItems = new List<Item.Item>();
        StoredItems = new List<Item.Item>();
        // Dues = new List<Due>();
    }
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public byte[] PasswordHash { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public Guid? SquadId { get; private set; }
    public State State { get; private set; }
    public PermissionLevel PermissionLevel { get; }
    public Guid? TeamId { get; }
    public ICollection<Item.Item> OwnedItems { get; }
    public ICollection<Item.Item> StoredItems { get; }
    // public ICollection<Due> Dues { get; }
    
}