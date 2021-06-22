using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Perfomance
    {
        private Compititor com { get; set; }
        private FormHolding form { get; set; }
        private int result { get; set; }

        public Perfomance(Compititor com, FormHolding form, int result)
        {
            this.com = com;
            this.form = form;
            this.result = result;
        }
        public Perfomance(Perfomance ex)
        {
            this.com = ex.com;
            this.form = ex.form;
            this.result = ex.result;
        }

        public string Info => "Вид: " + Perfomance.formsExc.FirstOrDefault(x => x.Value == form).Key + "\nУчасник: " + com + "\nРезультат: " + result;
        public override string ToString() => "Вид: " + Perfomance.formsExc.FirstOrDefault(x => x.Value == form).Key;

        static public Dictionary<String, FormHolding> formsExc = new Dictionary<string, FormHolding>(4)
        {
            {"Індивідуальне", FormHolding.individual},
            {"Командне", FormHolding.cooperative},
        };
    }
}
