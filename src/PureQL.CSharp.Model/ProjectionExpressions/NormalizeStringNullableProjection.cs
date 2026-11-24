using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>normalize.string.nullable@projection</c>.</summary>
public sealed record NormalizeStringNullableProjection : IOperator
{
    public NormalizeStringNullableProjection(
        DeclaresStringNullableProjection operand,
        NormalizationForm form
    )
    {
        Operand = operand;
        Form = form;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public NormalizationForm Form { get; }

    public IType Type => new TypeStringNullable();
}
