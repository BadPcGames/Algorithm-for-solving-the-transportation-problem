using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter sw;
        private int[,] priceMatrix;
        private int[,] res;
        private int[] want;
        private int[] have;
        int sizeX;
        int sizeY;


        private void buttonSolve_Click(object sender, EventArgs e)
        {
            sw = new StreamWriter(@"D:\result.txt");
            makeMatrix();
            solve();
            sw.Close();
        }
        private void makeMatrix()
        {
            string[] equlense = textBoxSystem.Text.Split('\n');
            string[] line = equlense[0].Split(' ');
            priceMatrix = new int[line.Length, equlense.Length];
            for (int j = 0; j < equlense.Length; j++)
            {
                line = equlense[j].Split(' ');
                for (int i = 0; i < line.Length; i++)
                {
                    priceMatrix[i, j] = int.Parse(line[i]);
                }
            }
        }
        private void fileWrite(int[,] m, int sizeX, int sizeY)
        {
            string line = "";
            line += "_______________________\n";
            for (int j = 0; j < sizeY; j++)
            {
                for (int i = 0; i < sizeX; i++)
                {
                    line += " " + m[i, j] + " ";

                }
                line += "\n";
            }

            sw.WriteLine(line);

        }


        void opSolveMinimumElements()
        {
            int[] copyWant = want;
            int[] copyHave = have;
            bool isEmpty;
            int mustBeBigger = 0;
            do
            {
                isEmpty = true;
                int min = int.MaxValue;
                for (int i = 0; i < copyHave.Length; i++)
                {
                    for (int j = 0; j < copyWant.Length; j++)
                    {
                        if (priceMatrix[j, i] > mustBeBigger && priceMatrix[j, i] < min)
                        {
                            min = priceMatrix[j, i];
                        }
                    }
                }
                mustBeBigger = min;
                for (int i = 0; i < copyHave.Length; i++)
                {
                    for (int j = 0; j < copyWant.Length; j++)
                    {
                        int change = 0;
                        if (priceMatrix[j, i] == min)
                        {
                            if (copyWant[j] >= copyHave[i])
                            {
                                res[j, i] = copyHave[i];
                                change = copyHave[i];
                                copyHave[i] -= change;
                                copyWant[j] -= change;
                            }
                            else
                            {
                                res[j, i] = copyWant[j];
                                change = copyWant[j];
                                copyHave[i] -= change;
                                copyWant[j] -= change;
                            }
                        }
                    }
                }
                foreach (int el in copyHave)
                {
                    if (el != 0) isEmpty = false;
                }

                foreach (int el in copyWant)
                {
                    if (el != 0) isEmpty = false;
                }

            } while (!isEmpty);


        }

        void solve()
        {
            sw.WriteLine("Матриця вартостей");
            sizeX = priceMatrix.GetLength(0);
            sizeY = priceMatrix.Length / priceMatrix.GetLength(0);
            have = new int[sizeY];
            res = new int[sizeX, sizeY];
            string[] h = textBoxHave.Text.Split(' ');
            for (int i = 0; i < h.Length; i++)
            {
                have[i] = int.Parse(h[i]);
            }
            sw.WriteLine("Вектор запасів: "+textBoxHave.Text);
            want = new int[sizeX];
            string[] w = textBoxWant.Text.Split(' ');
            for (int i = 0; i < w.Length; i++)
            {
                want[i] = int.Parse(w[i]);
            }
            sw.WriteLine("Вектор заявок: " + textBoxWant.Text);
            fileWrite(priceMatrix, sizeX, sizeY);
            sw.WriteLine("Пошук опорного плану перевезень методом методом мінімального елемента");
            opSolveMinimumElements();
            int price = 0;
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    price += priceMatrix[i, j] * res[i, j];
                }
            }
            string line = "";
            for (int j = 0; j < sizeY; j++)
            {
                for (int i = 0; i < sizeX; i++)
                {
                    if (res[i, j] == 0)
                    {
                        line += " " + "x" + " ";
                    }
                    else
                    {
                        line += " " + res[i, j] + " ";
                    }

                }
                line += "\r\n";
            }
            textBoxOpRes.Text = line;
            sw.WriteLine("Опорний план перевезення");
            sw.WriteLine(line);
            sw.WriteLine("Ціна= " + price);
            textBoxPriceOP.Text = price.ToString();
            sw.WriteLine("Пошук оптимального плану перевезень методом потенціалів:");
            potencial();
            line = "";
            for (int j = 0; j < sizeY; j++)
            {
                for (int i = 0; i < sizeX; i++)
                {
                    line += " " + res[i, j] + " ";
                }
                line += "\r\n";
            }
            textBoxOptiRes.Text = line;
            price = 0;
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    price += priceMatrix[i, j] * res[i, j];
                }
            }
            sw.WriteLine("Оптимальний план перевезень:");
            fileWrite(res, sizeX, sizeY);
            sw.WriteLine("Ціна= " + price);
            textBoxPriceOpti.Text = price.ToString();
        }

        void potencial()
        {
            int[,] potencials=new int[sizeX,sizeY];
            for(int i = 0; i < sizeX; i++)
            {
                for (int j = 0;j < sizeY; j++)
                {
                    potencials[i, j] = res[i, j];
                }
            }

            int?[] potentialWant = new int?[sizeX] ;
            int?[] potentialHave = new int?[sizeY] ;



            potentialHave[0] = 0;
            bool isNull;
            do
            {
                isNull = false;
                for (int j = 0; j < sizeY; j++)
                {
                    for (int i = 0; i < sizeX; i++)
                    {
                        if (res[i, j] != 0)
                        {
                            if (potentialHave[j] == null)
                            {
                                potentialHave[j] = priceMatrix[i, j] - potentialWant[i];
                            }
                            if (potentialWant[i] == null)
                            {
                                potentialWant[i] = priceMatrix[i, j] - potentialHave[j];
                            }
                        }
                    }
                }
                foreach (int? el in potentialWant)
                {
                    if (el == null) isNull = true;
                }
                Console.WriteLine();

                foreach (int? el in potentialHave)
                {
                    if (el == null) isNull = true;
                }
            } while (isNull);

            string l = "";
            foreach (int? el in potentialWant)
            {
                l += " " + el;
            }
            sw.WriteLine("Потенціали постачальників: " + l);
            l = "";
            foreach (int? el in potentialHave)
            {
               l += " " + el;
            }
            sw.WriteLine("Потенціали споживачів:: " + l);
            bool isOpti = true;

            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (potencials[i, j] == 0)
                    {
                        potencials[i, j] = (int)potentialWant[i] + (int)potentialHave[j];
                        if (priceMatrix[i, j] < potencials[i, j])
                        {
                            isOpti = false;
                        }

                    }
                }
            }
            string r = "";
            sw.WriteLine("Непрямі вартості");
            fileWrite(potencials, sizeX, sizeY);
            if (isOpti)
            {
                sw.WriteLine("Розв'язок оптимальний");
                return;
            }

                int changeStartX = -1;
                int changeStartY = -1;
                int dif = -1;
                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = 0; j < sizeY; j++)
                    {
                        if (potencials[i, j] != res[i, j])
                        {
                            if (potencials[i, j] > priceMatrix[i, j])
                            {
                                if(dif< potencials[i, j] - priceMatrix[i, j])
                                {
                                    changeStartX = i;
                                    changeStartY = j;
                                    dif = potencials[i, j] - priceMatrix[i, j];
                                }
                            }
                        }
                    }
                }
            sw.WriteLine($"Проблемна точка [{changeStartX},{changeStartY}]");
            string[] equlense = textBoxQueue.Text.Split('\n');
            string[] line = equlense[0].Split(' ');
            int[,] changeMatrix = new int[line.Length + 1, 2];
            changeMatrix[0,0]=changeStartX;
            changeMatrix[0,1]=changeStartY;
            for (int j = 0; j < equlense.Length; j++)
            {
                line = equlense[j].Split(' ');
                for (int i = 0; i < line.Length; i++)
                {
                    changeMatrix[i+1, j] = int.Parse(line[i]);
                }
            }
            int min=int.MaxValue;
            for(int i = 1; i < line.Length - 1; i++)
            {
                if (potencials[changeMatrix[i, 0], changeMatrix[i, 1]] < min)
                {
                    min= potencials[changeMatrix[i, 0], changeMatrix[i, 1]];
                }
            }
            sw.WriteLine("Знайдено значення λ: "+min);
            dif = 1;
            for(int i=0; i< line.Length+1; i++)
            {
                res[changeMatrix[i, 0], changeMatrix[i, 1]] += min * dif;
                dif *= -1;
            }

        }

  
  
    }
}
