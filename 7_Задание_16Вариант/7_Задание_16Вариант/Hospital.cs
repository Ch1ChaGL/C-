using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Задание_16Вариант
{
    [Serializable]
    public class Hospital
    {
        public byte[] FullName { get; set; }
        public DateTime birthday { get; set; }
        public DateTime vizitHospital { get; set; }

        public byte[] Diagnoz { get; set; }
        public int unitNumber { get; set; }


        public string fullname
        {
            get { return ByteArrayToString(FullName); }
        }
        public string diagnoz
        {
            get { return ByteArrayToString(Diagnoz); }
        }

        const int MAX_LENGTH = 40;
        static Encoding encoding = Encoding.GetEncoding(1251);
        public Hospital(string fullName, DateTime birth, DateTime vizit, string diagnoz, int unitId) 
        {
           FullName =  StringToByte(fullName);
           birthday = birth;
           vizitHospital = vizit;
           Diagnoz = StringToByte(diagnoz);
           unitNumber = unitId; 
        }
        private static byte[] StringToByte(string s)
        {
            char[] arr = new char[MAX_LENGTH];
            for (int i = 0; i < MAX_LENGTH; i++)
            {
                if (i < s.Length)
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
            FileStream fw = null;
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
            if (num >= 0)
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
                Hospital hospital = (Hospital)formatter.Deserialize(fs);

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
        public static List<Hospital> ReadGamesFromFile(string filePath, List<long> positions)
        {
            List<Hospital> hospitals = new List<Hospital>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                foreach (int pos in positions)
                {
                    fs.Seek(pos, SeekOrigin.Begin);

                    Hospital hospital = (Hospital)bf.Deserialize(fs);
                    hospitals.Add(hospital);
                }
            }

            return hospitals;
        }

        public static List<Hospital> ReadGamesFromFile(string filePath, long positions)
        {
            List<Hospital> hospitals = new List<Hospital>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                fs.Seek(positions, SeekOrigin.Begin);

                Hospital hospital = (Hospital)bf.Deserialize(fs);
                hospitals.Add(hospital);
            }

            return hospitals;
        }

        public static List<Hospital> LoadFromBinaryFile(string fileName)
        {
            List<Hospital> result = new List<Hospital>();
            FileStream fr = null;
            try
            {
                fr = new FileStream(fileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fr.Position < fr.Length)
                {
                    Hospital hospital = (Hospital)bf.Deserialize(fr);
                    result.Add(hospital);
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

        public class SortByFullName : IComparer<Hospital>
        {
            public int Compare(Hospital x,Hospital y)
            {
                string name1 = ByteArrayToString(x.FullName);
                string name2 = ByteArrayToString(y.FullName);

                return string.Compare(name1, name2, StringComparison.Ordinal);
            }
        }
        public class SortByUnitNumber : IComparer<Hospital>
        {
            public int Compare(Hospital x, Hospital y)
            {
                if (x.unitNumber > y.unitNumber) return 1;
                if (x.unitNumber < y.unitNumber) return -1;
                return 0;
            }
        }

        public class SortByBirthDay : IComparer<Hospital> 
        {
            public int Compare(Hospital x, Hospital y)
            {
                if (x.birthday > y.birthday)
                    return 1;
                if (x.birthday < y.birthday)
                    return -1;

                    return 0;
            }
        }

        public class SortByVizit : IComparer<Hospital>
        {
            public int Compare(Hospital x, Hospital y)
            {
                if (x.vizitHospital > y.vizitHospital)
                    return 1;
                if (x.vizitHospital < y.vizitHospital)
                    return -1;

                return 0;
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
                    Hospital hospital = (Hospital)formatter.Deserialize(fs);
                    if (ByteArrayToString(hospital.FullName) == name)
                    {
                        return position;
                    }
                    position = fs.Position;
                }
                return -1;
            }
        }
        public static List<long> FindByBithdayDiapazon(string fileName, DateTime start, DateTime end)
        {
            List<long> positions = new List<long>();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                long position = 0;
                while (position < fs.Length)
                {
                    fs.Seek(position, SeekOrigin.Begin);
                    Hospital hospital= (Hospital)formatter.Deserialize(fs);
                    if (hospital.birthday >= start && hospital.birthday <= end)
                    {
                        positions.Add(position);
                    }
                    position = fs.Position;
                }
                return positions;
            }
        }
        public static List<long> FindByVizitDiapazon(string fileName, DateTime start, DateTime end)
        {
            List<long> positions = new List<long>();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                long position = 0;
                while (position < fs.Length)
                {
                    fs.Seek(position, SeekOrigin.Begin);
                    Hospital hospital = (Hospital)formatter.Deserialize(fs);
                    if (hospital.vizitHospital >= start && hospital.vizitHospital<= end)
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
