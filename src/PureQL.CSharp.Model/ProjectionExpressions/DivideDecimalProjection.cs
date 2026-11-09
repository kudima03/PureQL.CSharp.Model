using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>divide.decimal@projection</c>.</summary>
public sealed record DivideDecimalProjection : IOperator
{
    public DivideDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }

    public IType Type => new TypeDecimal();
}
