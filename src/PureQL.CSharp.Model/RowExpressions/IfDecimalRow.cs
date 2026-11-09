using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.decimal@row</c>.</summary>
public sealed record IfDecimalRow : IOperator
{
    public IfDecimalRow(DecimalRow then, DecimalRow @else, BooleanRow condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DecimalRow Then { get; }

    public DecimalRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeDecimal();
}
