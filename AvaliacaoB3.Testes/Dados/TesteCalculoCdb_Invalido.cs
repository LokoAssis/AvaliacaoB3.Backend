using System.Collections;

namespace AvaliacaoB3.Testes.Dados
{
    public class TesteCalculoCdb_Invalido : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 0, 0 };
            yield return new object[] { 100, -1 };
            yield return new object[] { -1, 100 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
