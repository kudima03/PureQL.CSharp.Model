using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asUuid.uuid@row</c>.</summary>
public sealed record AsUuidUuidRow : IOperator
{
    public AsUuidUuidRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeUuid();
}
