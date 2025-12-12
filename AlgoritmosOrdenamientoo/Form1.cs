namespace AlgoritmosOrdenamientoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ==========================================
        //   GENERAR ARREGLO ALEATORIO
        // ==========================================
        private int[] GenerarArreglo(int n)
        {
            Random r = new Random();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = r.Next(1, 100);

            return arr;
        }

        // ==========================================
        //  MÉTODO GENÉRICO PARA EJECUTAR ALGORITMOS
        // ==========================================
        private void EjecutarOrdenamiento(Action<int[]> metodo, string nombre)
        {
            int n = (int)nudSize.Value;

            int[] data = GenerarArreglo(n);

            // Mostrar el arreglo original
            lbOriginal.Items.Clear();
            foreach (int x in data)
                lbOriginal.Items.Add(x);

            // Reiniciar contadores
            AlgoritmosOrdenamiento.ComparisonCount = 0;
            AlgoritmosOrdenamiento.SwapCount = 0;

            // Copia para ordenar
            int[] copia = (int[])data.Clone();

            // Ejecutar el algoritmo
            metodo(copia);

            // Mostrar el ordenado
            lbSorted.Items.Clear();
            foreach (int x in copia)
                lbSorted.Items.Add(x);

            // Mostrar estadísticas
            lblStats.Text =
                $"{nombre}\n\n" +
                $"Comparaciones: {AlgoritmosOrdenamiento.ComparisonCount}\n" +
                $"Intercambios: {AlgoritmosOrdenamiento.SwapCount}";
        }

        // ==========================================
        //   EVENTOS DE BOTONES
        // ==========================================
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


        // ==========================================
        //   NUEVOS HANDLERS: MERGE DIRECTO
        // ==========================================
        private void BtnMergeDirecto_Click(object sender, EventArgs e)
        {
            int n = (int)nudSize.Value;
            int[] data = GenerarArreglo(n);

            // Mostrar original
            lbOriginal.Items.Clear();
            foreach (int x in data) lbOriginal.Items.Add(x);

            // Crear instancia de merge
            AlgoritmosOrdenamiento alg = new AlgoritmosOrdenamiento();
            List<int> lista = new List<int>(data);

            // Ejecutar merge sort recursivo
            alg.SortRecursivo(lista);

            // Mostrar ordenado
            lbSorted.Items.Clear();
            foreach (int x in lista) lbSorted.Items.Add(x);

            // Mostrar divisiones y mezclas
            lblDivisiones.Text = $"Divisiones: {alg.Divisiones}";
            lblMezclas.Text = $"Mezclas: {alg.Mezclas}";

            lblStats.Text = "Merge Sort Directo";
        }


        // ==========================================
        //   NUEVOS HANDLERS: MERGE NATURAL
        // ==========================================
        private void BtnMergeNatural_Click(object sender, EventArgs e)
        {
            int n = (int)nudSize.Value;
            int[] data = GenerarArreglo(n);

            // Mostrar original
            lbOriginal.Items.Clear();
            foreach (int x in data) lbOriginal.Items.Add(x);

            AlgoritmosOrdenamiento alg = new AlgoritmosOrdenamiento();
            List<int> lista = new List<int>(data);

            alg.SortNatural(lista);

            // Mostrar ordenado
            lbSorted.Items.Clear();
            foreach (int x in lista) lbSorted.Items.Add(x);

            lblDivisiones.Text = $"Divisiones: {alg.Divisiones}";
            lblMezclas.Text = $"Mezclas: {alg.Mezclas}";

            lblStats.Text = "Merge Sort Natural";
        }




    }
}

