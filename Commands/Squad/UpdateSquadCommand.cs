namespace ScoutManager.Commands.Squad;

public sealed class UpdateSquadCommand
{
    public Guid SquadId { get; set; }
    public Guid SquadOwnerId { get; init; }
    public string  Name { get; init; }
}