using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>string@total</c>.</summary>
public readonly union StringTotal(
    ConcatStringTotal,
    UpperStringTotal,
    LowerStringTotal,
    FoldCaseStringTotal,
    NormalizeStringTotal,
    RemoveDiacriticsStringTotal,
    TrimStringTotal,
    TrimStartStringTotal,
    TrimEndStringTotal,
    SubstringStringTotal,
    ReplaceStringTotal,
    SplitPartStringTotal,
    PadStartStringTotal,
    PadEndStringTotal,
    RepeatStringTotal,
    ReverseStringTotal,
    ConcatWithTotal,
    ReplaceRegexStringTotal,
    AsStringDecimalStringTotal,
    AsStringBooleanStringTotal,
    AsStringDateStringTotal,
    AsStringTimeStringTotal,
    AsStringDatetimeStringTotal,
    AsStringUuidStringTotal,
    IfStringTotal,
    CoalesceStringTotal,
    GreatestStringTotal,
    LeastStringTotal,
    ConcatAllTotal,
    LiteralString,
    ParamString
);
