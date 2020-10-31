using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kapi : IEntity
    {
        public int Id { get; set; }
        public int MahalleKodu { get; set; }
        public int KapiNo { get; set; }
        public string Koordinatlar { get; set; }
    }
}
