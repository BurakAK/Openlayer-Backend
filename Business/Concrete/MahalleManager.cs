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
    public class MahalleManager : IMahalleService
    {
        IMahalleDal _mahalleDal;

        public MahalleManager(IMahalleDal mahalleDal)
        {
            _mahalleDal = mahalleDal;
        }

        public IResult Add(Mahalle mahalle)
        {
            _mahalleDal.Add(mahalle);
            return new SuccessResult(Messages.MahalleAdded);
        }

        public IResult Delete(Mahalle mahalle)
        {
            _mahalleDal.Delete(mahalle);
            return new SuccessResult(Messages.MahalleDeleted);
        }

        public IDataResult<Mahalle> GetByCode(int mahalleKodu)
        {
            return new SuccessDataResult<Mahalle>(_mahalleDal.Get(m => m.MahalleKodu == mahalleKodu));
        }

        public IDataResult<List<Mahalle>> GetList()
        {


            return new SuccessDataResult<List<Mahalle>>(_mahalleDal.GetList().ToList());
        }

        public IResult Update(Mahalle mahalle)
        {
            _mahalleDal.Add(mahalle);
            return new SuccessResult(Messages.MahalleUpdated);
        }
    }
}
