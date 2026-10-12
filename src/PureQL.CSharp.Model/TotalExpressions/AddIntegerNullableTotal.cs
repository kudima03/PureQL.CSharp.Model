using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record AddIntegerNullableTotal : IOperator
{
    public AddIntegerNullableTotal(IEnumerable<IntegerNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableTotal> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
