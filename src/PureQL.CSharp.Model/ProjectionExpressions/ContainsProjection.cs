using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>contains@projection</c>.</summary>
public sealed record ContainsProjection : IOperator
{
    public ContainsProjection(
        StringNullableProjection operand,
        StringNullableProjection pattern
    )
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableProjection Operand { get; }

    public StringNullableProjection Pattern { get; }

    public IType Type => new TypeBoolean();
}
