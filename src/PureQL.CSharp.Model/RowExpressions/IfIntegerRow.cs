using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.integer@row</c>.</summary>
public sealed record IfIntegerRow : IOperator
{
    public IfIntegerRow(IntegerRow then, IntegerRow @else, BooleanRow condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public IntegerRow Then { get; }

    public IntegerRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeInteger();
}
