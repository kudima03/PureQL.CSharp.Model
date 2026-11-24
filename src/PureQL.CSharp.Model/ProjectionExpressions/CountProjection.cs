using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>count@projection</c>.</summary>
public sealed record CountProjection : IOperator
{
    public CountProjection(BooleanRow? predicate = null, Window? over = null)
    {
        Predicate = predicate;
        Over = over;
    }

    public BooleanRow? Predicate { get; }

    public Window? Over { get; }

    public IType Type => new TypeInteger();
}
