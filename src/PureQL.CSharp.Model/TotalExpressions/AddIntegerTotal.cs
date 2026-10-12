using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record AddIntegerTotal : IOperator
{
    public AddIntegerTotal(IEnumerable<IntegerTotal> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerTotal> Values { get; }

    public IType Type => new TypeInteger();
}
