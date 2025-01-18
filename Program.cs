namespace Consecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = [1, 1, 1, 1, 1];
            int k = 5;
            if (ExistenConsecutivos(a, k)) Console.WriteLine("true");
            else Console.WriteLine("false");
        }

        static bool ExistenConsecutivos(int[] array, int k)
        {
            List<bool> listExiteCons = new();
            for (int i = 0; i < array.Length; i++)
            {
                bool existecons = true;
                for (int j = 1; j < k; j++)
                {
                    if (i + j >= array.Length || array[i] != array[i + j])
                    {
                        existecons = false;
                        break;
                    }
                }

                listExiteCons.Add(existecons);
            }

            for (int i = 0; i < listExiteCons.Count; i++)
            {
                if (listExiteCons[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
