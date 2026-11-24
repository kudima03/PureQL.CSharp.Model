using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>previous.boolean.nullable@projection</c>.</summary>
public sealed record PreviousBooleanNullableProjection : IOperator
{
    public PreviousBooleanNullableProjection(
        BooleanNullableRow operand,
        OrderedWindow over,
        Offset? offset = null,
        BooleanRow? @default = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public BooleanNullableRow Operand { get; }

    public Offset? Offset { get; }

    public BooleanRow? Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeBooleanNullable();
}
