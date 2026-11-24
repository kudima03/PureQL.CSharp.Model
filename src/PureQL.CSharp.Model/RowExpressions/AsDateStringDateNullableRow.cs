using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDate.string.date.nullable@row</c>.</summary>
public sealed record AsDateStringDateNullableRow : IOperator
{
    public AsDateStringDateNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeDateNullable();
}
