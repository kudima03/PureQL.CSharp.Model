namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfUuidRow
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
}
