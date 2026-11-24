using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>log10.decimal.nullable@group</c>.</summary>
public sealed record Log10DecimalNullableGroup : IOperator
{
    public Log10DecimalNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
