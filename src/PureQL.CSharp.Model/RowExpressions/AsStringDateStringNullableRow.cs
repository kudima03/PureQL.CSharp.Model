using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.date.string.nullable@row</c>.</summary>
public sealed record AsStringDateStringNullableRow : IOperator
{
    public AsStringDateStringNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
