using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record DateAddDaysDateTotal : IOperator
{
    public DateAddDaysDateTotal(DateTotal left, IntegerTotal right)
    {
        Left = left;
        Right = right;
    }

    public DateTotal Left { get; }

    public IntegerTotal Right { get; }

    public IType Type => new TypeDate();
}
