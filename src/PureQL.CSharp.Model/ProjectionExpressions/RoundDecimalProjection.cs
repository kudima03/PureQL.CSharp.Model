using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record RoundDecimalProjection : IOperator
{
    public RoundDecimalProjection(DecimalProjection operand, IntegerProjection digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalProjection Operand { get; }

    public IntegerProjection Digits { get; }

    public IType Type => new TypeDecimal();
}
