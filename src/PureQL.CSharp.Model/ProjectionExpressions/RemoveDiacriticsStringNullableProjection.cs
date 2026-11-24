using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>removeDiacritics.string.nullable@projection</c>.</summary>
public sealed record RemoveDiacriticsStringNullableProjection : IOperator
{
    public RemoveDiacriticsStringNullableProjection(
        DeclaresStringNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
