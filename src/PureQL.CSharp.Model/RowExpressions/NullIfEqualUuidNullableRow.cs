using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>nullIfEqual.uuid.nullable@row</c>.</summary>
public sealed record NullIfEqualUuidNullableRow : IOperator
{
    public NullIfEqualUuidNullableRow(UuidNullableRow left, UuidNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableRow Left { get; }

    public UuidNullableRow Right { get; }

    public IType Type => new TypeUuidNullable();
}
