using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfTimeRow : IOperator
{
    public IfTimeRow(BooleanRow condition, TimeRow then, TimeRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public TimeRow Then { get; }

    public TimeRow Else { get; }

    public IType Type => new TypeTime();
}
