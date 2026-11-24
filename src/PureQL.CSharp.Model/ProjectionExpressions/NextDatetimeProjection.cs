using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.datetime@projection</c>.</summary>
public sealed record NextDatetimeProjection : IOperator
{
    public NextDatetimeProjection(
        DatetimeRow operand,
        DatetimeRow @default,
        OrderedWindow over,
        Offset? offset = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public DatetimeRow Operand { get; }

    public Offset? Offset { get; }

    public DatetimeRow Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeDatetime();
}
