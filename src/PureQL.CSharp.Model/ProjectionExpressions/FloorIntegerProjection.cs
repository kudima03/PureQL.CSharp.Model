using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>floor.integer@projection</c>.</summary>
public sealed record FloorIntegerProjection : IOperator
{
    public FloorIntegerProjection(DeclaresDecimalProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalProjection Operand { get; }

    public IType Type => new TypeInteger();
}
