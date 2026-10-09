namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CeilingIntegerRow
{
    public CeilingIntegerRow(DecimalRow value)
    {
        Value = value;
    }

    public DecimalRow Value { get; }
}
