namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.booleanList</c>.</summary>
public sealed record TypeBooleanList : IType
{
    public string Name => "booleanList";

    public bool Nullable => false;
}
