using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateAddDays.date@group</c>.</summary>
public sealed record DateAddDaysDateGroup : IOperator
{
    public DateAddDaysDateGroup(DateGroup left, IntegerGroup right)
    {
        Left = left;
        Right = right;
    }

    public DateGroup Left { get; }

    public IntegerGroup Right { get; }

    public IType Type => new TypeDate();
}
