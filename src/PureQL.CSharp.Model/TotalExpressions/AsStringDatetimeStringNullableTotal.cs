using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.datetime.string.nullable@total</c>.</summary>
public sealed record AsStringDatetimeStringNullableTotal : IOperator
{
    public AsStringDatetimeStringNullableTotal(DeclaresDatetimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
