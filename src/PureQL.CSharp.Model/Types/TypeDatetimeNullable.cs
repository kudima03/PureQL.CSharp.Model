namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.datetime.nullable</c>.</summary>
public sealed record TypeDatetimeNullable : IType
{
    public string Name => "datetime";

    public bool Nullable => true;
}
