using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    interface IMuhasebeciKod<TClass>
    {
        List<TClass> GetAll();
        void Ekle(TClass muhasebeci);
        void Guncelle(TClass muhasebeci);
        void Cikar(int id);
    }
}
