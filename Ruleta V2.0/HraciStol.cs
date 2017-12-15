using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta_V2._0
{
    public class HraciStol
    {
        public HraciPole[] HraciPolicka = new HraciPole[37];

        public HraciStol()
        {
            Farba[] RozmiestnenieFarieb = new Farba[37]
            {
              Farba.zelena,
              Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cerna,
              Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena,
              Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cerna,
              Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena, Farba.cerna, Farba.cervena
            };

            for (int i = 0; i < RozmiestnenieFarieb.Length ; i++)
            {
                HraciPolicka[i].Farba = RozmiestnenieFarieb[i];
                HraciPolicka[i].Cislo = i;
                HraciPolicka[i].Rada = vratRadu(i);
                HraciPolicka[i].Lichost = vratLichost(i);



            }

           

        }

        private Lichost vratLichost(int cislo)
        {
            if (cislo == 0) return Lichost.zadna;
            if (cislo % 2 == 0) return Lichost.suda;
            return Lichost.licha;
            
        }

        private Rada vratRadu(int cislo)
        {
            if (cislo == 0) return Rada.zadna;
            if (cislo == 1 || cislo - 1 % 3 == 0) return Rada.prva;
            if (cislo == 2 || cislo - 2 % 3 == 0) return Rada.druha;
            return Rada.tretia;
            
            


        }
    }
}
