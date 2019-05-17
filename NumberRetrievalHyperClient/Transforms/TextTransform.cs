using System;
using System.Linq;

namespace NumberRetrievalHyperClient.Transforms
{
    public class TextTransform : ITextTransform
    {
        public string DeMess(string data)
        {
            //Oh crap, I hope it isn't one way
            throw new NotImplementedException();
        }

        public string Mess(string data)
        {
            var messedData = data
                .Select((x, i) => (byte)(x + i + 1))
                .ToArray();

            return Convert.ToBase64String(messedData);
        }
    }
}
