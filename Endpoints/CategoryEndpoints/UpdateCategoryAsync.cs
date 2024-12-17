using FastEndpoints;

namespace ScoutManager.Endpoints.CategoryEndpoints;

public class UpdateCategoryAsync : Endpoint<UpdateCategoryRequest>
{
    public override void Configure()
    {
        Post("/category/update"); 
        AllowAnonymous();   // ToDo: Change after apply keycloak
    }

    public override async Task HandleAsync(UpdateCategoryRequest req,CancellationToken ct)
    {
        // To change
        await SendAsync($"Hello, World! {req.Name}!"); // odpowiedź endpointu
    }
}

public class UpdateCategoryRequest
{
    public Guid CategoryId { get; set; }
    public string Name { get; init; }
    public string Description { get; init; }
}