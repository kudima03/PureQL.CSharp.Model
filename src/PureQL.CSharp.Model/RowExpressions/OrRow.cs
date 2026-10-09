namespace PureQL.CSharp.Model.RowExpressions;

public sealed record OrRow
{
    public OrRow(IEnumerable<BooleanRow> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanRow> Conditions { get; }
}
