using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>timeFromParts.time@group</c>.</summary>
public sealed record TimeFromPartsTimeGroup : IOperator
{
    public TimeFromPartsTimeGroup(
        IntegerGroup hour,
        IntegerGroup minute,
        DecimalGroup second
    )
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public IntegerGroup Hour { get; }

    public IntegerGroup Minute { get; }

    public DecimalGroup Second { get; }

    public IType Type => new TypeTime();
}
