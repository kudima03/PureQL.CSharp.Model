using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>multiply.decimal@group</c>.</summary>
public sealed record MultiplyDecimalGroup : IOperator
{
    public MultiplyDecimalGroup(IEnumerable<DecimalGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalGroup> Values { get; }

    public IType Type => new TypeDecimal();
}
