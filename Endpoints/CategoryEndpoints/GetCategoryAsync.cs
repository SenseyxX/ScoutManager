using FastEndpoints;

namespace ScoutManager.Endpoints.CategoryEndpoints;

public class GetCategoryAsync: Endpoint<GetCategoryRequest,GetCategoryResponse>
{
    public override void Configure()
    {
        Post("/category/{CategoryId}/"); 
        AllowAnonymous();   // ToDo: Change after apply keycloak
    }

    public override async Task HandleAsync(GetCategoryRequest req, GetCategoryResponse res ,CancellationToken ct)
    {
        // To change
    }
}

public class GetCategoryRequest
{
    public Guid CategoryId { get; init; }
}

public class GetCategoryResponse
{
    
}