using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class InGroup
    : OneOfBase<
        InDecimalGroup,
        InStringGroup,
        InBooleanGroup,
        InDateGroup,
        InTimeGroup,
        InDatetimeGroup,
        InUuidGroup
    >
{
    public InGroup(InDecimalGroup value)
        : this(
            (OneOf<
                InDecimalGroup,
                InStringGroup,
                InBooleanGroup,
                InDateGroup,
                InTimeGroup,
                InDatetimeGroup,
                InUuidGroup
            >)
                value
        )
    { }

    public InGroup(InStringGroup value)
        : this(
            (OneOf<
                InDecimalGroup,
                InStringGroup,
                InBooleanGroup,
                InDateGroup,
                InTimeGroup,
                InDatetimeGroup,
                InUuidGroup
            >)
                value
        )
    { }

    public InGroup(InBooleanGroup value)
        : this(
            (OneOf<
                InDecimalGroup,
                InStringGroup,
                InBooleanGroup,
                InDateGroup,
                InTimeGroup,
                InDatetimeGroup,
                InUuidGroup
            >)
                value
        )
    { }

    public InGroup(InDateGroup value)
        : this(
            (OneOf<
                InDecimalGroup,
                InStringGroup,
                InBooleanGroup,
                InDateGroup,
                InTimeGroup,
                InDatetimeGroup,
                InUuidGroup
            >)
                value
        )
    { }

    public InGroup(InTimeGroup value)
        : this(
            (OneOf<
                InDecimalGroup,
                InStringGroup,
                InBooleanGroup,
                InDateGroup,
                InTimeGroup,
                InDatetimeGroup,
                InUuidGroup
            >)
                value
        )
    { }

    public InGroup(InDatetimeGroup value)
        : this(
            (OneOf<
                InDecimalGroup,
                InStringGroup,
                InBooleanGroup,
                InDateGroup,
                InTimeGroup,
                InDatetimeGroup,
                InUuidGroup
            >)
                value
        )
    { }

    public InGroup(InUuidGroup value)
        : this(
            (OneOf<
                InDecimalGroup,
                InStringGroup,
                InBooleanGroup,
                InDateGroup,
                InTimeGroup,
                InDatetimeGroup,
                InUuidGroup
            >)
                value
        )
    { }

    private InGroup(
        OneOf<
            InDecimalGroup,
            InStringGroup,
            InBooleanGroup,
            InDateGroup,
            InTimeGroup,
            InDatetimeGroup,
            InUuidGroup
        > input
    )
        : base(input) { }
}
