using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>multiply.integer@projection</c>.</summary>
public sealed record MultiplyIntegerProjection : IOperator
{
    public MultiplyIntegerProjection(IEnumerable<IntegerProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerProjection> Values { get; }

    public IType Type => new TypeInteger();
}
