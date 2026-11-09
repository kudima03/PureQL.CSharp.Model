using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.date.nullable@row</c>.</summary>
public sealed record CoalesceDateNullableRow : IOperator
{
    public CoalesceDateNullableRow(IEnumerable<DeclaresDateNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresDateNullableRow> Values { get; }

    public IType Type => new TypeDateNullable();
}
