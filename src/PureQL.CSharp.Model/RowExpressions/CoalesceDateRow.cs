using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDateRow : IOperator
{
    public CoalesceDateRow(IEnumerable<DateNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableRow> Values { get; }

    public IType Type => new TypeDate();
}
