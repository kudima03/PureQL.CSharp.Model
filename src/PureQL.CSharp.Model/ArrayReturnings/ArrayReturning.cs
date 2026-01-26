using OneOf;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class ArrayReturning
    : OneOfBase<
        BooleanArrayReturning,
        DateArrayReturning,
        DateTimeArrayReturning,
        NumberArrayReturning,
        StringArrayReturning,
        TimeArrayReturning,
        UuidArrayReturning
    >
{
    public ArrayReturning(BooleanArrayReturning returning)
        : this(
            (OneOf<
                BooleanArrayReturning,
                DateArrayReturning,
                DateTimeArrayReturning,
                NumberArrayReturning,
                StringArrayReturning,
                TimeArrayReturning,
                UuidArrayReturning
            >)
                returning
        )
    { }

    public ArrayReturning(DateArrayReturning returning)
        : this(
            (OneOf<
                BooleanArrayReturning,
                DateArrayReturning,
                DateTimeArrayReturning,
                NumberArrayReturning,
                StringArrayReturning,
                TimeArrayReturning,
                UuidArrayReturning
            >)
                returning
        )
    { }

    public ArrayReturning(DateTimeArrayReturning returning)
        : this(
            (OneOf<
                BooleanArrayReturning,
                DateArrayReturning,
                DateTimeArrayReturning,
                NumberArrayReturning,
                StringArrayReturning,
                TimeArrayReturning,
                UuidArrayReturning
            >)
                returning
        )
    { }

    public ArrayReturning(NumberArrayReturning returning)
        : this(
            (OneOf<
                BooleanArrayReturning,
                DateArrayReturning,
                DateTimeArrayReturning,
                NumberArrayReturning,
                StringArrayReturning,
                TimeArrayReturning,
                UuidArrayReturning
            >)
                returning
        )
    { }

    public ArrayReturning(StringArrayReturning returning)
        : this(
            (OneOf<
                BooleanArrayReturning,
                DateArrayReturning,
                DateTimeArrayReturning,
                NumberArrayReturning,
                StringArrayReturning,
                TimeArrayReturning,
                UuidArrayReturning
            >)
                returning
        )
    { }

    public ArrayReturning(TimeArrayReturning returning)
        : this(
            (OneOf<
                BooleanArrayReturning,
                DateArrayReturning,
                DateTimeArrayReturning,
                NumberArrayReturning,
                StringArrayReturning,
                TimeArrayReturning,
                UuidArrayReturning
            >)
                returning
        )
    { }

    public ArrayReturning(UuidArrayReturning returning)
        : this(
            (OneOf<
                BooleanArrayReturning,
                DateArrayReturning,
                DateTimeArrayReturning,
                NumberArrayReturning,
                StringArrayReturning,
                TimeArrayReturning,
                UuidArrayReturning
            >)
                returning
        )
    { }

    private ArrayReturning(
        OneOf<
            BooleanArrayReturning,
            DateArrayReturning,
            DateTimeArrayReturning,
            NumberArrayReturning,
            StringArrayReturning,
            TimeArrayReturning,
            UuidArrayReturning
        > input
    )
        : base(input) { }
}
