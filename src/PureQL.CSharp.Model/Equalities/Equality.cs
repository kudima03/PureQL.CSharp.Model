using OneOf;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Equalities;

public sealed class Equality
    : OneOfBase<
        BooleanEquality,
        DateEquality,
        DateTimeEquality,
        NumberEquality,
        StringEquality,
        TimeEquality,
        UuidReturning
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
                UuidReturning
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
                UuidReturning
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
                UuidReturning
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
                UuidReturning
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
                UuidReturning
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
                UuidReturning
            >)
                equality
        )
    { }

    public Equality(UuidReturning equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidReturning
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
            UuidReturning
        > input
    )
        : base(input) { }
}
