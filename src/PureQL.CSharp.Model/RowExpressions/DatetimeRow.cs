using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetime@row</c>.</summary>
public readonly union DatetimeRow(
    DatetimeAddSecondsDatetimeRow,
    IfDatetimeRow,
    CoalesceDatetimeRow,
    LiteralDatetime,
    ParamDatetime,
    FieldDatetime
);
