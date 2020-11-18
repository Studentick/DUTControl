using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDUT
{
    class Program
    {

        static string id = "33722";

        static string ExtractData(string _id)
        {
            if (id == _id)
            {
                return "33722N0=+210=01345.27=00632.55=094";
            }

            return "";
        }

        static Dictionary<string, string> GetData(string id)
        {
            string dut_ansver = ExtractData(id);
            string[] str_arr;
            Dictionary<string, string> dut_data = new Dictionary<string, string>();
            if (dut_ansver != "")
            {
                str_arr = dut_ansver.Split('=');
                dut_data.Add("id", str_arr[0].Substring(0, str_arr[0].Length - 2));
                dut_data.Add("fuel", str_arr[2]);
                dut_data.Add("water", str_arr[3]);
                dut_data.Add("temp", str_arr[1]);
                return dut_data;
            }

            return null;
        }


        static void Main(string[] args)
        {
            GetData("33722");
        }



    }

}
