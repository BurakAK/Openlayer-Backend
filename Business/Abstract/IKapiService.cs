using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKapiService
    {
        IDataResult<Kapi> GetByKapiNo(int kapiNo);
        IDataResult<List<Kapi>> GetListByCode(int mahalleKodu);
        IDataResult<List<Kapi>> GetList();
        IResult Add(Kapi kapi);
        IResult Delete(Kapi kapi);
        IResult Update(Kapi kapi);
    }
}
