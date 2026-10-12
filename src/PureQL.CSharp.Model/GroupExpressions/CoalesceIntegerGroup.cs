using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceIntegerGroup : IOperator
{
    public CoalesceIntegerGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }

    public IType Type => new TypeInteger();
}
