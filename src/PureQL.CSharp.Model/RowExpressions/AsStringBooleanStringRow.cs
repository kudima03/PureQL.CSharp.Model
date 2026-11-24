using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.boolean.string@row</c>.</summary>
public sealed record AsStringBooleanStringRow : IOperator
{
    public AsStringBooleanStringRow(BooleanRow operand)
    {
        Operand = operand;
    }

    public BooleanRow Operand { get; }

    public IType Type => new TypeString();
}
