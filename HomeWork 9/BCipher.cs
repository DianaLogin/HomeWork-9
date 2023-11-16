
namespace HomeWork_9
{
    internal class BCipher : ICipher
    {

        public string Encode(string words)               //========================================================================================//
        {                                                //                                                                                        //
            char[] chars = words.ToCharArray();          // В С# есть для каждого символа свой машинный (двоичный) код,                            //
                                                         // у которого есть свой индекс в ANSI (стандарт кодирования знаков латинского алфавита).  //
                                                         // Этот метод работает только для английских слов, потому что в такой кодировке           //
                                                         // у БОЛЬШИХ англ букв индексы с 65 до 90, а у МАЛЕНЬКИХ букв с 97 до 122                 //
            for (int i = 0; i < chars.Length; i++)       //                                                                                        //
            {                                            //========================================================================================
                if (char.IsLetter(chars[i]))             
                {
                    if (char.IsUpper(chars[i])) // для больших букв
                    {
                        chars[i] = (char)(90 - (chars[i] - 65)); 
                    }
                    else // для маленьких букв
                    {
                        chars[i] = (char)(122 - (chars[i] - 97)); 
                    }
                }
            }
            return new string(chars);
        }

        public string Decode(string words)
        {
            return Encode(words); 
        }
    }

}

