using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CountTotal : IOperator
{
    public CountTotal(BooleanRow? predicate = null)
    {
        Predicate = predicate;
    }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeInteger();
}
