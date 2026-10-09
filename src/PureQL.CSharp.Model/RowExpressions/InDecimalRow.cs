using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InDecimalRow
{
    public InDecimalRow(DecimalNullableRow value, ListDecimal list)
    {
        Value = value;
        List = list;
    }

    public DecimalNullableRow Value { get; }

    public ListDecimal List { get; }
}
