using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>length.integer@projection</c>.</summary>
public sealed record LengthIntegerProjection : IOperator
{
    public LengthIntegerProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeInteger();
}
