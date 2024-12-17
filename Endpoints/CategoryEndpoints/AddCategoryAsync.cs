using FastEndpoints;
using ScoutManager.Endpoints.UserEndpoints;

namespace ScoutManager.Endpoints.CategoryEndpoints;

public class AddCategoryAsync : Endpoint<AddCategoryRequest>
{
    public override void Configure()
    {
        Post("/category/add"); 
        AllowAnonymous();   // ToDo: Change after apply keycloak
    }

    public override async Task HandleAsync(AddCategoryRequest req,CancellationToken ct)
    {
        // To change
        await SendAsync($"Hello, World! {req.Name}!"); // odpowiedź endpointu
    }
}

public class AddCategoryRequest
{
    public string Name { get; init; }
    public string  Description { get; init; } 
}