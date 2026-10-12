using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceBooleanGroup : IOperator
{
    public CoalesceBooleanGroup(IEnumerable<BooleanNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableGroup> Values { get; }

    public IType Type => new TypeBoolean();
}
