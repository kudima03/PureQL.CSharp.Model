using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.decimal.nullable@total</c>.</summary>
public sealed record CoalesceDecimalNullableTotal : IOperator
{
    public CoalesceDecimalNullableTotal(
        IEnumerable<IntegerNullableOrDecimalNullableTotal> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableOrDecimalNullableTotal> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
