namespace ScoutManager.Entites.Abstractions;

public abstract class Aggregate : Entity
{

    protected Aggregate(Guid id) 
        : base(id)
    {
    }
}