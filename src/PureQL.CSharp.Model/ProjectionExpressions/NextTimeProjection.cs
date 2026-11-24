using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.time@projection</c>.</summary>
public sealed record NextTimeProjection : IOperator
{
    public NextTimeProjection(
        TimeRow operand,
        TimeRow @default,
        OrderedWindow over,
        Offset? offset = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public TimeRow Operand { get; }

    public Offset? Offset { get; }

    public TimeRow Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeTime();
}
