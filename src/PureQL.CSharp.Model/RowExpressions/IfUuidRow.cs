using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfUuidRow : IOperator
{
    public IfUuidRow(BooleanRow condition, UuidRow then, UuidRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public UuidRow Then { get; }

    public UuidRow Else { get; }

    public IType Type => new TypeUuid();
}
