using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.string@projection</c>.</summary>
public sealed record NextStringProjection : IOperator
{
    public NextStringProjection(
        StringRow operand,
        StringRow @default,
        OrderedWindow over,
        Offset? offset = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public StringRow Operand { get; }

    public Offset? Offset { get; }

    public StringRow Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeString();
}
