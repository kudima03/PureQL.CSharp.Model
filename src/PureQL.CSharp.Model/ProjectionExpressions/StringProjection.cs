using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>string@projection</c>.</summary>
public readonly union StringProjection(
    ConcatStringProjection,
    UpperStringProjection,
    LowerStringProjection,
    FoldCaseStringProjection,
    NormalizeStringProjection,
    RemoveDiacriticsStringProjection,
    TrimStringProjection,
    TrimStartStringProjection,
    TrimEndStringProjection,
    SubstringStringProjection,
    ReplaceStringProjection,
    SplitPartStringProjection,
    PadStartStringProjection,
    PadEndStringProjection,
    RepeatStringProjection,
    ReverseStringProjection,
    ConcatWithProjection,
    ReplaceRegexStringProjection,
    AsStringDecimalStringProjection,
    AsStringBooleanStringProjection,
    AsStringDateStringProjection,
    AsStringTimeStringProjection,
    AsStringDatetimeStringProjection,
    AsStringUuidStringProjection,
    IfStringProjection,
    CoalesceStringProjection,
    GreatestStringProjection,
    LeastStringProjection,
    MinStringProjection,
    MaxStringProjection,
    FirstStringProjection,
    LastStringProjection,
    ConcatAllProjection,
    PercentileDiscreteStringProjection,
    ModeStringProjection,
    PreviousStringProjection,
    NextStringProjection,
    LiteralString,
    ParamString,
    FieldString
);
