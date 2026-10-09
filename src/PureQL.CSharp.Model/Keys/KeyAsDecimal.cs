using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsDecimal : OneOfBase<KeyDecimal, KeyInteger>
{
    public KeyAsDecimal(KeyDecimal value)
        : this((OneOf<KeyDecimal, KeyInteger>)value) { }

    public KeyAsDecimal(KeyInteger value)
        : this((OneOf<KeyDecimal, KeyInteger>)value) { }

    private KeyAsDecimal(OneOf<KeyDecimal, KeyInteger> input)
        : base(input) { }
}
