using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.decimal.nullable@total</c>.</summary>
public sealed record GreatestDecimalNullableTotal : IOperator
{
    public GreatestDecimalNullableTotal(IEnumerable<DecimalNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableTotal> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
