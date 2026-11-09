namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.stringList</c>.</summary>
public sealed record TypeStringList : IType
{
    public string Name => "stringList";

    public bool Nullable => false;
}
