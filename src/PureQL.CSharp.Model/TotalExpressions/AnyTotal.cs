using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record AnyTotal : IOperator
{
    public AnyTotal(BooleanRow predicate)
    {
        Predicate = predicate;
    }

    public BooleanRow Predicate { get; }

    public IType Type => new TypeBoolean();
}
