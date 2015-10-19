using System;

namespace Ceasar.Tests
{
    public class CeasarCipher
    {
        private int _offset;
        private char[] _character;
       

        public CeasarCipher(int offset)
        {
            _offset = offset;
        }

        public string  Encrypt(string str)
        {
            int kof = 1;
            return Mycipher(str, kof);
        }


        public string  Decrypt(string str)
        {
            int kof = -1;
            return Mycipher(str, kof );
        }

        private  string  Mycipher(string stroc,  int kof)
        {
          
            string str = stroc;
            if (str == null)
                throw new ArgumentNullException();
            if (str == "")
                return "";
            if (_offset == 0)
                return str;
            else
                _character = new char[str.Length];
           _character = str.ToCharArray();
            int index;
            for (int i = 0; i<str.Length; i++)
            {
                index = (int)_character[i];
                if (31 < index && index < 127)
                {
                    if( kof > 0 )
                     {
                    if (index + _offset < 127)
                        _character[i] = (char) (index + _offset);
                    else
                        _character[i] = (char) (index + _offset - 95);
                     }
                    else
                    {
                        if (index - _offset > 31)
                            _character[i] = (char)(index - _offset);
                        else
                            _character[i] = (char)(index - _offset + 95);
                    }

            }
                else
                {
                    throw new ArgumentOutOfRangeException(" abroad symbols");
                 }
            }
            return Converter(_character); ;
        }
        private string Converter(char[] array)
        {
            string empty = "";
            for (int i = 0; i < array.Length; i++)
            {
                empty += array[i];
            }
            return empty;
        }
    }
}