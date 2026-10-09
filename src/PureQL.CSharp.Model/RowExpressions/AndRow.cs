namespace PureQL.CSharp.Model.RowExpressions;

public sealed record AndRow
{
    public AndRow(IEnumerable<BooleanRow> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanRow> Conditions { get; }
}
