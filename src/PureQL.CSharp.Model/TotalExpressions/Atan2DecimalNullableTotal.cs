using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>atan2.decimal.nullable@total</c>.</summary>
public sealed record Atan2DecimalNullableTotal : IOperator
{
    public Atan2DecimalNullableTotal(DecimalNullableTotal y, DecimalNullableTotal x)
    {
        Y = y;
        X = x;
    }

    public DecimalNullableTotal Y { get; }

    public DecimalNullableTotal X { get; }

    public IType Type => new TypeDecimalNullable();
}
