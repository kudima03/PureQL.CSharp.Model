namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.time.nullable</c>.</summary>
public sealed record TypeTimeNullable : IType
{
    public string Name => "time";

    public bool Nullable => true;
}
