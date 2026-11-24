using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startsWith@total</c>.</summary>
public sealed record StartsWithTotal : IOperator
{
    public StartsWithTotal(StringNullableTotal operand, StringNullableTotal pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableTotal Operand { get; }

    public StringNullableTotal Pattern { get; }

    public IType Type => new TypeBoolean();
}
