using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>padEnd.string@group</c>.</summary>
public sealed record PadEndStringGroup : IOperator
{
    public PadEndStringGroup(StringGroup operand, IntegerGroup length, StringGroup fill)
    {
        Operand = operand;
        Length = length;
        Fill = fill;
    }

    public StringGroup Operand { get; }

    public IntegerGroup Length { get; }

    public StringGroup Fill { get; }

    public IType Type => new TypeString();
}
