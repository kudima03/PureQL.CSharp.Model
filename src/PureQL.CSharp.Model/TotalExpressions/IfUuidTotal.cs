using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.uuid@total</c>.</summary>
public sealed record IfUuidTotal : IOperator
{
    public IfUuidTotal(UuidTotal then, UuidTotal @else, BooleanTotal condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public UuidTotal Then { get; }

    public UuidTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeUuid();
}
