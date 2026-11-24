using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>removeDiacritics.string.nullable@row</c>.</summary>
public sealed record RemoveDiacriticsStringNullableRow : IOperator
{
    public RemoveDiacriticsStringNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
