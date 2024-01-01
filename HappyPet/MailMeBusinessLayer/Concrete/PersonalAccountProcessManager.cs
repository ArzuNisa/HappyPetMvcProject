using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyPetBusinessLayer.Abstract;
using HappyPetDataAccessLayer.Abstract;
using HappyPetEntityLayer.Concrete;

namespace HappyPetBusinessLayer.Concrete
{
    public class PersonalAccountProcessManager : IPersonalAccountProcessService
    {
        private readonly IPersonalAccountProcessDal _personalAccountProcessDal;

        public PersonalAccountProcessManager(IPersonalAccountProcessDal personalAccountProcessDal)
        {
            _personalAccountProcessDal = personalAccountProcessDal;
        }

        public void TDelete(PersonalAccountProcess t)
        {
            _personalAccountProcessDal.Delete(t);
        }

        public PersonalAccountProcess TGetByID(int id)
        {
            return _personalAccountProcessDal.GetByID(id);
        }

        public List<PersonalAccountProcess> TGetList()
        {
            return _personalAccountProcessDal.GetList();
        }

        public void TInsert(PersonalAccountProcess t)
        {
            _personalAccountProcessDal.Insert(t);
        }

        public void TUpdate(PersonalAccountProcess t)
        {
            _personalAccountProcessDal.Update(t);
        }
    }
}
