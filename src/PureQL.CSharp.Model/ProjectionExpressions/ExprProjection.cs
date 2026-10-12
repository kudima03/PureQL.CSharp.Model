using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExprProjection
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
    public ExprProjection(DecimalNullableProjection value)
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

    public ExprProjection(StringNullableProjection value)
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

    public ExprProjection(BooleanNullableProjection value)
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

    public ExprProjection(DateNullableProjection value)
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

    public ExprProjection(TimeNullableProjection value)
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

    public ExprProjection(DatetimeNullableProjection value)
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

    public ExprProjection(UuidNullableProjection value)
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

    private ExprProjection(
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
