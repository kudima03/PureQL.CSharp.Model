using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.uuid.nullable@row</c>.</summary>
public sealed record IfUuidNullableRow : IOperator
{
    public IfUuidNullableRow(
        UuidNullableRow then,
        UuidNullableRow @else,
        BooleanRow condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public UuidNullableRow Then { get; }

    public UuidNullableRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeUuidNullable();
}
