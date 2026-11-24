using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.uuid@projection</c>.</summary>
public sealed record NextUuidProjection : IOperator
{
    public NextUuidProjection(
        UuidRow operand,
        UuidRow @default,
        OrderedWindow over,
        Offset? offset = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public UuidRow Operand { get; }

    public Offset? Offset { get; }

    public UuidRow Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeUuid();
}
