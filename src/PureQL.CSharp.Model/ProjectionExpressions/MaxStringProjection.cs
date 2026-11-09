using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.string@projection</c>.</summary>
public sealed record MaxStringProjection : IOperator
{
    public MaxStringProjection(StringRow selector)
    {
        Selector = selector;
    }

    public StringRow Selector { get; }

    public IType Type => new TypeString();
}
