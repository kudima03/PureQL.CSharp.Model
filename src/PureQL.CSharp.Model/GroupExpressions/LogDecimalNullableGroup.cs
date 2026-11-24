using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>log.decimal.nullable@group</c>.</summary>
public sealed record LogDecimalNullableGroup : IOperator
{
    public LogDecimalNullableGroup(
        DecimalNullableGroup operand,
        DecimalNullableGroup @base
    )
    {
        Operand = operand;
        Base = @base;
    }

    public DecimalNullableGroup Operand { get; }

    public DecimalNullableGroup Base { get; }

    public IType Type => new TypeDecimalNullable();
}
