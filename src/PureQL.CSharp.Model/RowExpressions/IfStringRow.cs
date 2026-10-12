using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfStringRow : IOperator
{
    public IfStringRow(BooleanRow condition, StringRow then, StringRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public StringRow Then { get; }

    public StringRow Else { get; }

    public IType Type => new TypeString();
}
