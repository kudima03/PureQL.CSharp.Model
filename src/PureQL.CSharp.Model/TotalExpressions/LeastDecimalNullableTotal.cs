using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.decimal.nullable@total</c>.</summary>
public sealed record LeastDecimalNullableTotal : IOperator
{
    public LeastDecimalNullableTotal(IEnumerable<DecimalNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableTotal> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
