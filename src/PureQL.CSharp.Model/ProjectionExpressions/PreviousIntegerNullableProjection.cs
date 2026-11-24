using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>previous.integer.nullable@projection</c>.</summary>
public sealed record PreviousIntegerNullableProjection : IOperator
{
    public PreviousIntegerNullableProjection(
        IntegerNullableRow operand,
        OrderedWindow over,
        Offset? offset = null,
        IntegerRow? @default = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public IntegerNullableRow Operand { get; }

    public Offset? Offset { get; }

    public IntegerRow? Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeIntegerNullable();
}
