using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AverageDecimalProjection : IOperator
{
    public AverageDecimalProjection(DecimalRow selector)
    {
        Selector = selector;
    }

    public DecimalRow Selector { get; }

    public IType Type => new TypeDecimal();
}
