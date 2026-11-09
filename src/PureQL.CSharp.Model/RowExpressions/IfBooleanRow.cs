using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.boolean@row</c>.</summary>
public sealed record IfBooleanRow : IOperator
{
    public IfBooleanRow(BooleanRow then, BooleanRow @else, BooleanRow condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public BooleanRow Then { get; }

    public BooleanRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeBoolean();
}
