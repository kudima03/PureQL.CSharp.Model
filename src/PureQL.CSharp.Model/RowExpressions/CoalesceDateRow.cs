using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.date@row</c>.</summary>
public sealed record CoalesceDateRow : IOperator
{
    public CoalesceDateRow(IEnumerable<DateNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableRow> Values { get; }

    public IType Type => new TypeDate();
}
