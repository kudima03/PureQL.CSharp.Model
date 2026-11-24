using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.boolean.nullable@total</c>.</summary>
public readonly union DeclaresBooleanNullableTotal(
    AsBooleanBooleanNullableTotal,
    AsNullableBooleanNullableTotal,
    TryAsBooleanTotal,
    IfBooleanNullableTotal,
    CoalesceBooleanNullableTotal,
    NullIfEqualBooleanNullableTotal,
    GreatestBooleanNullableTotal,
    LeastBooleanNullableTotal,
    MinBooleanNullableTotal,
    MaxBooleanNullableTotal,
    FirstBooleanNullableTotal,
    LastBooleanNullableTotal,
    PercentileDiscreteBooleanNullableTotal,
    ModeBooleanNullableTotal,
    LiteralBooleanNullable,
    ParamBooleanNullable
);
