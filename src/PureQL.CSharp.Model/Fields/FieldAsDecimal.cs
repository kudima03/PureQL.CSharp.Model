using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsDecimal : OneOfBase<FieldDecimal, FieldInteger>
{
    public FieldAsDecimal(FieldDecimal value)
        : this((OneOf<FieldDecimal, FieldInteger>)value) { }

    public FieldAsDecimal(FieldInteger value)
        : this((OneOf<FieldDecimal, FieldInteger>)value) { }

    private FieldAsDecimal(OneOf<FieldDecimal, FieldInteger> input)
        : base(input) { }
}
