using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetime.nullable@row</c>.</summary>
public readonly union DatetimeNullableRow(
    DatetimeAddSecondsDatetimeRow,
    IfDatetimeRow,
    CoalesceDatetimeRow,
    LiteralDatetime,
    ParamDatetime,
    FieldDatetime,
    DatetimeAddSecondsDatetimeNullableRow,
    IfDatetimeNullableRow,
    CoalesceDatetimeNullableRow,
    LiteralDatetimeNullable,
    ParamDatetimeNullable,
    FieldDatetimeNullable
);
