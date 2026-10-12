using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record GreaterThanTimeTotal : IOperator
{
    public GreaterThanTimeTotal(TimeNullableTotal left, TimeNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableTotal Left { get; }

    public TimeNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
