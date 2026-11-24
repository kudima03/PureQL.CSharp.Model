using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>integerDivide.integer.nullable@row</c>.</summary>
public sealed record IntegerDivideIntegerNullableRow : IOperator
{
    public IntegerDivideIntegerNullableRow(
        DecimalNullableRow left,
        DecimalNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeIntegerNullable();
}
