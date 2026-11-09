using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>equal.uuid@row</c>.</summary>
public sealed record EqualUuidRow : IOperator
{
    public EqualUuidRow(UuidNullableRow left, UuidNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableRow Left { get; }

    public UuidNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
