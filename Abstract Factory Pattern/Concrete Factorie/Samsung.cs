using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Concrete_Factorie
{
    public class Samsung : IPhoneFactory
    {
        public IDumbPhone GetDumb()
        {
            return new Guru();
        }

        public ISmartPhone GetSmart()
        {
            return new Galaxy();
        }
    }
}
