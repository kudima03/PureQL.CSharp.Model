using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.time.string.nullable@total</c>.</summary>
public sealed record AsStringTimeStringNullableTotal : IOperator
{
    public AsStringTimeStringNullableTotal(DeclaresTimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
