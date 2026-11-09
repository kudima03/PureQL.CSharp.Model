using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.boolean@row</c>.</summary>
public sealed record CoalesceBooleanRow : IOperator
{
    public CoalesceBooleanRow(IEnumerable<BooleanNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableRow> Values { get; }

    public IType Type => new TypeBoolean();
}
