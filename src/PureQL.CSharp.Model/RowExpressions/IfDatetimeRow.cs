using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.datetime@row</c>.</summary>
public sealed record IfDatetimeRow : IOperator
{
    public IfDatetimeRow(DatetimeRow then, DatetimeRow @else, BooleanRow condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DatetimeRow Then { get; }

    public DatetimeRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeDatetime();
}
