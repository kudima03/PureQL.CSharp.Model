namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.boolean.nullable</c>.</summary>
public sealed record TypeBooleanNullable : IType
{
    public string Name => "boolean";

    public bool Nullable => true;
}
