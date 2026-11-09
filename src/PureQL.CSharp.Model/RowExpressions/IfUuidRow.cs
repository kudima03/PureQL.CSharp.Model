using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.uuid@row</c>.</summary>
public sealed record IfUuidRow : IOperator
{
    public IfUuidRow(UuidRow then, UuidRow @else, BooleanRow condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public UuidRow Then { get; }

    public UuidRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeUuid();
}
