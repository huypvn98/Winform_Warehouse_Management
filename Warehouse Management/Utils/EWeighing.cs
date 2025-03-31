using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Utils
{
    public class EWeighing : COMPortBase
    {
        private List<string> _textFromScale = new List<string>();

        public EWeighing(string port = null)
        {
            _portName = (string.IsNullOrWhiteSpace(port) ? GlobalSetting.WeighingKienPort : port);
        }

        public string WeighingBelow30(string rawText)
        {
            return ReplaceUnit(rawText);
        }

        public void AddRawText(string rawText)
        {
            _textFromScale.Add(rawText);
        }

        public string ReadWeight_InFactory1()
        {
            double result = 0.0;
            string[] array = string.Join("", _textFromScale).Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
            for (int num = array.Length - 1; num >= 0; num--)
            {
                if (double.TryParse(ReplaceUnit(array[num]), out result))
                {
                    return array[num];
                }
            }
            _textFromScale.Clear();
            return null;
        }

        public double ReadWeight_InFactory2(string indata)
        {
            double result = 0.0;
            string[] array = indata.Split(new char[1] { ' ' }, StringSplitOptions.None);
            for (int num = array.Length - 1; num >= 0; num--)
            {
                string text = array[num]?.Trim();
                if (!string.IsNullOrWhiteSpace(text))
                {
                    text = text.Replace("B", "").Replace("C", "").Replace("F", "")
                        .Replace("=", "");
                    if (double.TryParse(text, out result))
                    {
                        return result;
                    }
                }
            }
            return 0.0;
        }

        public string ReplaceUnit(string rawText)
        {
            if (string.IsNullOrWhiteSpace(rawText))
            {
                return "";
            }
            return rawText.Replace("kg", "").Replace("g", "").Replace("lb.oz", "")
                .Replace("lb", "")
                .Replace("pcs", "")
                .Trim();
        }
    }
}
