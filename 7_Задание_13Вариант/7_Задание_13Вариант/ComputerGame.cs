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
                fw = new FileStream(fileName, FileMode.Append);
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

        public static bool DeleteRecord(string fileName, long recordPosition)
        {
            bool success = false;
            if (recordPosition == -1) return false;
            BinaryFormatter formatter = new BinaryFormatter();

            // Открываем файл и перемещаемся на заданную позицию
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                fs.Seek(recordPosition, SeekOrigin.Begin);

                // Считываем запись, которую нужно удалить
                ComputerGame game = (ComputerGame)formatter.Deserialize(fs);

                // Вычисляем длину записи в байтах
                long recordLength = fs.Position - recordPosition;

                // Устанавливаем позицию на начало удаляемой записи и перемещаем указатель в конец записи
                fs.Seek(recordPosition, SeekOrigin.Begin);
                fs.Seek(recordLength, SeekOrigin.Current);

                // Считываем остаток файла, начиная со следующей за удаляемой записью позиции
                byte[] buffer = new byte[fs.Length - fs.Position];
                fs.Read(buffer, 0, buffer.Length);

                // Перемещаем указатель в начало удаляемой записи и перезаписываем файл без этой записи
                fs.Seek(recordPosition, SeekOrigin.Begin);
                fs.Write(buffer, 0, buffer.Length);

                // Обрезаем файл до новой длины
                fs.SetLength(fs.Position);

                success = true;
            }

            return success;
        }


        public static List<ComputerGame> ReadGamesFromFile(string filePath, List<long> positions)
        {
            List<ComputerGame> games = new List<ComputerGame>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                foreach (int pos in positions)
                {
                    fs.Seek(pos, SeekOrigin.Begin);

                    ComputerGame game = (ComputerGame)bf.Deserialize(fs);
                    games.Add(game);
                }
            }

            return games;
        }


        public static List<ComputerGame> ReadGamesFromFile(string filePath, long positions)
        {
            List<ComputerGame> games = new List<ComputerGame>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                fs.Seek(positions, SeekOrigin.Begin);

                ComputerGame game = (ComputerGame)bf.Deserialize(fs);
                games.Add(game);  
            }

            return games;
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

        public class SortByCPU : IComparer<ComputerGame>
        {
            public int Compare(ComputerGame x, ComputerGame y)
            {

                if (x.CPU > y.CPU) return 1;
                if (x.CPU < y.CPU) return -1;
                return 0;
            }
        }

        public class SortByMemory : IComparer<ComputerGame>
        {           
            public int Compare(ComputerGame x, ComputerGame y)
            {
                if (x.Memory > y.Memory) return 1;
                if (x.Memory < y.Memory) return -1;
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


        public static List<long> FindByMemoryDiapazon(string fileName, double start, double end)
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
                    if (game.Memory >= start && game.Memory <= end)
                    {
                        positions.Add(position);
                    }
                    position = fs.Position;
                }
                return positions;
            }
        }


        public static List<long> FindByCPUDiapazon(string fileName, double start, double end)
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
                    if (game.CPU >= start && game.CPU <= end)
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
