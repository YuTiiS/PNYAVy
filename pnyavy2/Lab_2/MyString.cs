using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class MyString
    {
        private char[] Stroka;

        // Длина входной строки.
        public int Lenght(string TempStroka)
        {
            int i = 0;
            // Инициализация массива символов значением,
            // которое приняли из параметра.
            foreach (char Simvol in TempStroka)
                i++;
            return (i);
        }

        // Кол-во пробелов в строке.
        public int NumberOfSpaces(string TempStroka)
        {
            int i = 0;
            foreach (char Simvol in TempStroka)
            {
                if(Simvol == ' ')
                    i++;
            }              
            return (i);
        }

        // Кол-во цифр в строке.
        public int NumberOfDigits(string TempStroka)
        {
            int i = 0;
            
            foreach (char Simvol in TempStroka)
            {
                if ((Simvol == '1') || (Simvol == '2') || (Simvol == '3') || (Simvol == '4') || (Simvol == '5') ||
                    (Simvol == '6') || (Simvol == '7') || (Simvol == '8') || (Simvol == '9') || (Simvol == '0'))
                {
                    i++;
                    continue;
                }
            }
            return (i);
        }

        // Метод "FindSymbol".
        public int FindSymbol(char symbol)
        {
            int i = 0;
            foreach (char Simvol in Stroka)
            {
                if (Simvol == symbol)
                    return i;
                i++;
            }
            return -1;
        }

        // Метод "Replace".
        public MyString Replace(MyString Str, char Old, char New)
        {
            string TempStroka;
            TempStroka = Str; // Преобразование типов "MyString" -> "string".

            int i = 0;
            foreach (char Simvol in TempStroka)
            {
                if (Simvol == Old)
                {
                    Str[i] = New;
                    break;
                }
                i++;
            }
            return Str;
        }

        // Методы "Substring"  с перегрузками.
        public MyString Substring(MyString obj, int StartIndex)
        {
            string TempStroka;
            TempStroka = obj; // Преобразование типов "MyString" -> "string".
            int n = obj.Lenght(obj);
            MyString chstr = new MyString(n);

            int i = 0;
            int j = 0;
            foreach (char Simvol in TempStroka)
            {
                if (i >= StartIndex)
                {
                    chstr[j] += TempStroka[i];
                    j++;
                }
                i++;
            }
            return chstr;
        }
        
        public MyString Substring(MyString obj, int StartIndex, int Count)
        {
            string TempStroka;
            TempStroka = obj; // Преобразование типов "MyString" -> "string".
       
            int n = obj.Lenght(obj);
            MyString chstr = new MyString(n);
            int i = 0;
            int j = 0;
            foreach (char Simvol in TempStroka)
            {
                if ((i >= StartIndex) && (i <= Count))
                {
                    chstr[j] += TempStroka[i];
                    j++;
                }
                i++;
            }
            return chstr;
        }

        // Индексация.
        public char this[int index]
        {
            get
            {
                return Stroka[index];
            }
            set
            {
                Stroka[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return Stroka.Length;
            }
            set
            {
                char[] temp = new char[value];
                if (value > Stroka.Length)
                {
                    value = Stroka.Length;
                }
                for (int i = 0; i < value; i++)
                {
                    temp[i] = Stroka[i];
                    Stroka = temp;
                }
            }
        }

        // Перегрузка оператора "+".
        public static MyString operator +(MyString s1, MyString s2)
        {
            int L = s1.Stroka.Length + s2.Stroka.Length;

            var SlozhenieStrok = new MyString(L);

            for (int i = 0; i < s1.Stroka.Length; i++)
            {
                SlozhenieStrok[i] = s1[i];
            }
            for (int i = 0; i < s2.Stroka.Length; i++)
            {
                SlozhenieStrok[s1.Stroka.Length + i] = s2[i];
            }
            return SlozhenieStrok;
        }

        public static bool operator <(MyString s1, MyString s2)
        {
            int i1 = s1.Stroka.Length;
            int j1 = s1.Stroka.Length;
            for (int i = 0; i < i1; i++)
            {
                if ((int)s1.Stroka[i] < (int)s2.Stroka[i])
                    return true;
            }
            return false;
        }

        public static bool operator >(MyString s1, MyString s2)
        {
            int i1 = s1.Stroka.Length;
            int j1 = s1.Stroka.Length;
            for (int i = 0; i < i1; i++)
            {
                if ((int)s1.Stroka[i] > (int)s2.Stroka[i])
                    return true;
            }
            return false;
        }
       /* public static bool operator >=(MyString s1, MyString s2)
        {
            if (s1.Stroka.Length > s2.Stroka.Length)
            {
                return true;
            }
            if (s1 == s2)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(MyString s1, MyString s2)
        {
            if (s1.Stroka.Length < s2.Stroka.Length)
            {
                return true;
            }
            if (s1 == s2)
            {
                return true;
            }
            return false;
        }
        */
        public static bool operator ==(MyString s1, MyString s2)
        {
            int i1 = s1.Stroka.Length;
            int j1= s2.Stroka.Length;
            if (i1 != j1)
                return false;
            for (int i=0; i<i1;i++)
            {
                if(s1.Stroka[i] != s2.Stroka[i])
                    return false;
            }
            return true;
        }
        public static bool operator !=(MyString s1, MyString s2)
        {
            int i1 = s1.Stroka.Length;
            int j1 = s2.Stroka.Length;
            if (i1 != j1)
                return true;
            for (int i = 0; i < i1; i++)
            {
                if (s1.Stroka[i] != s2.Stroka[i])
                    return true;
            }
            return false;
        }

        // Преобразование типов "MyString" -> "string".
        public static implicit operator string(MyString MyStr)
        {
            int len = MyStr.Length;
            char[] mch = new char[len];
            string chstr = "";
            for (int i = 0; i < MyStr.Length; i++)
            {
                mch[i] = MyStr[i];
            }
            for (int i = 0; i < MyStr.Length; i++)
            {
                chstr = chstr + mch[i];
            }
            return chstr;
        }

        // Преобразование типов "string" -> "MyString".
        public static implicit operator MyString(string Str)
        {
            MyString p = new MyString(Str.Length);
            p = ToArray(Str.ToCharArray());
            return p;
        }

        public static implicit operator MyString(int i)
        {
            string str=Convert.ToString(i);
            MyString p = new MyString(str.Length);
            p = ToArray(str.ToCharArray());
            return p;
        }

        public static implicit operator MyString(double i)
        {
            string str = Convert.ToString(i);
            MyString p = new MyString(str.Length);
            p = ToArray(str.ToCharArray());
            return p;
        }

        public char[] ToArray(MyString MyStr)
        {
            char[] res = new char[MyStr.Length];
            for (int i = 0; i < MyStr.Length; i++)
            {
                res[i] = MyStr.Stroka[i];
            }
            return res;
        }

        public static MyString ToArray(char[] arr)
        {
            int p;
            MyString res = new MyString(arr.Length);
            p = arr.Length;
            for (int i = 0; i < p; i++)
            {
                res.Stroka[i] = arr[i];
            }
            return res;
        }

        public Int32 ToInt(MyString MyStr)
        {
            int i = Int32.Parse(MyStr);
            return i;
        }

        public MyString(int init_size)
        {
            Stroka = new char[init_size];
        }

        public MyString()
        {
            Stroka = new char[256];
        }

        public MyString(String incomingString)
        {
            Stroka = new char[incomingString.Length];
            for (int i = 0; i < incomingString.Length; i++)
            {
                Stroka[i] = incomingString[i];
            }
        }

    }
}
