using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record TimeDiffSecondsDecimalNullableGroup : IOperator
{
    public TimeDiffSecondsDecimalNullableGroup(
        TimeNullableGroup left,
        TimeNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public TimeNullableGroup Right { get; }

    public IType Type => new TypeDecimalNullable();
}
