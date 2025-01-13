using ScoutManager.Entities;
using ScoutManager.Entities.User;

namespace ScoutManager.Factories;

public class UserFactory
{
    public static User Create(
        string name,
        string lastname,
        byte[] passwordHash,
        string email,
        string phoneNumber,
        PermissionLevel permissionLevel,
        Guid? squadId,
        Guid? teamId)
        => new (
            Guid.NewGuid(),
            name,
            lastname,
            passwordHash,
            email,
            phoneNumber,
            permissionLevel,
            State.Active,
            squadId,
            teamId);
}