using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoB3.Testes.Dados
{
    public class TesteCdb_Sucesso : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1000, 6, 1042.8, 1055.23 };
            yield return new object[] { 1000, 12, 1090.81, 1113.51 };
            yield return new object[] { 1000, 24, 1197.92, 1239.9 };
            yield return new object[] { 1000, 30, 1262.13, 1308.38 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
