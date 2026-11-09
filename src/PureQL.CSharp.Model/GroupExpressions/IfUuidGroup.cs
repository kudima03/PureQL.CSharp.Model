using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.uuid@group</c>.</summary>
public sealed record IfUuidGroup : IOperator
{
    public IfUuidGroup(UuidGroup then, UuidGroup @else, BooleanGroup condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public UuidGroup Then { get; }

    public UuidGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeUuid();
}
