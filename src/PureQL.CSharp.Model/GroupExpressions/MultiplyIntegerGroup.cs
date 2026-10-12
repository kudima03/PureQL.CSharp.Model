using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MultiplyIntegerGroup : IOperator
{
    public MultiplyIntegerGroup(IEnumerable<IntegerGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerGroup> Values { get; }

    public IType Type => new TypeInteger();
}
