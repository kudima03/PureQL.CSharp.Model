using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanOrEqualUuidRow : IOperator
{
    public LessThanOrEqualUuidRow(UuidNullableRow left, UuidNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableRow Left { get; }

    public UuidNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
