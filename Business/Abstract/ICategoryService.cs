using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int cateogryId); //Tek bir id'ye gore geldigi icin liste gerekmiyor
    }
}
