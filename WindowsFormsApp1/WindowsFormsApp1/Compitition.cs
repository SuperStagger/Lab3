using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Compitition
    {
        private DateTime date { get; set; }
        private List<Perfomance> exs;

        public List<Perfomance> EXS
        {
            get => exs;
        }


        public Compitition(DateTime date, List<Perfomance> exs)
        {
            this.date = date;
            this.exs = exs;
        }

        public void Add(Perfomance ex) => exs.Add(ex);
        public void Remove(Perfomance ex) => exs.Remove(ex);

        public string Info()
        {
            StringBuilder res = new StringBuilder("Час - " + date.ToShortDateString() + " змагань - " + exs.Count +"\n");
            foreach(Perfomance ex in exs)
            {
                res.Append(ex + "\n");
            }
            return res.ToString();
        }

        public IEnumerator<Perfomance> GetEnumerator()
        {
            return exs.GetEnumerator();
        }
        //public Excursion this[int i] => exs[i];

        public override string ToString() => "Кількість змагань: " + exs.Count + " Час: " + date.ToShortDateString();
    }
}
