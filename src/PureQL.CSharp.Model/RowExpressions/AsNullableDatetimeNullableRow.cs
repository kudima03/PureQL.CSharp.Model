using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asNullable.datetime.nullable@row</c>.</summary>
public sealed record AsNullableDatetimeNullableRow : IOperator
{
    public AsNullableDatetimeNullableRow(DatetimeRow operand)
    {
        Operand = operand;
    }

    public DatetimeRow Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
