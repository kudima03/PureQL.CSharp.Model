using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>power.decimal.nullable@group</c>.</summary>
public sealed record PowerDecimalNullableGroup : IOperator
{
    public PowerDecimalNullableGroup(
        DecimalNullableGroup operand,
        DecimalNullableGroup exponent
    )
    {
        Operand = operand;
        Exponent = exponent;
    }

    public DecimalNullableGroup Operand { get; }

    public DecimalNullableGroup Exponent { get; }

    public IType Type => new TypeDecimalNullable();
}
