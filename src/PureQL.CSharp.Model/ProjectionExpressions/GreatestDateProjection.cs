using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.date@projection</c>.</summary>
public sealed record GreatestDateProjection : IOperator
{
    public GreatestDateProjection(IEnumerable<DateProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DateProjection> Values { get; }

    public IType Type => new TypeDate();
}
