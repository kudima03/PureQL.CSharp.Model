using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDatetime.string.datetime.nullable@total</c>.</summary>
public sealed record AsDatetimeStringDatetimeNullableTotal : IOperator
{
    public AsDatetimeStringDatetimeNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
