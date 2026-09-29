using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace p01_ia
{
    public partial class Form1 : Form
    {
        int[,] Fontes = new int[21, 64] {
            {-1,-1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,1,1,1,1,1,-1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,1,1,1,-1,1,1,1,1}, // A Fonte 1
            {1,1,1,1,1,1,-1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,1,1,1,1,-1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1,1}, // B Fonte 1
            {1,1,1,1,1,1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,1}, // C Fonte 1
            {1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1,1}, // D Fonte 1
            {1,1,1,1,1,1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,1}, // E Fonte 1
            {-1,1,1,1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,1,-1,-1,1,1,-1,-1,1,1,1,1,-1,-1,1}, // J Fonte 1
            {1,1,-1,-1,1,1,-1,-1,-1,-1,-1,1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,-1,1,-1,1}, // K Fonte 1
            {-1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1}, // A Fonte 2
            {1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1,1}, // B Fonte 2
            {1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,1,1,1,1,-1,1}, // C Fonte 2
            {1,1,1,1,1,-1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,1,-1,1,1,1,1,1,-1,-1,1}, // D Fonte 2
            {1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,1,1,1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,1,1,1,1,-1,1}, // E Fonte 2
            {-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,-1,-1,1,1,1,-1,-1,1}, // J Fonte 2
            {1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,-1,1,-1,-1}, // K Fonte 2
            {-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,1,-1,-1,-1,1,-1,-1,1,1,1,1,1,-1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,1}, // A Fonte 3
            {1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1,1}, // B Fonte 3
            {-1,1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1}, // C Fonte 3
            {1,1,1,1,1,1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,1,1}, // D Fonte 3
            {1,1,1,1,1,1,1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,1,1,1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,1}, // E Fonte 3
            {1,1,1,1,1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,1,1,-1,1,1,1,1,1,-1,1}, // J Fonte 3
            {1,-1,-1,-1,-1,1,1,1,-1,-1,-1,1,1,-1,1,-1,-1,1,1,-1,-1,1,-1,1,1,-1,-1,-1,1,1,1,-1,-1,-1,-1,1,-1,1,1,-1,-1,-1,1,-1,-1,1,1,-1,-1,1,-1,-1,-1,1,1,-1,1,-1,-1,-1,-1,1,1,1}, // K Fonte 3
        };
        double lr = 0.01;

        double [,]pesos = new double[7,64];

        public Form1()
        {
            InitializeComponent();
            Init_Weights();
        }

        void Init_Weights() {
            Random rand = new Random();
            for (int i = 0; i < 7; i++) {
                for (int j = 0; j < 64; j++) {
                    pesos[i, j] = rand.NextDouble() * 2 - 1;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++) {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();

                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dataGridView2.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 7; j++) {
                    dataGridView2.Rows[i].Cells[j].Value = "."; // Teste
                }
            }

            comboBox1.SelectedIndex = 0; // Fonte
            comboBox2.SelectedIndex = 0; // Letra

            chart1.Series[0].Points.Add(0, 0);
        }

        void PreencheGrid(int index) {
            int row = 0, col = 0;

            for (int i = 0; i < 63; i++) {
                if (Fontes[index, i] == 1)
                {
                    dataGridView1.Rows[row].Cells[col].Value = "#";
                }
                else {
                    dataGridView1.Rows[row].Cells[col].Value = ".";
                }

                col++;
                if (col == 7) {
                    col = 0;
                    row++;
                }
            }
        }

        void MostrarLetra()
        {
            int fonte = comboBox1.SelectedIndex;
            int letra = comboBox2.SelectedIndex == -1 ? 0 : comboBox2.SelectedIndex;
            PreencheGrid(7 * fonte + letra);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarLetra();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarLetra();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int []input = new int[64];
            int index = 0;

            string[] letras = new string[] { "A", "B", "C", "D", "E", "J", "K" };

            label4.Text = "";

            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 7; j++) {
                    string val = dataGridView2.Rows[i].Cells[j].Value.ToString();

                    if (val == "#")
                    {
                        input[index] = 1;
                    }
                    else if (val == ".")
                    {
                        input[index] = -1;
                    }
                    else
                    {
                        input[index] = 0;
                    }

                    index++;
                }
            }

            input[63] = 1;
            double[] output = Forward(input);

            int melhor = 0;
            for (int i = 1; i < 7; i++) {
                if (output[i] > output[melhor]) melhor = i;
            }

            label4.Text = letras[melhor];
        }

        Double Loss(double[] y_pred, int[] y) {
            double sum = 0;
            for (int i = 0; i < 7; i++) {
                sum += Math.Pow(y[i] - y_pred[i], 2);
            }

            return sum / 7;
        }

        int[] Build_Vector(int x) {
            int []vet = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            vet[x] = 1;
            return vet;
        }

        Double[] Forward(int[] x) {
            double[] vet_pred = new double[7];

            for (int i = 0; i < 7; i++)
            {
                double acc = 0;
                for (int j = 0; j < 64; j++)
                {
                    acc += x[j] * pesos[i, j];
                }

                vet_pred[i] = acc;
            }

            return vet_pred;
        }

        void Step(int[] x, double[] pred_y, int[] y) {
            for (int i = 0; i < 7; i++) {
                for (int j = 0; j < 64; j++) {
                    pesos[i, j] += lr * (y[i] - pred_y[i]) * x[j];
                }
            }
        }

        int Train() {
            int epoch = 0;

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Points.Clear();

            while (epoch < 500)
            {
                double total_loss = 0.0;

                for (int i = 0; i < 21; i++)
                {
                    int[] fonte = new int[64];

                    for (int j = 0; j < 64; j++)
                    {
                        fonte[j] = Fontes[i, j];
                    }

                    double[] output = Forward(fonte);

                    int letra = i % 7;
                    int[] y = Build_Vector(letra);
                    double loss = Loss(
                        output,
                        y
                    );
                    total_loss += loss;

                    Step(fonte, output, y);
                }

                epoch += 1;

                double epoch_loss = total_loss / 21;
                chart1.Series[0].Points.AddXY(epoch, epoch_loss);
            }
            return epoch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int epoch = Train();
            label6.Text = epoch.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora clique no cabeçalho
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string valor = cell.Value?.ToString();

            if (valor == "#")
                cell.Value = ".";
            else
                cell.Value = "#";
        }
    }
}
