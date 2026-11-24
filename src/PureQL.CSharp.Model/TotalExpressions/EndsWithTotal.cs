using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>endsWith@total</c>.</summary>
public sealed record EndsWithTotal : IOperator
{
    public EndsWithTotal(StringNullableTotal operand, StringNullableTotal pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableTotal Operand { get; }

    public StringNullableTotal Pattern { get; }

    public IType Type => new TypeBoolean();
}
