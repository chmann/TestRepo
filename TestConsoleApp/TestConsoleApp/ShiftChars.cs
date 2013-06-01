using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class ShiftChars
    {
        public String Message { get; set; }

        public ShiftChars(String sMessageToTranslate)
        {
            Message = sMessageToTranslate;
        }

        public String ShiftByConstant(int shift)
        {
            if (Message != null)
            {
                shift = shift % 26;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < Message.Length; i++)
                {
                    char c = Message[i];
                    c = (char)((byte)c + shift);
                    sb.Append("" + c);
                }
                return sb.ToString();
            }
            return String.Empty;
        }

        
    }
}
