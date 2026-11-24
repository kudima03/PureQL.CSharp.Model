using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>atan2.decimal.nullable@group</c>.</summary>
public sealed record Atan2DecimalNullableGroup : IOperator
{
    public Atan2DecimalNullableGroup(DecimalNullableGroup y, DecimalNullableGroup x)
    {
        Y = y;
        X = x;
    }

    public DecimalNullableGroup Y { get; }

    public DecimalNullableGroup X { get; }

    public IType Type => new TypeDecimalNullable();
}
