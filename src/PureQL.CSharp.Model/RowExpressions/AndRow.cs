using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record AndRow : IOperator
{
    public AndRow(IEnumerable<BooleanRow> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanRow> Conditions { get; }

    public IType Type => new TypeBoolean();
}
