using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asBoolean.boolean@group</c>.</summary>
public sealed record AsBooleanBooleanGroup : IOperator
{
    public AsBooleanBooleanGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeBoolean();
}
