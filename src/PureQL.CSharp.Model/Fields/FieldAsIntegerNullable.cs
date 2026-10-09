using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsIntegerNullable : OneOfBase<FieldInteger, FieldIntegerNullable>
{
    public FieldAsIntegerNullable(FieldInteger value)
        : this((OneOf<FieldInteger, FieldIntegerNullable>)value) { }

    public FieldAsIntegerNullable(FieldIntegerNullable value)
        : this((OneOf<FieldInteger, FieldIntegerNullable>)value) { }

    private FieldAsIntegerNullable(OneOf<FieldInteger, FieldIntegerNullable> input)
        : base(input) { }
}
