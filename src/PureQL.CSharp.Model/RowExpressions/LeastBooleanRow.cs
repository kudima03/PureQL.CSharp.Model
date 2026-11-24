using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.boolean@row</c>.</summary>
public sealed record LeastBooleanRow : IOperator
{
    public LeastBooleanRow(IEnumerable<BooleanRow> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanRow> Values { get; }

    public IType Type => new TypeBoolean();
}
