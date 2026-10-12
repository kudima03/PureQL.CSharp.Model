using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinUuidProjection : IOperator
{
    public MinUuidProjection(UuidRow selector)
    {
        Selector = selector;
    }

    public UuidRow Selector { get; }

    public IType Type => new TypeUuid();
}
