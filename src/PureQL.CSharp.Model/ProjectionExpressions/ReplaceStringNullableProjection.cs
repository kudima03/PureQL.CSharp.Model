using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>replace.string.nullable@projection</c>.</summary>
public sealed record ReplaceStringNullableProjection : IOperator
{
    public ReplaceStringNullableProjection(
        StringNullableProjection operand,
        StringNullableProjection pattern,
        StringNullableProjection replacement
    )
    {
        Operand = operand;
        Pattern = pattern;
        Replacement = replacement;
    }

    public StringNullableProjection Operand { get; }

    public StringNullableProjection Pattern { get; }

    public StringNullableProjection Replacement { get; }

    public IType Type => new TypeStringNullable();
}
