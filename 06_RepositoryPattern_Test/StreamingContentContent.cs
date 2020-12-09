using _06_RepositoryPattern_Repository;
using System;

namespace _06_RepositoryPattern_Test
{
    internal class StreamingContentContent
    {
        public static implicit operator StreamingContentContent(StreamingContentRepository v)
        {
            throw new NotImplementedException();
        }
    }
}