namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>frame</c>.</summary>
public sealed record Frame
{
    public Frame(FrameRows? preceding = null, FrameRows? following = null)
    {
        Preceding = preceding;
        Following = following;
    }

    public FrameRows? Preceding { get; }

    public FrameRows? Following { get; }
}
