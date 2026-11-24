using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>length.integer@group</c>.</summary>
public sealed record LengthIntegerGroup : IOperator
{
    public LengthIntegerGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeInteger();
}
