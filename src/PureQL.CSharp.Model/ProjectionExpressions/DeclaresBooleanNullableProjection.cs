using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.boolean.nullable@projection</c>.</summary>
public readonly union DeclaresBooleanNullableProjection(
    AsBooleanBooleanNullableProjection,
    AsNullableBooleanNullableProjection,
    TryAsBooleanProjection,
    IfBooleanNullableProjection,
    CoalesceBooleanNullableProjection,
    NullIfEqualBooleanNullableProjection,
    GreatestBooleanNullableProjection,
    LeastBooleanNullableProjection,
    MinBooleanNullableProjection,
    MaxBooleanNullableProjection,
    FirstBooleanNullableProjection,
    LastBooleanNullableProjection,
    PercentileDiscreteBooleanNullableProjection,
    ModeBooleanNullableProjection,
    PreviousBooleanNullableProjection,
    NextBooleanNullableProjection,
    LiteralBooleanNullable,
    ParamBooleanNullable,
    FieldBooleanNullable
);
