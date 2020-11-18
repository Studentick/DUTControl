using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDUT
{
    class DUT
    {
        // Установить значение нуля. Установить расстояние от дна нулевого значения поплавка в мм
        int zoro;
        // Уникальный номер ДУТа
        string id;
        // Тип ДУТа, разные ДУТы имеют разные команды для манипуляции и разный формат ответа
        string dut_type;

        public DUT(string id, string type, int zoro = 0)
        {
            this.id = id;
            this.zoro = zoro;
        }

        static string ExtractData(string _id)
        {
            
            return _id + "N0=+210=01345.27=00632.55=094";
            

            return "";
        }

        Dictionary<string, string> GetData()
        {
            string dut_ansver = ExtractData(this.id);
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


    }
}
