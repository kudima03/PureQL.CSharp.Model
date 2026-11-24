using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.time.nullable@projection</c>.</summary>
public sealed record NextTimeNullableProjection : IOperator
{
    public NextTimeNullableProjection(
        TimeNullableRow operand,
        OrderedWindow over,
        Offset? offset = null,
        TimeRow? @default = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public TimeNullableRow Operand { get; }

    public Offset? Offset { get; }

    public TimeRow? Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeTimeNullable();
}
