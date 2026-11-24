using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.date.string.nullable@total</c>.</summary>
public sealed record AsStringDateStringNullableTotal : IOperator
{
    public AsStringDateStringNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
