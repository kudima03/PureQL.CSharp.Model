using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>truncate.decimal@projection</c>.</summary>
public sealed record TruncateDecimalProjection : IOperator
{
    public TruncateDecimalProjection(
        DeclaresDecimalProjection operand,
        IntegerProjection digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public DeclaresDecimalProjection Operand { get; }

    public IntegerProjection Digits { get; }

    public IType Type => new TypeDecimal();
}
