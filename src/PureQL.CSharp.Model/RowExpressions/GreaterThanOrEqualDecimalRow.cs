using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.decimal@row</c>.</summary>
public sealed record GreaterThanOrEqualDecimalRow : IOperator
{
    public GreaterThanOrEqualDecimalRow(DecimalNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
