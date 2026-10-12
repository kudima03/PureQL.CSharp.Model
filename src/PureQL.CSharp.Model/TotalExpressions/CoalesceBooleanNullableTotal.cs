using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceBooleanNullableTotal : IOperator
{
    public CoalesceBooleanNullableTotal(IEnumerable<BooleanNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableTotal> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
