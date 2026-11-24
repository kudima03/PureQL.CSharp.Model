using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>string@row</c>.</summary>
public readonly union StringRow(
    ConcatStringRow,
    UpperStringRow,
    LowerStringRow,
    FoldCaseStringRow,
    NormalizeStringRow,
    RemoveDiacriticsStringRow,
    TrimStringRow,
    TrimStartStringRow,
    TrimEndStringRow,
    SubstringStringRow,
    ReplaceStringRow,
    SplitPartStringRow,
    PadStartStringRow,
    PadEndStringRow,
    RepeatStringRow,
    ReverseStringRow,
    ConcatWithRow,
    ReplaceRegexStringRow,
    AsStringDecimalStringRow,
    AsStringBooleanStringRow,
    AsStringDateStringRow,
    AsStringTimeStringRow,
    AsStringDatetimeStringRow,
    AsStringUuidStringRow,
    IfStringRow,
    CoalesceStringRow,
    GreatestStringRow,
    LeastStringRow,
    LiteralString,
    ParamString,
    FieldString
);
