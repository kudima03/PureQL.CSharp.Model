using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExprGroup
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
    public ExprGroup(DecimalNullableGroup value)
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

    public ExprGroup(StringNullableGroup value)
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

    public ExprGroup(BooleanNullableGroup value)
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

    public ExprGroup(DateNullableGroup value)
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

    public ExprGroup(TimeNullableGroup value)
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

    public ExprGroup(DatetimeNullableGroup value)
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

    public ExprGroup(UuidNullableGroup value)
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

    private ExprGroup(
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
