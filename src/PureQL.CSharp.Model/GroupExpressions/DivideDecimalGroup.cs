using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DivideDecimalGroup : IOperator
{
    public DivideDecimalGroup(IEnumerable<DecimalGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalGroup> Values { get; }

    public IType Type => new TypeDecimal();
}
