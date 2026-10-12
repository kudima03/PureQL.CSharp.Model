using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfBooleanRow : IOperator
{
    public IfBooleanRow(BooleanRow condition, BooleanRow then, BooleanRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public BooleanRow Then { get; }

    public BooleanRow Else { get; }

    public IType Type => new TypeBoolean();
}
