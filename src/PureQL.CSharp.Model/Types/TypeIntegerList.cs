namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.integerList</c>.</summary>
public sealed record TypeIntegerList : IType
{
    public string Name => "integerList";

    public bool Nullable => false;
}
