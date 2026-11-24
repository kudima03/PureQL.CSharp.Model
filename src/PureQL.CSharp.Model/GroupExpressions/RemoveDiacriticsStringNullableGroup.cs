using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>removeDiacritics.string.nullable@group</c>.</summary>
public sealed record RemoveDiacriticsStringNullableGroup : IOperator
{
    public RemoveDiacriticsStringNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
