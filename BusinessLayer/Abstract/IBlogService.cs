using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        int Adding(Blog bl);
        int Deleting(Blog bl);
        int Updating(Blog bl);
        List<Blog> Listing();
        Blog GetBlog(int id);


    }
}
