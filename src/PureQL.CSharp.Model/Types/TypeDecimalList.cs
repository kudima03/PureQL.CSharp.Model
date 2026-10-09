namespace PureQL.CSharp.Model.Types;

public sealed record TypeDecimalList : IType
{
    public string Name => "decimalList";

    public bool Nullable => false;
}
