using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDecimal.string.decimal@projection</c>.</summary>
public sealed record AsDecimalStringDecimalProjection : IOperator
{
    public AsDecimalStringDecimalProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeDecimal();
}
