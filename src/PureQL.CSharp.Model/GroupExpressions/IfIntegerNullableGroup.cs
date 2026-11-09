using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.integer.nullable@group</c>.</summary>
public sealed record IfIntegerNullableGroup : IOperator
{
    public IfIntegerNullableGroup(
        IntegerNullableGroup then,
        IntegerNullableGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public IntegerNullableGroup Then { get; }

    public IntegerNullableGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeIntegerNullable();
}
