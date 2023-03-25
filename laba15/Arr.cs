using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba15
{
    public class Arr
    {
        class MyException : ArgumentException
        {
            public const string ArgumentError = "Массив не определен";
            public const string SizeError = "Выход за границы массива";

            
            public int Value { get; }

            public MyException(string message)
                : base(message)
            {

            }

            public MyException(string message, int value)
                : base(message)
            {
                Value = value;
            }

        }

        private int[] a;
        private int size;
        private static Random rnd = new Random();

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public Arr()
        {
            size = 0;
            a = null;
        }

        /// <summary>
        /// Конструктор класса с одним параметром размера массива 
        /// </summary>
        /// <param name="n">Размер массива</param>
        public Arr(int n)
        {
            a = new int[n];
            size = n;
        }

        /// <summary>
        /// Конструктор с инициализацией обычным массивом
        /// </summary>
        /// <param name="x">массив целого типа</param>
        public Arr(int[] x)
        {
            if (x == null) throw new MyException(MyException.ArgumentError);
            else
            {
                size = x.Length;
                a = new int[size];
                for (int i = 0; i < size; i++)
                {
                    a[i] = x[i];
                }
            }
        }


        /// <summary>
        ///  Конструктор с инициализацией объектом класса Arr
        /// </summary>
        /// <param name="B">объект класса Arr</param>
        public Arr(Arr B)
        {
            if (B.a == null)
                throw new MyException(MyException.ArgumentError);
            size = B.size;
            a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = B.a[i];
            }
        }


        /// <summary>
        /// Переопределение сравнения
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj as Arr == null)
                return false;
            if (size != (obj as Arr).size)
                return false;
            for (int i = 0; i < size; i++)
            {
                if (a[i] != (obj as Arr).a[i])
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// геттер Size
        /// </summary>
        public int Size
        {
            get
            {
                return size;
            }
        }

        /// <summary>
        /// метод заполнения случайными числами в интервале -100 до 100
        /// </summary>
        public void RndInput()
        {
            for (int i = 0; i < size; i++)
            {
                a[i] = rnd.Next(-100, 101);
            }
        }

        public void RndInput(int n1)
        {
            for (int i = 0; i < size; i++)
            {
                a[i] = rnd.Next(n1 + 1);
            }
        }

        public void RndInput(int n1, int n2)
        {
            for (int i = 0; i < size; i++)
            {
                a[i] = rnd.Next(n1, n2 + 1);
            }
        }

        /// <summary>
        /// перегрузка метода преобразования объекта Arr в строку
        /// </summary>
        /// <returns>элементы массива через пробел в одну строку</returns>
        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < size; i++)
            {
                s += String.Format("{0,5}", a[i]);
            }
            return s;
        }


        /// <summary>
        /// метод ввывод массива класса Arr на консоль
        /// </summary>
        public void Print()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine();
        }


        /// <summary>
        /// Сериализация в лэйбл
        /// </summary>
        /// <param name="lbl"></param>
        public void Print(Label lbl)
        {
            lbl.Text = this.ToString();
        }

        /// <summary>
        /// Сериализация массива в таблицу
        /// </summary>
        /// <param name="dgv"> Таблица, куда печатать элементы массива </param>
        public void Print(DataGridView dgv)
        {
            dgv.RowCount = 1;
            dgv.ColumnCount = size;
            for (int i = 0; i < size; i++)
            {
                dgv.Rows[0].Cells[i].Value = a[i];
            }
        }


        /// <summary>
        /// Индексатор для доступа к элементу массива по его номеру
        /// </summary>
        /// <param name="i">номер элемента</param>
        /// <returns></returns>
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < size)
                    return a[i];
                return 0;
            }
            set
            {
                if (i < 0 && i > size)
                    throw new MyException(MyException.SizeError);
                a[i] = value;               
            }
        }



        public void Clear()
        {
            for (int i = 0; i < size; i++)
            {
                a[i] = 0;
            }
        }


        public static Arr operator ++(Arr A) //Будет доступен Arr M1 = new Arr(10); M1++;
        {
            Arr temp = new Arr(A.size);

            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = ++A[i];
            }
            return temp;
        }

        public static Arr operator --(Arr A) //Будет доступен Arr M1 = new Arr(10); M1--;
        {
            Arr temp = new Arr(A.size);

            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = --A[i];
            }
            return temp;
        }

        public static Arr operator +(Arr X, Arr Y)
        {
            Arr temp;
            if (X.size > Y.size)
            {
                temp = new Arr(X.size);
            }
            else
            {
                temp = new Arr(Y.size);
            }
            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = X[i] + Y[i];
            }
            return temp;
        }
        public static Arr operator -(Arr X, Arr Y)
        {
            Arr temp;
            if (X.size > Y.size)
            {
                temp = new Arr(X.size);
            }
            else
            {
                temp = new Arr(Y.size);
            }
            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = X[i] - Y[i];
            }
            return temp;
        }

        public static Arr operator +(Arr X, int y)
        {
            Arr temp = new Arr(X.size);

            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = X[i] + y;
            }
            return temp;
        }
        public static Arr operator +(int x, Arr Y)
        {
            Arr temp = new Arr(Y.size);

            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = Y[i] + x;
            }
            return temp;
        }


        public static Arr operator -(Arr X, int y)
        {
            Arr temp = new Arr(X.size);

            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = X[i] - y;
            }
            return temp;
        }

        public static Arr operator -(int x, Arr Y)
        {
            Arr temp = new Arr(Y.size);

            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = Y[i] - x;
            }
            return temp;
        }

        public void ReadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = null;
                try
                {
                    stream = new StreamReader(openFileDialog.FileName);

                    string data = stream.ReadToEnd();
                    string[] elements = data.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    size = elements.Length;
                    a = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        a[i] = int.Parse(elements[i]);
                    }

                }
                catch
                {
                    throw new Exception("Ошибка обработки файла.");
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
        }

        public double GetY()
        {
            double sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += Math.Pow(-1, i + 2) * a[i];
            }
            return sum;
        }

    }
}
