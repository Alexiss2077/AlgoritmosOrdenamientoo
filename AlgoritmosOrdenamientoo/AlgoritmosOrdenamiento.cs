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
        //1. Bubble Sort 

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


        ///// PENDIENTEEE










        ////5. Merge Sort

        // MÉTODO MERGE 
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

        // MERGE SORT RECURSIVO
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

 
        // MERGE SORT NATURAL
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

        // OBTENER RUNS NATURALES
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





        // 6. Heap Sort

        private static void Heapify(int[] arr, int n, int i, ref int comparisons, ref int swaps)
        {
            // El mayor es la raíz del subárbol
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n)
            {
                comparisons++;
                if (arr[l] > arr[largest])
                    largest = l;
            }

            if (r < n)
            {
                comparisons++;
                if (arr[r] > arr[largest])
                    largest = r;
            }

            // Intercambia elementos
            if (largest != i)
            {
                swaps++;
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, n, largest, ref comparisons, ref swaps);
            }
        }
        public static void HeapSort(int[] arr, ref int comparisons, ref int swaps)
        {
            int n = arr.Length;

            // Construir Max-Heap. Desde el último nodo padre hacia la raíz
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i, ref comparisons, ref swaps);

            // Extraer elementos.
            for (int i = n - 1; i > 0; i--)
            {
                swaps++;
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                // Reparar el heap reducido
                Heapify(arr, i, 0, ref comparisons, ref swaps);
            }

        }


        // WRAPPER PARA HEAP SORT
        public static void HeapSortWrapper(int[] arr)
        {
            int comparisons = 0;
            int swaps = 0;

            HeapSort(arr, ref comparisons, ref swaps);

            ComparisonCount = comparisons;
            SwapCount = swaps;
        }




        // 7. Shell Sort

        public static void ShellSort(int[] arr)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }
            }
        }




        // 8. Gnome Sort
        public static void GnomeSort(int[] array)
        {
            int index = 0;

            // Recorremos el array hasta ordenar
            while (index < array.Length)
            {
                // (opcional) contar la comprobación del while si quieres medirla:
                ComparisonCount++; // cuenta la comprobación index < array.Length

                // Si estamos en la primera posición, avanzamos
                if (index == 0)
                {
                    index++;
                    continue;
                }

                // Comparamos el elemento actual con el anterior
                ComparisonCount++; // cuenta la comparación array[index] >= array[index - 1]
                if (array[index] >= array[index - 1])
                {
                    // si está en orden, avanzamos
                    index++;
                }
                else
                {
                    // si no, intercambiamos y retrocedemos
                    Exchange(array, index, index - 1);
                    index--;
                }
            }
        }



        // 9. Counting Sort

        public static void CountingSort(int[] arr)
        {
            int n = arr.Length;

            // Obtener el valor máximo para definir el rango
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                AlgoritmosOrdenamiento.ComparisonCount++;
                if (arr[i] > max)
                    max = arr[i];
            }

            int[] count = new int[max + 1];
            int[] output = new int[n];

            // Conteo de ocurrencias
            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
                AlgoritmosOrdenamiento.ComparisonCount++;
            }

            // Conteo acumulado
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
                AlgoritmosOrdenamiento.ComparisonCount++;
            }

            // Construcción del arreglo ordenado
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
                AlgoritmosOrdenamiento.SwapCount++;
            }

            // Copiar al arreglo original
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
                AlgoritmosOrdenamiento.SwapCount++;
            }
        }



        // 10. Bucket Sort


        public static void BucketSort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return;

            int n = arr.Length;

            // Buscar valor máximo
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                ComparisonCount++;
                if (arr[i] > max)
                    max = arr[i];
            }

            // Definir número de buckets
            int bucketCount = (int)Math.Sqrt(n); // criterio común
            List<int>[] buckets = new List<int>[bucketCount];

            for (int i = 0; i < bucketCount; i++)
                buckets[i] = new List<int>();

            //Distribuir elementos en buckets (por rangos)
            for (int i = 0; i < n; i++)
            {
                int index = (arr[i] * bucketCount) / (max + 1);
                buckets[index].Add(arr[i]);
                SwapCount++;
            }

            //Ordenar cada bucket (Insertion Sort)
            for (int i = 0; i < bucketCount; i++)
            {
                for (int j = 1; j < buckets[i].Count; j++)
                {
                    int key = buckets[i][j];
                    int k = j - 1;

                    while (k >= 0)
                    {
                        ComparisonCount++;
                        if (buckets[i][k] > key)
                        {
                            buckets[i][k + 1] = buckets[i][k];
                            SwapCount++;
                            k--;
                        }
                        else
                            break;
                    }

                    buckets[i][k + 1] = key;
                    SwapCount++;
                }
            }

            //Reconstruir el arreglo final
            int idx = 0;
            for (int i = 0; i < bucketCount; i++)
            {
                foreach (int num in buckets[i])
                {
                    arr[idx++] = num;
                    SwapCount++;
                }
            }
        }



        // 11. Radix Sort

        public static void RadixSort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return;

            // 1️⃣ Encontrar el máximo (manual, contando operaciones)
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                ComparisonCount++;
                if (arr[i] > max)
                    max = arr[i];
            }

            // 2️⃣ Aplicar Counting Sort por cada dígito
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(arr, exp);
            }
        }

        private static void CountingSortByDigit(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            // Conteo de dígitos
            for (int i = 0; i < n; i++)
            {
                int digit = (arr[i] / exp) % 10;
                count[digit]++;
                ComparisonCount++;
            }

            // Acumulación
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Construcción estable del arreglo
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
                SwapCount++;
            }

            // Copiar al arreglo original
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
                SwapCount++;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////





    }


}



