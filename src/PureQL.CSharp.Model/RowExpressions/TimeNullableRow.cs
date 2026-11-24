using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>time.nullable@row</c>.</summary>
public readonly union TimeNullableRow(
    TimeAddSecondsTimeRow,
    TimeFromPartsTimeRow,
    StartOfHourTimeRow,
    StartOfMinuteTimeRow,
    StartOfSecondTimeRow,
    AsTimeDatetimeTimeRow,
    AsTimeStringTimeRow,
    IfTimeRow,
    CoalesceTimeRow,
    GreatestTimeRow,
    LeastTimeRow,
    LiteralTime,
    ParamTime,
    FieldTime,
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
