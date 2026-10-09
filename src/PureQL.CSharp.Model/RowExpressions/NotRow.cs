namespace PureQL.CSharp.Model.RowExpressions;

public sealed record NotRow
{
    public NotRow(BooleanRow condition)
    {
        Condition = condition;
    }

    public BooleanRow Condition { get; }
}
