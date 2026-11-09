using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>or@row</c>.</summary>
public sealed record OrRow : IOperator
{
    public OrRow(IEnumerable<BooleanRow> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanRow> Conditions { get; }

    public IType Type => new TypeBoolean();
}
