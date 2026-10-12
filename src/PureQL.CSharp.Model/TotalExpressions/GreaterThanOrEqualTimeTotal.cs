using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record GreaterThanOrEqualTimeTotal : IOperator
{
    public GreaterThanOrEqualTimeTotal(TimeNullableTotal left, TimeNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableTotal Left { get; }

    public TimeNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
