using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>position.integer.nullable@group</c>.</summary>
public sealed record PositionIntegerNullableGroup : IOperator
{
    public PositionIntegerNullableGroup(
        StringNullableGroup operand,
        StringNullableGroup pattern,
        IntegerNullableGroup? start = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Start = start;
    }

    public StringNullableGroup Operand { get; }

    public StringNullableGroup Pattern { get; }

    public IntegerNullableGroup? Start { get; }

    public IType Type => new TypeIntegerNullable();
}
