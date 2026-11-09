using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.date@row</c>.</summary>
public sealed record IfDateRow : IOperator
{
    public IfDateRow(DateRow then, DateRow @else, BooleanRow condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DateRow Then { get; }

    public DateRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeDate();
}
