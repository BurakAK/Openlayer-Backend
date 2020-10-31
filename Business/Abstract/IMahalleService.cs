using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMahalleService
    {
        IDataResult<Mahalle> GetByCode(int mahalleKodu);
        IDataResult<List<Mahalle>> GetList();
        IResult Add(Mahalle mahalle);
        IResult Delete(Mahalle mahalle);
        IResult Update(Mahalle mahalle);
    }
}
