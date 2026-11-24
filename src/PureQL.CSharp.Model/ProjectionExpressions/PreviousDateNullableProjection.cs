using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>previous.date.nullable@projection</c>.</summary>
public sealed record PreviousDateNullableProjection : IOperator
{
    public PreviousDateNullableProjection(
        DateNullableRow operand,
        OrderedWindow over,
        Offset? offset = null,
        DateRow? @default = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public DateNullableRow Operand { get; }

    public Offset? Offset { get; }

    public DateRow? Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeDateNullable();
}
