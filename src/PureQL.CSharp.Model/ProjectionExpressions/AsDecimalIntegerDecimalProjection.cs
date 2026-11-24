using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDecimal.integer.decimal@projection</c>.</summary>
public sealed record AsDecimalIntegerDecimalProjection : IOperator
{
    public AsDecimalIntegerDecimalProjection(IntegerProjection operand)
    {
        Operand = operand;
    }

    public IntegerProjection Operand { get; }

    public IType Type => new TypeDecimal();
}
