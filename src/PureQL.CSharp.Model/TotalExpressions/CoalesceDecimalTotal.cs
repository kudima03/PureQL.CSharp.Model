using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.decimal@total</c>.</summary>
public sealed record CoalesceDecimalTotal : IOperator
{
    public CoalesceDecimalTotal(IEnumerable<DecimalNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableTotal> Values { get; }

    public IType Type => new TypeDecimal();
}
