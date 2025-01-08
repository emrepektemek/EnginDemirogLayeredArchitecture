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
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) // bu parametre business katmanindaki category manager  data access katmanina bagliyiz fakat zayif baglilik vardir cunku interface referansi ustunden bagliyiz yani bagimli olacaksan da bu bag en az olmalidir
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            // is kodlari

            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c=>c.CategoryId == categoryId);    
        }
    }
}
