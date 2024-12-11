namespace ScoutManager.Endpoints;

using FastEndpoints;

public class HelloWorldEndpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/hello-world"); // definiuje ścieżkę endpointu
        AllowAnonymous();    // pozwala na dostęp bez autoryzacji
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendAsync("Hello, World!"); // odpowiedź endpointu
    }
}