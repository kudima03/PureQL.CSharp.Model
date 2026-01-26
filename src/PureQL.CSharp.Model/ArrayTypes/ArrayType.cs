using OneOf;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed class ArrayType
    : OneOfBase<
        BooleanArrayType,
        DateArrayType,
        DateTimeArrayType,
        NullArrayType,
        NumberArrayType,
        TimeArrayType,
        UuidArrayType,
        StringArrayType
    >
{
    public ArrayType(BooleanArrayType type)
        : this(
            (OneOf<
                BooleanArrayType,
                DateArrayType,
                DateTimeArrayType,
                NullArrayType,
                NumberArrayType,
                TimeArrayType,
                UuidArrayType,
                StringArrayType
            >)
                type
        )
    { }

    public ArrayType(DateArrayType type)
        : this(
            (OneOf<
                BooleanArrayType,
                DateArrayType,
                DateTimeArrayType,
                NullArrayType,
                NumberArrayType,
                TimeArrayType,
                UuidArrayType,
                StringArrayType
            >)
                type
        )
    { }

    public ArrayType(DateTimeArrayType type)
        : this(
            (OneOf<
                BooleanArrayType,
                DateArrayType,
                DateTimeArrayType,
                NullArrayType,
                NumberArrayType,
                TimeArrayType,
                UuidArrayType,
                StringArrayType
            >)
                type
        )
    { }

    public ArrayType(NullArrayType type)
        : this(
            (OneOf<
                BooleanArrayType,
                DateArrayType,
                DateTimeArrayType,
                NullArrayType,
                NumberArrayType,
                TimeArrayType,
                UuidArrayType,
                StringArrayType
            >)
                type
        )
    { }

    public ArrayType(NumberArrayType type)
        : this(
            (OneOf<
                BooleanArrayType,
                DateArrayType,
                DateTimeArrayType,
                NullArrayType,
                NumberArrayType,
                TimeArrayType,
                UuidArrayType,
                StringArrayType
            >)
                type
        )
    { }

    public ArrayType(TimeArrayType type)
        : this(
            (OneOf<
                BooleanArrayType,
                DateArrayType,
                DateTimeArrayType,
                NullArrayType,
                NumberArrayType,
                TimeArrayType,
                UuidArrayType,
                StringArrayType
            >)
                type
        )
    { }

    public ArrayType(UuidArrayType type)
        : this(
            (OneOf<
                BooleanArrayType,
                DateArrayType,
                DateTimeArrayType,
                NullArrayType,
                NumberArrayType,
                TimeArrayType,
                UuidArrayType,
                StringArrayType
            >)
                type
        )
    { }

    public ArrayType(StringArrayType type)
        : this(
            (OneOf<
                BooleanArrayType,
                DateArrayType,
                DateTimeArrayType,
                NullArrayType,
                NumberArrayType,
                TimeArrayType,
                UuidArrayType,
                StringArrayType
            >)
                type
        )
    { }

    private ArrayType(
        OneOf<
            BooleanArrayType,
            DateArrayType,
            DateTimeArrayType,
            NullArrayType,
            NumberArrayType,
            TimeArrayType,
            UuidArrayType,
            StringArrayType
        > input
    )
        : base(input) { }
}
