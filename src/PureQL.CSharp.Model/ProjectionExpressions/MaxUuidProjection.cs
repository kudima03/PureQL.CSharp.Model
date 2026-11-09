using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.uuid@projection</c>.</summary>
public sealed record MaxUuidProjection : IOperator
{
    public MaxUuidProjection(UuidRow selector)
    {
        Selector = selector;
    }

    public UuidRow Selector { get; }

    public IType Type => new TypeUuid();
}
