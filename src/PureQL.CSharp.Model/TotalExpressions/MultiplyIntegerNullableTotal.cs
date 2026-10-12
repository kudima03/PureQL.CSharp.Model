using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MultiplyIntegerNullableTotal : IOperator
{
    public MultiplyIntegerNullableTotal(IEnumerable<IntegerNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableTotal> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
