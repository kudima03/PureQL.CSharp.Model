using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asNullable.time.nullable@row</c>.</summary>
public sealed record AsNullableTimeNullableRow : IOperator
{
    public AsNullableTimeNullableRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeTimeNullable();
}
