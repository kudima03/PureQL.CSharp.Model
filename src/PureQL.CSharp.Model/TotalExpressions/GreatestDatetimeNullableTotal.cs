using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.datetime.nullable@total</c>.</summary>
public sealed record GreatestDatetimeNullableTotal : IOperator
{
    public GreatestDatetimeNullableTotal(IEnumerable<DatetimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableTotal> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
