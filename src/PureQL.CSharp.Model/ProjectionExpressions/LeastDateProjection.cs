using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.date@projection</c>.</summary>
public sealed record LeastDateProjection : IOperator
{
    public LeastDateProjection(IEnumerable<DateProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DateProjection> Values { get; }

    public IType Type => new TypeDate();
}
