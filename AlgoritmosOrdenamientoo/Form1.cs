using System.Diagnostics;

namespace AlgoritmosOrdenamientoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //   GENERAR ARREGLO ALEATORIO
        private int[] GenerarArreglo(int n)
        {
            Random r = new Random();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = r.Next(1, 100);

            return arr;
        }




        //  MÉTODO PARA EJECUTAR ALGORITMOS
        private void EjecutarOrdenamiento(Action<int[]> metodo, string nombre)
        {
            int n = (int)nudSize.Value;
            int[] data = GenerarArreglo(n);
            lbOriginal.Items.Clear();
            foreach (int x in data)
                lbOriginal.Items.Add(x);

            // Reiniciar TODOS los contadores
            AlgoritmosOrdenamiento.ComparisonCount = 0;
            AlgoritmosOrdenamiento.SwapCount = 0;
            AlgoritmosOrdenamiento.ShiftCount = 0;
            AlgoritmosOrdenamiento.AccessCount = 0;
            AlgoritmosOrdenamiento.AssignmentCount = 0;

            int[] copia = (int[])data.Clone();
            Stopwatch sw = Stopwatch.StartNew();
            metodo(copia);
            sw.Stop();

            lbSorted.Items.Clear();
            foreach (int x in copia)
                lbSorted.Items.Add(x);

            // Mostrar estadísticas según el tipo de algoritmo
            if (nombre.Contains("Shell"))
            {
                lblStats.Text =
                    $"{nombre}\n\n" +
                    $"Tiempo: {sw.Elapsed.TotalMilliseconds:F4} ms\n" +
                    $"Comparaciones: {AlgoritmosOrdenamiento.ComparisonCount}\n" +
                    $"Desplazamientos: {AlgoritmosOrdenamiento.ShiftCount}";
            }
            else if (nombre.Contains("Counting") || nombre.Contains("Bucket") || nombre.Contains("Radix"))
            {
                //Algoritmos NO basados en comparación
                lblStats.Text =
                    $"{nombre}\n\n" +
                    $"Tiempo: {sw.Elapsed.TotalMilliseconds:F4} ms\n" +
                    $"Accesos: {AlgoritmosOrdenamiento.AccessCount}\n" +
                    $"Asignaciones: {AlgoritmosOrdenamiento.AssignmentCount}";
            }
            else
            {
                // Algoritmos basados en comparación normales
                lblStats.Text =
                    $"{nombre}\n\n" +
                    $"Tiempo: {sw.Elapsed.TotalMilliseconds:F4} ms\n" +
                    $"Comparaciones: {AlgoritmosOrdenamiento.ComparisonCount}\n" +
                    $"Intercambios: {AlgoritmosOrdenamiento.SwapCount}";
            }

            lblDivisiones.Text = "Divisiones: 0";
            lblMezclas.Text = "Mezclas: 0";
        }



        //   EVENTOS DE BOTONES
        private void BtnBubble_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.BubbleSort, "Bubble Sort");
        }

        private void BtnCocktail_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.CocktailSort, "Cocktail Sort");
        }

        private void BtnInsertion_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.InsertSort, "Insertion Sort");
        }

        private void BtnMergeDirecto_Click(object sender, EventArgs e)
        {
            int n = (int)nudSize.Value;

            int[] data = GenerarArreglo(n);

            // Mostrar ORIGINAL
            lbOriginal.Items.Clear();
            foreach (int x in data)
                lbOriginal.Items.Add(x);

            //COPIA 
            List<int> copia = new List<int>(data);

            // Instancia del algoritmo
            AlgoritmosOrdenamiento alg = new AlgoritmosOrdenamiento();

            Stopwatch sw = Stopwatch.StartNew();

            // Ejecutar Merge Sort Directo
            alg.SortRecursivo(copia);

            sw.Stop();

            // Mostrar ORDENADO
            lbSorted.Items.Clear();
            foreach (int x in copia)
                lbSorted.Items.Add(x);

            // Métricas
            lblDivisiones.Text = $"Divisiones: {alg.Divisiones}";
            lblMezclas.Text = $"Mezclas: {alg.Mezclas}";
            lblStats.Text = "Merge Sort Directo";
            lblStats.Text += $"\nTiempo: {sw.Elapsed.TotalMilliseconds:F4} ms";
            
            
        }

        private void BtnMergeNatural_Click(object sender, EventArgs e)
        {
            int n = (int)nudSize.Value;

            int[] data = GenerarArreglo(n);

            // Mostrar ORIGINAL
            lbOriginal.Items.Clear();
            foreach (int x in data)
                lbOriginal.Items.Add(x);

            //COPIA
            List<int> copia = new List<int>(data);

            AlgoritmosOrdenamiento alg = new AlgoritmosOrdenamiento();

            Stopwatch sw = Stopwatch.StartNew();
            // Ejecutar Merge Sort Natural
            alg.SortNatural(copia);
            sw.Stop();

            // Mostrar ORDENADO
            lbSorted.Items.Clear();
            foreach (int x in copia)
                lbSorted.Items.Add(x);

            // Métricas
            lblDivisiones.Text = $"Divisiones: {alg.Divisiones}";
            lblMezclas.Text = $"Mezclas: {alg.Mezclas}";
            lblStats.Text = "Merge Sort Natural";
            lblStats.Text += $"\nTiempo: {sw.Elapsed.TotalMilliseconds:F4} ms";
        }

        private void BtnHeapSort_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.HeapSortWrapper, "Heap Sort");
        }
        
        private void BtnShell_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.ShellSort, "Shell Sort");
        }

        private void BtnGnome_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.GnomeSort, "Gnome Sort");
        }

        private void BtnCounting_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.CountingSort, "Counting Sort");
        }

        private void BtnBucket_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.BucketSort, "Bucket Sort");
        }

        private void BtnRadix_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.RadixSort, "Radix Sort");
        }

        private void BtnSelection_Click(object sender, EventArgs e)
        {
            EjecutarOrdenamiento(AlgoritmosOrdenamiento.SelectionSort, "Selection Sort");
        }

    }
}

