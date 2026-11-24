using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>modulo.decimal.nullable@group</c>.</summary>
public sealed record ModuloDecimalNullableGroup : IOperator
{
    public ModuloDecimalNullableGroup(
        DecimalNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeDecimalNullable();
}
