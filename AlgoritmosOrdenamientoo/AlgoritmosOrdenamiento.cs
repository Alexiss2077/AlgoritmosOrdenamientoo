using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosOrdenamientoo
{
    internal class AlgoritmosOrdenamiento
    {
        //Contadores para comparaciones e intercambios
        public static long SwapCount = 0;
        public static long ComparisonCount = 0;


        public int Divisiones { get; set; }
        public int Mezclas { get; set; }

        public AlgoritmosOrdenamiento()
        {
            Divisiones = 0;
            Mezclas = 0;
        }
        ////////// 1. Bubble Sort //////////

        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++) // controla las pasadas
            {
                swapped = false; // bandera para detectar si hubo intercambios

                for (int j = 0; j < n - i - 1; j++)
                {
                    ComparisonCount++;
                    if (array[j] > array[j + 1])
                    {
                        Exchange(array, j, j + 1);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // 2. COCKTAIL SORT-BURBUJA BIDIRECCIONAL
        public static void CocktailSort(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length;

            while (swapped)
            {
                swapped = false;

                // --- IDA (Izquierda -> Derecha) ---
                // Lleva el más grande al final
                for (int i = start; i < end - 1; i++)
                {
                    ComparisonCount++;
                    if (array[i] > array[i + 1])
                    {
                        Exchange(array, i, i + 1);
                        swapped = true;
                    }
                }

                if (!swapped) break; // Si no hubo cambios, terminamos

                swapped = false;
                end = end - 1; // "Protegemos" la última posición que ya tiene al mayor

                // --- VUELTA (Derecha -> Izquierda) ---
                for (int i = end - 2; i >= start; i--)
                {
                    ComparisonCount++;
                    if (array[i] > array[i + 1])
                    {
                        Exchange(array, i, i + 1);
                        swapped = true;
                    }
                }

                start = start + 1; // "Protegemos" la primera posición
            }
        }
        /// Helper method to swap two elements in an array.
        private static void Exchange(int[] array, int index1, int index2)
        {
            if (index1 == index2) return;
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            SwapCount++;
        }




        /// 3. Insertion Sort
        public static void InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int actual = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > actual)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = actual;
            }
        }




        // / 4. Selection Sort
        ////Pendiente
        ///













        ////5. Merge Sort
        // Contadores de operaciones
        

        // =======================================================
        // MÉTODO MERGE 
        // =======================================================
        public void Merge(List<int> myList, List<int> left, List<int> right)
        {
            Mezclas++;
            int i = 0; // índice izquierda
            int j = 0; // índice derecha
            int k = 0; // índice destino

            // 1. Comparar y escribir el menor en destino
            while (i < left.Count && j < right.Count)
            {
                //ComparisonCount++;  // contar comparación

                if (left[i] < right[j])
                {
                    myList[k] = left[i];
                    //MoveCount++;
                    i++;
                }
                else
                {
                    myList[k] = right[j];
                    //MoveCount++;
                    j++;
                }

                k++;
            }

            // 2. Si sobran elementos en izquierda
            while (i < left.Count)
            {
                myList[k] = left[i];
                //MoveCount++;
                i++;
                k++;
            }

            // 3. Si sobran elementos en derecha
            while (j < right.Count)
            {
                myList[k] = right[j];
                //MoveCount++;
                j++;
                k++;
            }
        }

        // =======================================================
        // MERGE SORT RECURSIVO
        // =======================================================
        public void SortRecursivo(List<int> myList)
        {
            if (myList.Count <= 1)
                return;

            Divisiones++;

            int mid = myList.Count / 2;

            List<int> leftHalf = new List<int>(myList.GetRange(0, mid));
            List<int> rightHalf = new List<int>(myList.GetRange(mid, myList.Count - mid));

            // Ordenar mitades
            SortRecursivo(leftHalf);
            SortRecursivo(rightHalf);

            // Combinar usando merge (i, j, k)
            Merge(myList, leftHalf, rightHalf);
        }

        // =======================================================
        // MERGE SORT NATURAL
        // =======================================================
        public void SortNatural(List<int> myList)
        {
            bool ordenado = false;
            bool primeraVez = true;

            while (!ordenado)
            {
                var runs = GetNaturalRuns(myList);

                if (primeraVez)
                {
                    Divisiones = runs.Count;
                    primeraVez = false;
                }

                // Si solo existe una secuencia ya está ordenado
                if (runs.Count <= 1)
                {
                    ordenado = true;
                    return;
                }

                List<List<int>> nuevasSecuencias = new List<List<int>>();

                // Mezclar secuencias de 2 en 2
                while (runs.Count > 1)
                {
                    var seq1 = runs[0];
                    runs.RemoveAt(0);

                    var seq2 = runs[0];
                    runs.RemoveAt(0);

                    int tamanoTotal = seq1.Count + seq2.Count;
                    List<int> mezclar = new List<int>(new int[tamanoTotal]);

                    // Usar merge (i, j, k)
                    Merge(mezclar, seq1, seq2);

                    nuevasSecuencias.Add(mezclar);
                }

                // Si queda una secuencia impar
                if (runs.Count == 1)
                    nuevasSecuencias.Add(runs[0]);

                // Reconstruir lista
                myList.Clear();
                foreach (var seq in nuevasSecuencias)
                    myList.AddRange(seq);
            }
        }

        // =======================================================
        // OBTENER RUNS NATURALES
        // =======================================================
        public List<List<int>> GetNaturalRuns(List<int> myList)
        {
            List<List<int>> runs = new List<List<int>>();

            if (myList.Count == 0)
                return runs;

            List<int> actual = new List<int> { myList[0] };

            for (int i = 1; i < myList.Count; i++)
            {

                if (myList[i] >= myList[i - 1])
                {
                    actual.Add(myList[i]);
                }
                else
                {
                    runs.Add(actual);
                    actual = new List<int> { myList[i] };
                }
            }

            runs.Add(actual);
            return runs;
        }


    }
}

