using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>normalize.string.nullable@group</c>.</summary>
public sealed record NormalizeStringNullableGroup : IOperator
{
    public NormalizeStringNullableGroup(
        DeclaresStringNullableGroup operand,
        NormalizationForm form
    )
    {
        Operand = operand;
        Form = form;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public NormalizationForm Form { get; }

    public IType Type => new TypeStringNullable();
}
