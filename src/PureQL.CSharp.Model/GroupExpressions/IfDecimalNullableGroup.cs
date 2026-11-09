using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.decimal.nullable@group</c>.</summary>
public sealed record IfDecimalNullableGroup : IOperator
{
    public IfDecimalNullableGroup(
        DecimalNullableGroup then,
        DecimalNullableGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DecimalNullableGroup Then { get; }

    public DecimalNullableGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeDecimalNullable();
}
