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
    public class TeamManager : ITeamService
    {
        ITeamDal tmDal;

        public TeamManager(ITeamDal tmDal)
        {
            this.tmDal = tmDal;
        }

        public int Adding(Team tm)
        {
            return tmDal.Add(tm);
        }

        public int Deleting(Team tm)
        {
            return tmDal.Delete(tm);
        }

        public Team GetTeam(int id)
        {
            return tmDal.getByID(id);
        }

        public List<Team> Listing()
        {
            return tmDal.GetAll();
        }

        public int Updating(Team tm)
        {
            return tmDal.Update(tm);
        }
    }
}
