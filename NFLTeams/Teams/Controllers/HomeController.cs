using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Teams.Models;

namespace Teams.Controllers
{
    public class HomeController : Controller
    {
        private TeamContext context;
        public HomeController(TeamContext ctx)
        {
            context = ctx;
        }

        [Route("/conf-{activeConf}/div-{activeDiv}")]
        [Route("/")]

        public ViewResult Index(TeamsViewModel model)
        {
            // store conference and division IDs in viewbag

            model.Conferences = context.Conferences.ToList();
            model.Divisions = context.Divisions.ToList();

            //get teams - filter by conference and division
            IQueryable<Team> query = context.Teams.OrderBy(t => t.Name);

            if (model.ActiveConf != "all")
            {
                query = query.Where(t => t.Conference.ConferenceID.ToLower() == model.ActiveConf.ToLower());
            }

            if (model.ActiveDiv != "all")
            {
                query = query.Where(t => t.Division.DivisionID.ToLower() == model.ActiveDiv.ToLower());
            }

            //Executes the query
            model.Teams = query.ToList();

            return View(model);
        }

        public ViewResult Details(string id)
        {
            var team = context.Teams
                .Include(t => t.Conference)
                .Include(t => t.Division)
                .FirstOrDefault(t => t.TeamID == id) ?? new Team();
            return View(team);

        }
    }
}