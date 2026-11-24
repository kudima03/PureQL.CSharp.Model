using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDate.string.date@row</c>.</summary>
public sealed record AsDateStringDateRow : IOperator
{
    public AsDateStringDateRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeDate();
}
