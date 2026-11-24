using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>removeDiacritics.string.nullable@total</c>.</summary>
public sealed record RemoveDiacriticsStringNullableTotal : IOperator
{
    public RemoveDiacriticsStringNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
