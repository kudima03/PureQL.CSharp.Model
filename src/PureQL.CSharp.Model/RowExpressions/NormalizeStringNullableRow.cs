using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>normalize.string.nullable@row</c>.</summary>
public sealed record NormalizeStringNullableRow : IOperator
{
    public NormalizeStringNullableRow(
        DeclaresStringNullableRow operand,
        NormalizationForm form
    )
    {
        Operand = operand;
        Form = form;
    }

    public DeclaresStringNullableRow Operand { get; }

    public NormalizationForm Form { get; }

    public IType Type => new TypeStringNullable();
}
