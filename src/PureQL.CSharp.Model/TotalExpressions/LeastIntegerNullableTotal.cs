using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.integer.nullable@total</c>.</summary>
public sealed record LeastIntegerNullableTotal : IOperator
{
    public LeastIntegerNullableTotal(IEnumerable<IntegerNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableTotal> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
