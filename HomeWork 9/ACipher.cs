
namespace HomeWork_9
{
    internal class ACipher : ICipher
    {
        public string Encode (string words)
        {
            char[] chars = words.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (chars[i] == 'я' || chars[i] == 'Я') 
                    {
                        chars[i] = (char)(chars[i] - 32);
                    }
                    else
                    {
                        chars[i] = (char)(chars[i] + 1);
                    }
                }
            }
            return new string(chars);
        }


        public string Decode(string words)
        {
            char[] chars = words.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (chars[i] == 'а' || chars[i] == 'А')
                    {
                        chars[i] = (char)(chars[i] + 32);
                    }
                    else
                    {
                        chars[i] = (char)(chars[i] -1);
                    }
                }
            }
            return new string(chars);
        }
    }
}
