using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>length.integer@row</c>.</summary>
public sealed record LengthIntegerRow : IOperator
{
    public LengthIntegerRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeInteger();
}
