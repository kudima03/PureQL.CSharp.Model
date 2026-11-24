using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>previous.boolean@projection</c>.</summary>
public sealed record PreviousBooleanProjection : IOperator
{
    public PreviousBooleanProjection(
        BooleanRow operand,
        BooleanRow @default,
        OrderedWindow over,
        Offset? offset = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public BooleanRow Operand { get; }

    public Offset? Offset { get; }

    public BooleanRow Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeBoolean();
}
