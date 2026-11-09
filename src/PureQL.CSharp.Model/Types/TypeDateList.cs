namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.dateList</c>.</summary>
public sealed record TypeDateList : IType
{
    public string Name => "dateList";

    public bool Nullable => false;
}
