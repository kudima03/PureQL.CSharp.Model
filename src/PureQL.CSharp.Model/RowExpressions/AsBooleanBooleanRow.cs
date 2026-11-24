using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asBoolean.boolean@row</c>.</summary>
public sealed record AsBooleanBooleanRow : IOperator
{
    public AsBooleanBooleanRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeBoolean();
}
