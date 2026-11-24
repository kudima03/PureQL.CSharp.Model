using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>substring.string@group</c>.</summary>
public sealed record SubstringStringGroup : IOperator
{
    public SubstringStringGroup(
        StringGroup operand,
        IntegerGroup start,
        IntegerGroup? length = null
    )
    {
        Operand = operand;
        Start = start;
        Length = length;
    }

    public StringGroup Operand { get; }

    public IntegerGroup Start { get; }

    public IntegerGroup? Length { get; }

    public IType Type => new TypeString();
}
