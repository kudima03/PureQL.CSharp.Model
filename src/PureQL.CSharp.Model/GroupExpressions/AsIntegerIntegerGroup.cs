using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asInteger.integer@group</c>.</summary>
public sealed record AsIntegerIntegerGroup : IOperator
{
    public AsIntegerIntegerGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeInteger();
}
