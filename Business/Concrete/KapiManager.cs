using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class KapiManager : IKapiService
    {
        IKapiDal _kapiDal;

        public KapiManager(IKapiDal kapiDal)
        {
            _kapiDal = kapiDal;
        }

        public IResult Add(Kapi kapi)
        {
            _kapiDal.Add(kapi);
            return new SuccessResult(Messages.KapiAdded);
        }

        public IResult Delete(Kapi kapi)
        {
            _kapiDal.Delete(kapi);
            return new SuccessResult(Messages.KapiDeleted);
        }

        public IDataResult<Kapi> GetByKapiNo(int kapiNo)
        {
            return new SuccessDataResult<Kapi>(_kapiDal.Get(k => k.KapiNo == kapiNo));
        }

        public IDataResult<List<Kapi>> GetList()
        {
            return new SuccessDataResult<List<Kapi>>(_kapiDal.GetList().ToList());
        }

        public IDataResult<List<Kapi>> GetListByCode(int mahalleKodu)
        {
            return new SuccessDataResult<List<Kapi>>(_kapiDal.GetList(k => k.MahalleKodu == mahalleKodu).ToList());
        }

        public IResult Update(Kapi kapi)
        {
            _kapiDal.Updata(kapi);
            return new SuccessResult(Messages.KapiUpdated);
        }
    }
}
