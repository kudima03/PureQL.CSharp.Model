using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asNullable.date.nullable@row</c>.</summary>
public sealed record AsNullableDateNullableRow : IOperator
{
    public AsNullableDateNullableRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeDateNullable();
}
