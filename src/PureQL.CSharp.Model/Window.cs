namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>window</c>.</summary>
public readonly union Window(
    WindowWithoutFrameWithoutRange,
    WindowWithoutFrameWithRangeInteger,
    WindowWithoutFrameWithRangeDecimal,
    WindowWithoutFrameWithRangeDate,
    WindowWithoutFrameWithRangeDatetime,
    WindowWithFrame
);
