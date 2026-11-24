using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>string@group</c>.</summary>
public readonly union StringGroup(
    ConcatStringGroup,
    UpperStringGroup,
    LowerStringGroup,
    FoldCaseStringGroup,
    NormalizeStringGroup,
    RemoveDiacriticsStringGroup,
    TrimStringGroup,
    TrimStartStringGroup,
    TrimEndStringGroup,
    SubstringStringGroup,
    ReplaceStringGroup,
    SplitPartStringGroup,
    PadStartStringGroup,
    PadEndStringGroup,
    RepeatStringGroup,
    ReverseStringGroup,
    ConcatWithGroup,
    ReplaceRegexStringGroup,
    AsStringDecimalStringGroup,
    AsStringBooleanStringGroup,
    AsStringDateStringGroup,
    AsStringTimeStringGroup,
    AsStringDatetimeStringGroup,
    AsStringUuidStringGroup,
    IfStringGroup,
    CoalesceStringGroup,
    GreatestStringGroup,
    LeastStringGroup,
    MinStringGroup,
    MaxStringGroup,
    FirstStringGroup,
    LastStringGroup,
    ConcatAllGroup,
    PercentileDiscreteStringGroup,
    ModeStringGroup,
    LiteralString,
    ParamString,
    KeyString
);
