using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Задание_13Вариант
{

    [Serializable]
    public enum GameType
    {
        RPG = 1,
        Shooter = 2,
        Simulator = 3,
        Strategy = 4,
    }
    [Serializable]
    public class ComputerGame
    {
        public byte[] Name { get; set; }
        public GameType gameType { get; set; }
        public double Memory { get; set; }
        public double CPU { get; set; }

        [NonSerialized]
        const int MAX_LENGTH = 20;

        static Encoding encoding = Encoding.GetEncoding(1251);


        public string name 
        {
            get { return ByteArrayToString(Name); }
        }

        public ComputerGame(string name, GameType gameType, double memory, double cpu) 
        {
            Name = StringToByte(name);
            Memory = memory;
            this.gameType = gameType;
            CPU = cpu;
        }

        private static byte[] StringToByte(string s)
        {
            char[] arr = new char[MAX_LENGTH];
            for (int i = 0; i < MAX_LENGTH; i++)
            {
                if(i< s.Length)
                {
                    arr[i] = s[i];
                }
                else
                {
                    arr[i] = ' ';
                }
            }
            byte[] buff = encoding.GetBytes(arr);
            return buff;
        }

        private static string ByteArrayToString(byte[] b) 
        {
            char[] buff = encoding.GetChars(b);

            string result = "";

            for (int i = 0; i < buff.Length; i++)
            {
                result += buff[i];
            }

            return result;
        }


        public void SaveResult(string fileName)
        {
            FileStream fw  = null;
            try
            {
                fw = new FileStream(fileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fw, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fw.Close();
            }
        }

        public bool CorrectResult(string fileName, long num)
        {
            bool result = false;
            if(num >= 0)
            {
                FileStream fw = null;
                try
                {
                    fw = new FileStream(fileName, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    fw.Seek(num, SeekOrigin.Begin);

                    bf.Serialize(fw, this);
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    fw.Close();
                }
            }
            return result;
            
        }

        /// <summary>
        /// Загрузка данных из бинарного файла в динамический список объектов;
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<ComputerGame> LoadFromBinaryFile(string fileName)
        {
            List<ComputerGame> result = new List<ComputerGame>();
            FileStream fr = null;
            try
            {
                fr = new FileStream(fileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fr.Position < fr.Length)
                {
                    ComputerGame game = (ComputerGame)bf.Deserialize(fr);
                    result.Add(game);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fr.Close();
            }
            return result;
        }

        public class SortByCPU : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                ComputerGame temp1 = (ComputerGame)x;
                ComputerGame temp2 = (ComputerGame)y;

                if (temp1.CPU > temp2.CPU) return 1;
                if (temp1.CPU < temp2.CPU) return -1;
                return 0;
            }
        }

        public class SortByMemory : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                ComputerGame temp1 = (ComputerGame)x;
                ComputerGame temp2 = (ComputerGame)y;

                if (temp1.Memory > temp2.Memory) return 1;
                if (temp1.Memory< temp2.Memory) return -1;
                return 0;
            }
        }

        public class SortByGenre : IComparer<ComputerGame>
        {
            public int Compare(ComputerGame x, ComputerGame y)
            {
                return x.gameType.CompareTo(y.gameType);
            }
        }

        public class SortByName : IComparer<ComputerGame> 
        {
            public int Compare(ComputerGame x, ComputerGame y)
            {
                string name1 = ByteArrayToString(x.Name);
                string name2 = ByteArrayToString(y.Name);

                return string.Compare(name1, name2, StringComparison.Ordinal);
            }
        }




        public static long FindByName(string fileName, string name)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                long position = 0;
                while (position < fs.Length)
                {
                    fs.Seek(position, SeekOrigin.Begin);
                    ComputerGame game = (ComputerGame)formatter.Deserialize(fs);
                    if (ByteArrayToString(game.Name) == name)
                    {
                        return position;
                    }
                    position = fs.Position;
                }
                return -1;
            }
        }

        public static List<long> FindByGameType(string fileName, GameType gameType)
        {
            List<long> positions = new List<long>();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                long position = 0;
                while (position < fs.Length)
                {
                    fs.Seek(position, SeekOrigin.Begin);
                    ComputerGame game = (ComputerGame)formatter.Deserialize(fs);
                    if (game.gameType == gameType)
                    {
                        positions.Add(position);
                    }
                    position = fs.Position;
                }
                return positions;
            }
        }



    }
}
