using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfUuidGroup : IOperator
{
    public IfUuidGroup(BooleanGroup condition, UuidGroup then, UuidGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public UuidGroup Then { get; }

    public UuidGroup Else { get; }

    public IType Type => new TypeUuid();
}
