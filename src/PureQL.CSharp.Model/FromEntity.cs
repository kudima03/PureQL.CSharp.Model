namespace PureQL.CSharp.Model;

public sealed record FromEntity
{
    public FromEntity(string entity, string? alias = null)
    {
        Entity = entity;
        Alias = alias;
    }

    public string Entity { get; }

    public string? Alias { get; }
}
