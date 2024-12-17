using FastEndpoints;

namespace ScoutManager.Endpoints.CategoryEndpoints;

public class GetCategoriesAsync : Endpoint<GetCategoriesResponse>
{
    public override void Configure()
    {
        Post("/category/"); 
        AllowAnonymous();   // ToDo: Change after apply keycloak
    }

    public override async Task HandleAsync(GetCategoriesResponse res,CancellationToken ct)
    {
        // To change
        await SendAsync($"Hello, World!!"); // odpowiedź endpointu
    }
}

public class GetCategoriesResponse
{
    
}

