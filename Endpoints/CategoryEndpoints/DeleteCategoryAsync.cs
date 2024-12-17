using FastEndpoints;
using ScoutManager.Endpoints.UserEndpoints;

namespace ScoutManager.Endpoints.CategoryEndpoints;

public class DeleteCategoryAsync : EndpointWithoutRequest
{
    public override void Configure()
    {
        Post("/user/"); 
        AllowAnonymous();   // ToDo: Change after apply keycloak
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        // To change
        await SendAsync($"Hello, World!"); // odpowiedź endpointu
    }
} 