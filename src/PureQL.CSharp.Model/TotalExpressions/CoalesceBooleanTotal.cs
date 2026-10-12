using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceBooleanTotal : IOperator
{
    public CoalesceBooleanTotal(IEnumerable<BooleanNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableTotal> Values { get; }

    public IType Type => new TypeBoolean();
}
