using Microsoft.AspNetCore.Mvc;
using TP_MOD9_1302210081;

namespace TP_MOD9_1302210125.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaDbController : ControllerBase
    {
        public static List<Mahasiswa> ListMhs = new List<Mahasiswa>
        {
            new Mahasiswa("Hilmi Fauziyyah Supriatna", "1302210081"),
            new Mahasiswa("Marsya Rayani Humaira", "1302213003"),
            new Mahasiswa("Arya Frandika Daulay", "1302213069"),
            new Mahasiswa("Ibrahim Mulyo Tsabit", "1302210022"),
            new Mahasiswa("Ridwan Nur Rahman", "1302210076")
        };
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMhs;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return ListMhs[id];
        }
        [HttpPost]
        public void Post(Mahasiswa value)
        {
            ListMhs.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMhs.RemoveAt(id);
        }
    }
}
