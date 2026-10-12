using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceBooleanNullableGroup : IOperator
{
    public CoalesceBooleanNullableGroup(IEnumerable<BooleanNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableGroup> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
