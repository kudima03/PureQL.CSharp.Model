using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.date@group</c>.</summary>
public sealed record GreatestDateGroup : IOperator
{
    public GreatestDateGroup(IEnumerable<DateGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DateGroup> Values { get; }

    public IType Type => new TypeDate();
}
