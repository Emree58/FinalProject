using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //Is kodlari
            return _categoryDal.GetAll();
        }

        //Select * from Categories where Categoryid = 3 (alttaki c=> kod anlami)
        public Category GetById(int cateogryId)
        {
            return _categoryDal.Get(c=>c.CategoryId == cateogryId);
        }
    }
}
