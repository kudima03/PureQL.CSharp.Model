namespace PureQL.CSharp.Model;

public interface IParameter
{
    public string Name { get; }

    public IType Type { get; }
}
