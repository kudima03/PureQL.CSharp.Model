namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.string.nullable</c>.</summary>
public sealed record TypeStringNullable : IType
{
    public string Name => "string";

    public bool Nullable => true;
}
