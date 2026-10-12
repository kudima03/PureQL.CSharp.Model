using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceBooleanNullableRow : IOperator
{
    public CoalesceBooleanNullableRow(IEnumerable<BooleanNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableRow> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
