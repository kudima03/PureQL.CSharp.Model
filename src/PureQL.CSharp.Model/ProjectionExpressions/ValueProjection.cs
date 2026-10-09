using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ValueProjection
    : OneOfBase<
        DecimalNullableProjection,
        StringNullableProjection,
        BooleanNullableProjection,
        DateNullableProjection,
        TimeNullableProjection,
        DatetimeNullableProjection,
        UuidNullableProjection
    >
{
    public ValueProjection(DecimalNullableProjection value)
        : this(
            (OneOf<
                DecimalNullableProjection,
                StringNullableProjection,
                BooleanNullableProjection,
                DateNullableProjection,
                TimeNullableProjection,
                DatetimeNullableProjection,
                UuidNullableProjection
            >)
                value
        )
    { }

    public ValueProjection(StringNullableProjection value)
        : this(
            (OneOf<
                DecimalNullableProjection,
                StringNullableProjection,
                BooleanNullableProjection,
                DateNullableProjection,
                TimeNullableProjection,
                DatetimeNullableProjection,
                UuidNullableProjection
            >)
                value
        )
    { }

    public ValueProjection(BooleanNullableProjection value)
        : this(
            (OneOf<
                DecimalNullableProjection,
                StringNullableProjection,
                BooleanNullableProjection,
                DateNullableProjection,
                TimeNullableProjection,
                DatetimeNullableProjection,
                UuidNullableProjection
            >)
                value
        )
    { }

    public ValueProjection(DateNullableProjection value)
        : this(
            (OneOf<
                DecimalNullableProjection,
                StringNullableProjection,
                BooleanNullableProjection,
                DateNullableProjection,
                TimeNullableProjection,
                DatetimeNullableProjection,
                UuidNullableProjection
            >)
                value
        )
    { }

    public ValueProjection(TimeNullableProjection value)
        : this(
            (OneOf<
                DecimalNullableProjection,
                StringNullableProjection,
                BooleanNullableProjection,
                DateNullableProjection,
                TimeNullableProjection,
                DatetimeNullableProjection,
                UuidNullableProjection
            >)
                value
        )
    { }

    public ValueProjection(DatetimeNullableProjection value)
        : this(
            (OneOf<
                DecimalNullableProjection,
                StringNullableProjection,
                BooleanNullableProjection,
                DateNullableProjection,
                TimeNullableProjection,
                DatetimeNullableProjection,
                UuidNullableProjection
            >)
                value
        )
    { }

    public ValueProjection(UuidNullableProjection value)
        : this(
            (OneOf<
                DecimalNullableProjection,
                StringNullableProjection,
                BooleanNullableProjection,
                DateNullableProjection,
                TimeNullableProjection,
                DatetimeNullableProjection,
                UuidNullableProjection
            >)
                value
        )
    { }

    private ValueProjection(
        OneOf<
            DecimalNullableProjection,
            StringNullableProjection,
            BooleanNullableProjection,
            DateNullableProjection,
            TimeNullableProjection,
            DatetimeNullableProjection,
            UuidNullableProjection
        > input
    )
        : base(input) { }
}
