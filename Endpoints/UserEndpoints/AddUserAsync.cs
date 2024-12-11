using FastEndpoints;
using ScoutManager.Entities.User;

namespace ScoutManager.Endpoints.UserEndpoints;

public class AddUserAsync : Endpoint<Request>
{
    public override void Configure()
    {
        Post("/user/add"); 
        AllowAnonymous();   // ToDo: Change after apply keycloak
    }

    public override async Task HandleAsync(Request req,CancellationToken ct)
    {
        // To change
        await SendAsync($"Hello, World! {req.Name}!"); // odpowiedź endpointu
    }
}

public class Request
{
    public string Name { get; init; }
    public string LastName { get; init; }
    public string Password { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }
    public Guid? SquadId { get; init; }
    public Guid? TeamId { get; init; }
    public PermissionLevel PermissionLevel { get; init; }
}
