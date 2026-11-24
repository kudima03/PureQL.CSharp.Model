using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>next.decimal.nullable@projection</c>.</summary>
public sealed record NextDecimalNullableProjection : IOperator
{
    public NextDecimalNullableProjection(
        DecimalOrDecimalNullableRow operand,
        OrderedWindow over,
        Offset? offset = null,
        DecimalRow? @default = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public DecimalOrDecimalNullableRow Operand { get; }

    public Offset? Offset { get; }

    public DecimalRow? Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeDecimalNullable();
}
