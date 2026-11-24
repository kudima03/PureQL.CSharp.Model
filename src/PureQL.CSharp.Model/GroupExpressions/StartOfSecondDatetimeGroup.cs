using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfSecond.datetime@group</c>.</summary>
public sealed record StartOfSecondDatetimeGroup : IOperator
{
    public StartOfSecondDatetimeGroup(DatetimeGroup operand)
    {
        Operand = operand;
    }

    public DatetimeGroup Operand { get; }

    public IType Type => new TypeDatetime();
}
