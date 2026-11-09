namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.date</c>.</summary>
public sealed record TypeDate : IType
{
    public string Name => "date";

    public bool Nullable => false;
}
