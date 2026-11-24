using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDate.string.date.nullable@total</c>.</summary>
public sealed record AsDateStringDateNullableTotal : IOperator
{
    public AsDateStringDateNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeDateNullable();
}
