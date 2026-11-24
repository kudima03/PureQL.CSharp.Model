using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.integer.nullable@total</c>.</summary>
public sealed record GreatestIntegerNullableTotal : IOperator
{
    public GreatestIntegerNullableTotal(IEnumerable<IntegerNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableTotal> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
