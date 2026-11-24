using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.decimal@group</c>.</summary>
public sealed record LeastDecimalGroup : IOperator
{
    public LeastDecimalGroup(IEnumerable<DecimalGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalGroup> Values { get; }

    public IType Type => new TypeDecimal();
}
