using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public List<Category> GetAll()
        {
            return _categorydal.GetAll();
        }
        //Select * from Categories where categoryId = 3
        public List<Category> GetAllById(int categoryId)
        {
            return _categorydal.GetAll(c=>c.CategoryId == categoryId);
        }
    }
}
