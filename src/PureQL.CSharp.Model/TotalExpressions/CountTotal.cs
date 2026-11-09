using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>count@total</c>.</summary>
public sealed record CountTotal : IOperator
{
    public CountTotal(BooleanRow? predicate = null)
    {
        Predicate = predicate;
    }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeInteger();
}
