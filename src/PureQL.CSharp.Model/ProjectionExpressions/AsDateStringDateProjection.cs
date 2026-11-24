using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDate.string.date@projection</c>.</summary>
public sealed record AsDateStringDateProjection : IOperator
{
    public AsDateStringDateProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeDate();
}
