using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.boolean.nullable@row</c>.</summary>
public sealed record CoalesceBooleanNullableRow : IOperator
{
    public CoalesceBooleanNullableRow(IEnumerable<DeclaresBooleanNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresBooleanNullableRow> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
