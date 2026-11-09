using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.time@row</c>.</summary>
public sealed record IfTimeRow : IOperator
{
    public IfTimeRow(TimeRow then, TimeRow @else, BooleanRow condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public TimeRow Then { get; }

    public TimeRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeTime();
}
