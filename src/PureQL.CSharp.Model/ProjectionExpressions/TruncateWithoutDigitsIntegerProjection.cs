using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>truncate.withoutDigits.integer@projection</c>.</summary>
public sealed record TruncateWithoutDigitsIntegerProjection : IOperator
{
    public TruncateWithoutDigitsIntegerProjection(DeclaresDecimalProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalProjection Operand { get; }

    public IType Type => new TypeInteger();
}
