using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.boolean.string.nullable@total</c>.</summary>
public sealed record AsStringBooleanStringNullableTotal : IOperator
{
    public AsStringBooleanStringNullableTotal(DeclaresBooleanNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresBooleanNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
