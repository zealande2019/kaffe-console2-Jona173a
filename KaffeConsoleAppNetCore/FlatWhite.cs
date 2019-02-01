using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeConsoleAppNetCore
{
    public class FlatWhite : Kaffe , Imælk
    {
        public int MlMælk()
        {
            return 160;
        }

        public override int Pris()
        {
            return 45;
        }
        public override string Styrke()
        {
            return "Mild";
        }

        public FlatWhite (int rabat) : base(rabat)
        {
        }
    }
}
