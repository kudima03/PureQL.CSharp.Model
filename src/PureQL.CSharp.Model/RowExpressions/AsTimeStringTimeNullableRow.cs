using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asTime.string.time.nullable@row</c>.</summary>
public sealed record AsTimeStringTimeNullableRow : IOperator
{
    public AsTimeStringTimeNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeTimeNullable();
}
