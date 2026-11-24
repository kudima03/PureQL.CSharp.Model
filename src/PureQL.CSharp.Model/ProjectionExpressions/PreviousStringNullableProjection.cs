using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>previous.string.nullable@projection</c>.</summary>
public sealed record PreviousStringNullableProjection : IOperator
{
    public PreviousStringNullableProjection(
        StringNullableRow operand,
        OrderedWindow over,
        Offset? offset = null,
        StringRow? @default = null
    )
    {
        Operand = operand;
        Offset = offset;
        Default = @default;
        Over = over;
    }

    public StringNullableRow Operand { get; }

    public Offset? Offset { get; }

    public StringRow? Default { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeStringNullable();
}
