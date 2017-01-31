using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Concrete_Factorie
{
   public  enum MANUFACTURERS
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
    public class PhoneTypeChecker
    {
        ISmartPhone sam;
        IDumbPhone htc;
        IPhoneFactory factory;
        MANUFACTURERS manu;

        public PhoneTypeChecker(MANUFACTURERS m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            switch (manu)
            {
                case MANUFACTURERS.SAMSUNG:
                    factory = new Samsung();
                    break;

                case MANUFACTURERS.NOKIA:
                    factory = new Nokia();
                    break;
            }

            Console.WriteLine(manu.ToString() + ":\nSmart Phone: " +
            factory.GetSmart().Name() + "\nDumb Phone: " + factory.GetDumb().Name());
        }
    }
}
