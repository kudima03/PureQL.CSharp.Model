using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IntegerDivideIntegerNullableGroup : IOperator
{
    public IntegerDivideIntegerNullableGroup(
        IntegerNullableGroup left,
        IntegerNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableGroup Left { get; }

    public IntegerNullableGroup Right { get; }

    public IType Type => new TypeIntegerNullable();
}
