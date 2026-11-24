using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asTime.string.time.nullable@total</c>.</summary>
public sealed record AsTimeStringTimeNullableTotal : IOperator
{
    public AsTimeStringTimeNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeTimeNullable();
}
