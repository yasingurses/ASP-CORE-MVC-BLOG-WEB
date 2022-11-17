using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal blDal;

        public BlogManager(IBlogDal blDal)
        {
            this.blDal = blDal;
        }

        public int Adding(Blog bl)
        {
            return blDal.Add(bl);
        }

        public int Deleting(Blog bl)
        {
            return blDal.Delete(bl);
        }

        public Blog GetBlog(int id)
        {
            return blDal.getByID(id);
        }

        public List<Blog> Listing()
        {
            return blDal.GetAll();
        }

        public int Updating(Blog bl)
        {
            return blDal.Update(bl);
        }
    }
}
