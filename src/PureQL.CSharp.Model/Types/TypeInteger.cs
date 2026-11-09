namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.integer</c>.</summary>
public sealed record TypeInteger : IType
{
    public string Name => "integer";

    public bool Nullable => false;
}
