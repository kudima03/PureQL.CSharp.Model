using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateDatetimeNullableGroup
    : OneOfBase<
        AverageDatetimeNullableGroup,
        MinDatetimeNullableGroup,
        MaxDatetimeNullableGroup
    >
{
    public AggregateDatetimeNullableGroup(AverageDatetimeNullableGroup value)
        : this(
            (OneOf<
                AverageDatetimeNullableGroup,
                MinDatetimeNullableGroup,
                MaxDatetimeNullableGroup
            >)
                value
        )
    { }

    public AggregateDatetimeNullableGroup(MinDatetimeNullableGroup value)
        : this(
            (OneOf<
                AverageDatetimeNullableGroup,
                MinDatetimeNullableGroup,
                MaxDatetimeNullableGroup
            >)
                value
        )
    { }

    public AggregateDatetimeNullableGroup(MaxDatetimeNullableGroup value)
        : this(
            (OneOf<
                AverageDatetimeNullableGroup,
                MinDatetimeNullableGroup,
                MaxDatetimeNullableGroup
            >)
                value
        )
    { }

    private AggregateDatetimeNullableGroup(
        OneOf<
            AverageDatetimeNullableGroup,
            MinDatetimeNullableGroup,
            MaxDatetimeNullableGroup
        > input
    )
        : base(input) { }
}
