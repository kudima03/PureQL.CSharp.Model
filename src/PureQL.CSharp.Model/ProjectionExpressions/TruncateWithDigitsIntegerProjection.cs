using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>truncate.withDigits.integer@projection</c>.</summary>
public sealed record TruncateWithDigitsIntegerProjection : IOperator
{
    public TruncateWithDigitsIntegerProjection(
        IntegerProjection operand,
        IntegerProjection digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerProjection Operand { get; }

    public IntegerProjection Digits { get; }

    public IType Type => new TypeInteger();
}
