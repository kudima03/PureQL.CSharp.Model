using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>abs.integer@projection</c>.</summary>
public sealed record AbsIntegerProjection : IOperator
{
    public AbsIntegerProjection(IntegerProjection operand)
    {
        Operand = operand;
    }

    public IntegerProjection Operand { get; }

    public IType Type => new TypeInteger();
}
