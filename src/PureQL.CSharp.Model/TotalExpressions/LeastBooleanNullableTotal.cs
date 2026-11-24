using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.boolean.nullable@total</c>.</summary>
public sealed record LeastBooleanNullableTotal : IOperator
{
    public LeastBooleanNullableTotal(IEnumerable<BooleanNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableTotal> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
