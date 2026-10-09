using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsStringNullable : OneOfBase<FieldString, FieldStringNullable>
{
    public FieldAsStringNullable(FieldString value)
        : this((OneOf<FieldString, FieldStringNullable>)value) { }

    public FieldAsStringNullable(FieldStringNullable value)
        : this((OneOf<FieldString, FieldStringNullable>)value) { }

    private FieldAsStringNullable(OneOf<FieldString, FieldStringNullable> input)
        : base(input) { }
}
