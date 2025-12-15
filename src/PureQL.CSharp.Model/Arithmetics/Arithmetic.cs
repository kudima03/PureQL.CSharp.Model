using OneOf;

namespace PureQL.CSharp.Model.Arithmetics;

public sealed class Arithmetic : OneOfBase<Add, Divide, Multiply, Subtract>
{
    public Arithmetic(Add field)
        : this((OneOf<Add, Divide, Multiply, Subtract>)field) { }

    public Arithmetic(Divide field)
        : this((OneOf<Add, Divide, Multiply, Subtract>)field) { }

    public Arithmetic(Multiply field)
        : this((OneOf<Add, Divide, Multiply, Subtract>)field) { }

    public Arithmetic(Subtract field)
        : this((OneOf<Add, Divide, Multiply, Subtract>)field) { }

    private Arithmetic(OneOf<Add, Divide, Multiply, Subtract> input)
        : base(input) { }
}
