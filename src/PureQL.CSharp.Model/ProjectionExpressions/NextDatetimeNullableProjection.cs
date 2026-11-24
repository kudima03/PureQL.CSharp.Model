using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.datetime.nullable@projection</c>.</summary>
public sealed record NextDatetimeNullableProjection : IOperator
{
    public NextDatetimeNullableProjection(
        DatetimeNullableRow operand,
        OrderedWindow over,
        Offset? offset = null,
        DatetimeRow? @default = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public DatetimeNullableRow Operand { get; }

    public Offset? Offset { get; }

    public DatetimeRow? Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeDatetimeNullable();
}
