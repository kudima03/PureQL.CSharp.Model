using OneOf;

namespace PureQL.CSharp.Model.ArrayEqualities;

public sealed class ArrayEquality
    : OneOfBase<
        BooleanArrayEquality,
        DateArrayEquality,
        DateTimeArrayEquality,
        NumberArrayEquality,
        StringArrayEquality,
        TimeArrayEquality,
        UuidArrayEquality
    >
{
    public ArrayEquality(BooleanArrayEquality equality)
        : this(
            (OneOf<
                BooleanArrayEquality,
                DateArrayEquality,
                DateTimeArrayEquality,
                NumberArrayEquality,
                StringArrayEquality,
                TimeArrayEquality,
                UuidArrayEquality
            >)
                equality
        )
    { }

    public ArrayEquality(DateArrayEquality equality)
        : this(
            (OneOf<
                BooleanArrayEquality,
                DateArrayEquality,
                DateTimeArrayEquality,
                NumberArrayEquality,
                StringArrayEquality,
                TimeArrayEquality,
                UuidArrayEquality
            >)
                equality
        )
    { }

    public ArrayEquality(DateTimeArrayEquality equality)
        : this(
            (OneOf<
                BooleanArrayEquality,
                DateArrayEquality,
                DateTimeArrayEquality,
                NumberArrayEquality,
                StringArrayEquality,
                TimeArrayEquality,
                UuidArrayEquality
            >)
                equality
        )
    { }

    public ArrayEquality(NumberArrayEquality equality)
        : this(
            (OneOf<
                BooleanArrayEquality,
                DateArrayEquality,
                DateTimeArrayEquality,
                NumberArrayEquality,
                StringArrayEquality,
                TimeArrayEquality,
                UuidArrayEquality
            >)
                equality
        )
    { }

    public ArrayEquality(StringArrayEquality equality)
        : this(
            (OneOf<
                BooleanArrayEquality,
                DateArrayEquality,
                DateTimeArrayEquality,
                NumberArrayEquality,
                StringArrayEquality,
                TimeArrayEquality,
                UuidArrayEquality
            >)
                equality
        )
    { }

    public ArrayEquality(TimeArrayEquality equality)
        : this(
            (OneOf<
                BooleanArrayEquality,
                DateArrayEquality,
                DateTimeArrayEquality,
                NumberArrayEquality,
                StringArrayEquality,
                TimeArrayEquality,
                UuidArrayEquality
            >)
                equality
        )
    { }

    public ArrayEquality(UuidArrayEquality equality)
        : this(
            (OneOf<
                BooleanArrayEquality,
                DateArrayEquality,
                DateTimeArrayEquality,
                NumberArrayEquality,
                StringArrayEquality,
                TimeArrayEquality,
                UuidArrayEquality
            >)
                equality
        )
    { }

    private ArrayEquality(
        OneOf<
            BooleanArrayEquality,
            DateArrayEquality,
            DateTimeArrayEquality,
            NumberArrayEquality,
            StringArrayEquality,
            TimeArrayEquality,
            UuidArrayEquality
        > input
    )
        : base(input) { }
}
