namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.uuidList</c>.</summary>
public sealed record TypeUuidList : IType
{
    public string Name => "uuidList";

    public bool Nullable => false;
}
