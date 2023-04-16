using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace tpmodul9_1302210094
{
    public class Mahasiswaa
    {
        public string Nama { get; private set; }
        public string Nim { get; private set; }

        public Mahasiswaa(string nama, string nim) { this.Nama = nama; this.Nim = nim; }
    }
}
