using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.boolean.nullable@total</c>.</summary>
public sealed record GreatestBooleanNullableTotal : IOperator
{
    public GreatestBooleanNullableTotal(IEnumerable<BooleanNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableTotal> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
