namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.uuid</c>.</summary>
public sealed record TypeUuid : IType
{
    public string Name => "uuid";

    public bool Nullable => false;
}
