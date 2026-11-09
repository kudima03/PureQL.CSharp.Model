namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.timeList</c>.</summary>
public sealed record TypeTimeList : IType
{
    public string Name => "timeList";

    public bool Nullable => false;
}
