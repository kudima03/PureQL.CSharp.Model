namespace PureQL.CSharp.Model.RowExpressions;

public sealed record RoundIntegerRow
{
    public RoundIntegerRow(DecimalRow value)
    {
        Value = value;
    }

    public DecimalRow Value { get; }
}
