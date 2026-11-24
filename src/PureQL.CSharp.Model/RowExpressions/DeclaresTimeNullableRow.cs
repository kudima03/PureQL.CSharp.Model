using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.time.nullable@row</c>.</summary>
public readonly union DeclaresTimeNullableRow(
    TimeAddSecondsTimeNullableRow,
    TimeFromPartsTimeNullableRow,
    StartOfHourTimeNullableRow,
    StartOfMinuteTimeNullableRow,
    StartOfSecondTimeNullableRow,
    AsTimeDatetimeTimeNullableRow,
    AsTimeStringTimeNullableRow,
    AsNullableTimeNullableRow,
    TryAsTimeRow,
    IfTimeNullableRow,
    CoalesceTimeNullableRow,
    NullIfEqualTimeNullableRow,
    GreatestTimeNullableRow,
    LeastTimeNullableRow,
    LiteralTimeNullable,
    ParamTimeNullable,
    FieldTimeNullable
);
