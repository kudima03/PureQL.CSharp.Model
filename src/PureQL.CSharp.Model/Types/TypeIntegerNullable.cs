namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.integer.nullable</c>.</summary>
public sealed record TypeIntegerNullable : IType
{
    public string Name => "integer";

    public bool Nullable => true;
}
