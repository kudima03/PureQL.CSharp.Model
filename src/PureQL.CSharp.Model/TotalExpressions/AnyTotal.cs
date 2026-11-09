using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>any@total</c>.</summary>
public sealed record AnyTotal : IOperator
{
    public AnyTotal(BooleanRow predicate)
    {
        Predicate = predicate;
    }

    public BooleanRow Predicate { get; }

    public IType Type => new TypeBoolean();
}
