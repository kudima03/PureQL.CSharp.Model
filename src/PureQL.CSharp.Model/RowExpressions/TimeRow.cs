using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>time@row</c>.</summary>
public readonly union TimeRow(
    TimeAddSecondsTimeRow,
    IfTimeRow,
    CoalesceTimeRow,
    LiteralTime,
    ParamTime,
    FieldTime
);
