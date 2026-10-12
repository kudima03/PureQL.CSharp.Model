using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AllGroup : IOperator
{
    public AllGroup(BooleanRow predicate, AggregateOver over = AggregateOver.Group)
    {
        Predicate = predicate;
        Over = over;
    }

    public BooleanRow Predicate { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeBoolean();
}
