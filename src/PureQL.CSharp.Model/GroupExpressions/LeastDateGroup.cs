using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.date@group</c>.</summary>
public sealed record LeastDateGroup : IOperator
{
    public LeastDateGroup(IEnumerable<DateGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DateGroup> Values { get; }

    public IType Type => new TypeDate();
}
