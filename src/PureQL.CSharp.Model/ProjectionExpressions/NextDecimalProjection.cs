using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.decimal@projection</c>.</summary>
public sealed record NextDecimalProjection : IOperator
{
    public NextDecimalProjection(
        DeclaresDecimalRow operand,
        DecimalRow @default,
        OrderedWindow over,
        Offset? offset = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public DeclaresDecimalRow Operand { get; }

    public Offset? Offset { get; }

    public DecimalRow Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeDecimal();
}
