using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfSecond.datetime.nullable@total</c>.</summary>
public sealed record StartOfSecondDatetimeNullableTotal : IOperator
{
    public StartOfSecondDatetimeNullableTotal(DeclaresDatetimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableTotal Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
