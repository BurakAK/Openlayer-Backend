using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Mahalle : IEntity
    {
        public int Id { get; set; }
        public int MahalleKodu { get; set; }
        public string MahalleAdi { get; set; }
        public string Koordinatlar { get; set; }
    }
}
