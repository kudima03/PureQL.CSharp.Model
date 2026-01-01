using OneOf;

namespace PureQL.CSharp.Model.Equalities;

public sealed class Equality
    : OneOfBase<
        BooleanEquality,
        DateEquality,
        DateTimeEquality,
        NumberEquality,
        StringEquality,
        TimeEquality,
        UuidEquality
    >
{
    public Equality(BooleanEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public Equality(DateEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public Equality(DateTimeEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public Equality(NumberEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public Equality(StringEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public Equality(TimeEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public Equality(UuidEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    private Equality(
        OneOf<
            BooleanEquality,
            DateEquality,
            DateTimeEquality,
            NumberEquality,
            StringEquality,
            TimeEquality,
            UuidEquality
        > input
    )
        : base(input) { }
}
