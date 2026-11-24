using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>sign.integer@projection</c>.</summary>
public sealed record SignIntegerProjection : IOperator
{
    public SignIntegerProjection(DecimalProjection operand)
    {
        Operand = operand;
    }

    public DecimalProjection Operand { get; }

    public IType Type => new TypeInteger();
}
