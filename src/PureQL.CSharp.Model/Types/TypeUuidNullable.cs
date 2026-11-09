namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.uuid.nullable</c>.</summary>
public sealed record TypeUuidNullable : IType
{
    public string Name => "uuid";

    public bool Nullable => true;
}
