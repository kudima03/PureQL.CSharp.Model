namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.date.nullable</c>.</summary>
public sealed record TypeDateNullable : IType
{
    public string Name => "date";

    public bool Nullable => true;
}
