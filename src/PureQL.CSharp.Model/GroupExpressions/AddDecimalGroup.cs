using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>add.decimal@group</c>.</summary>
public sealed record AddDecimalGroup : IOperator
{
    public AddDecimalGroup(IEnumerable<DecimalGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalGroup> Values { get; }

    public IType Type => new TypeDecimal();
}
