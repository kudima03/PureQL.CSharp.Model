using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceDateTotal : IOperator
{
    public CoalesceDateTotal(IEnumerable<DateNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableTotal> Values { get; }

    public IType Type => new TypeDate();
}
