using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MultiplyIntegerTotal : IOperator
{
    public MultiplyIntegerTotal(IEnumerable<IntegerTotal> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerTotal> Values { get; }

    public IType Type => new TypeInteger();
}
