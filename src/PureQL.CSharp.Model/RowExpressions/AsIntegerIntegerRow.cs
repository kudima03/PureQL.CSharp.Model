using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asInteger.integer@row</c>.</summary>
public sealed record AsIntegerIntegerRow : IOperator
{
    public AsIntegerIntegerRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeInteger();
}
