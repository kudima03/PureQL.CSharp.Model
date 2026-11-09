namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.datetime</c>.</summary>
public sealed record TypeDatetime : IType
{
    public string Name => "datetime";

    public bool Nullable => false;
}
