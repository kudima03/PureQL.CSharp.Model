using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ValueGroup
    : OneOfBase<
        DecimalNullableGroup,
        StringNullableGroup,
        BooleanNullableGroup,
        DateNullableGroup,
        TimeNullableGroup,
        DatetimeNullableGroup,
        UuidNullableGroup
    >
{
    public ValueGroup(DecimalNullableGroup value)
        : this(
            (OneOf<
                DecimalNullableGroup,
                StringNullableGroup,
                BooleanNullableGroup,
                DateNullableGroup,
                TimeNullableGroup,
                DatetimeNullableGroup,
                UuidNullableGroup
            >)
                value
        )
    { }

    public ValueGroup(StringNullableGroup value)
        : this(
            (OneOf<
                DecimalNullableGroup,
                StringNullableGroup,
                BooleanNullableGroup,
                DateNullableGroup,
                TimeNullableGroup,
                DatetimeNullableGroup,
                UuidNullableGroup
            >)
                value
        )
    { }

    public ValueGroup(BooleanNullableGroup value)
        : this(
            (OneOf<
                DecimalNullableGroup,
                StringNullableGroup,
                BooleanNullableGroup,
                DateNullableGroup,
                TimeNullableGroup,
                DatetimeNullableGroup,
                UuidNullableGroup
            >)
                value
        )
    { }

    public ValueGroup(DateNullableGroup value)
        : this(
            (OneOf<
                DecimalNullableGroup,
                StringNullableGroup,
                BooleanNullableGroup,
                DateNullableGroup,
                TimeNullableGroup,
                DatetimeNullableGroup,
                UuidNullableGroup
            >)
                value
        )
    { }

    public ValueGroup(TimeNullableGroup value)
        : this(
            (OneOf<
                DecimalNullableGroup,
                StringNullableGroup,
                BooleanNullableGroup,
                DateNullableGroup,
                TimeNullableGroup,
                DatetimeNullableGroup,
                UuidNullableGroup
            >)
                value
        )
    { }

    public ValueGroup(DatetimeNullableGroup value)
        : this(
            (OneOf<
                DecimalNullableGroup,
                StringNullableGroup,
                BooleanNullableGroup,
                DateNullableGroup,
                TimeNullableGroup,
                DatetimeNullableGroup,
                UuidNullableGroup
            >)
                value
        )
    { }

    public ValueGroup(UuidNullableGroup value)
        : this(
            (OneOf<
                DecimalNullableGroup,
                StringNullableGroup,
                BooleanNullableGroup,
                DateNullableGroup,
                TimeNullableGroup,
                DatetimeNullableGroup,
                UuidNullableGroup
            >)
                value
        )
    { }

    private ValueGroup(
        OneOf<
            DecimalNullableGroup,
            StringNullableGroup,
            BooleanNullableGroup,
            DateNullableGroup,
            TimeNullableGroup,
            DatetimeNullableGroup,
            UuidNullableGroup
        > input
    )
        : base(input) { }
}
