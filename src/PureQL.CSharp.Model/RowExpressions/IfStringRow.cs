using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.string@row</c>.</summary>
public sealed record IfStringRow : IOperator
{
    public IfStringRow(StringRow then, StringRow @else, BooleanRow condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public StringRow Then { get; }

    public StringRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeString();
}
