namespace NumberRetrievalHyperClient.Transforms
{
    public interface ITextTransform
    {
        string DeMess(string data);
        string Mess(string data);
    }
}