using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>trimEnd.string@group</c>.</summary>
public sealed record TrimEndStringGroup : IOperator
{
    public TrimEndStringGroup(StringGroup operand, IEnumerable<StringGroup> removables)
    {
        Operand = operand;
        Removables = removables;
    }

    public StringGroup Operand { get; }

    public IEnumerable<StringGroup> Removables { get; }

    public IType Type => new TypeString();
}
