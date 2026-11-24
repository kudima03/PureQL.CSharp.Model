using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.date@projection</c>.</summary>
public sealed record NextDateProjection : IOperator
{
    public NextDateProjection(
        DateRow operand,
        DateRow @default,
        OrderedWindow over,
        Offset? offset = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public DateRow Operand { get; }

    public Offset? Offset { get; }

    public DateRow Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeDate();
}
