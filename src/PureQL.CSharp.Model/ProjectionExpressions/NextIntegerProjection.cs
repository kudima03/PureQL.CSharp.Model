using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.integer@projection</c>.</summary>
public sealed record NextIntegerProjection : IOperator
{
    public NextIntegerProjection(
        IntegerRow operand,
        IntegerRow @default,
        OrderedWindow over,
        Offset? offset = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public IntegerRow Operand { get; }

    public Offset? Offset { get; }

    public IntegerRow Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeInteger();
}
