using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>normalize.string.nullable@total</c>.</summary>
public sealed record NormalizeStringNullableTotal : IOperator
{
    public NormalizeStringNullableTotal(
        DeclaresStringNullableTotal operand,
        NormalizationForm form
    )
    {
        Operand = operand;
        Form = form;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public NormalizationForm Form { get; }

    public IType Type => new TypeStringNullable();
}
