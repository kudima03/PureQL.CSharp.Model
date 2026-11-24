using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>removeDiacritics.string@group</c>.</summary>
public sealed record RemoveDiacriticsStringGroup : IOperator
{
    public RemoveDiacriticsStringGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeString();
}
