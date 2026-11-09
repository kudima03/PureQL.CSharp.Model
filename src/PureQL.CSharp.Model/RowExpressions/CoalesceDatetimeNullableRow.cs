using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.datetime.nullable@row</c>.</summary>
public sealed record CoalesceDatetimeNullableRow : IOperator
{
    public CoalesceDatetimeNullableRow(IEnumerable<DeclaresDatetimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresDatetimeNullableRow> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
