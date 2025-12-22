using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class Field
    : OneOfBase<
        BooleanField,
        DateField,
        DateTimeField,
        NumberField,
        TimeField,
        UuidField,
        StringField
    >
{
    public Field(BooleanField field)
        : this(
            (OneOf<
                BooleanField,
                DateField,
                DateTimeField,
                NumberField,
                TimeField,
                UuidField,
                StringField
            >)
                field
        )
    { }

    public Field(DateField field)
        : this(
            (OneOf<
                BooleanField,
                DateField,
                DateTimeField,
                NumberField,
                TimeField,
                UuidField,
                StringField
            >)
                field
        )
    { }

    public Field(DateTimeField field)
        : this(
            (OneOf<
                BooleanField,
                DateField,
                DateTimeField,
                NumberField,
                TimeField,
                UuidField,
                StringField
            >)
                field
        )
    { }

    public Field(NumberField field)
        : this(
            (OneOf<
                BooleanField,
                DateField,
                DateTimeField,
                NumberField,
                TimeField,
                UuidField,
                StringField
            >)
                field
        )
    { }

    public Field(TimeField field)
        : this(
            (OneOf<
                BooleanField,
                DateField,
                DateTimeField,
                NumberField,
                TimeField,
                UuidField,
                StringField
            >)
                field
        )
    { }

    public Field(UuidField field)
        : this(
            (OneOf<
                BooleanField,
                DateField,
                DateTimeField,
                NumberField,
                TimeField,
                UuidField,
                StringField
            >)
                field
        )
    { }

    public Field(StringField field)
        : this(
            (OneOf<
                BooleanField,
                DateField,
                DateTimeField,
                NumberField,
                TimeField,
                UuidField,
                StringField
            >)
                field
        )
    { }

    private Field(
        OneOf<
            BooleanField,
            DateField,
            DateTimeField,
            NumberField,
            TimeField,
            UuidField,
            StringField
        > input
    )
        : base(input) { }
}
