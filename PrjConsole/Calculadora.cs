namespace PrjConsole
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            int res1 = val1 + val2;
            listaHistorico.Insert(0, "Teste de somar ("+val1+" + "+val2+" = "+res1+" - Data: "+data);
            return res1;
        }

        public int subtrair(int val1, int val2)
        {
            int res1 = val1 - val2;
            listaHistorico.Insert(0, "Teste de subtrair ("+val1+" - "+val2+" = "+res1+" - Data: "+data);
            return res1;
        }

        public int multiplicar(int val1, int val2)
        {
            int res1 = val1 * val2;
            listaHistorico.Insert(0, "Teste de multiplicar ("+val1+" * "+val2+" = "+res1+" - Data: "+data);
            return res1;
        }

        public int dividir(int val1, int val2)
        {
            int res1 = val1 / val2;
            listaHistorico.Insert(0, "Teste de dividir ("+val1+" / "+val2+" = "+res1+" - Data: "+data);
            return res1;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
