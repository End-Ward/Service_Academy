using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Agendas = new List<Agenda>
        {
            new Agenda { Image = "icon1.jpg", Title = "BatStateU Inclusive Social Innovation for Regional Growth (BISIG)", Description = "Description for BISIG" },
            new Agenda { Image = "icon2.jpg", Title = "Livelihood and other Entrepreneurship related on Agri-Fisheries (LEAF)", Description = "Description for LEAF" },
            new Agenda { Image = "icon3.jpg", Title = "Environment and Natural Resources Conservation, Protection and Rehabilitation", Description = "Description for Environment" },
            new Agenda { Image = "icon4.jpg", Title = "Smart Analytics and Engineering Innovation", Description = "Description for Smart Analytics" },
            new Agenda { Image = "icon5.jpg", Title = "Adopt-a-Municipality / Adopt-a-Municipality / Social Development thru BIDANI Implementation", Description = "Description for BIDANI" },
            new Agenda { Image = "icon6.jpg", Title = "Community Outreach", Description = "Description for Community Outreach" },
            new Agenda { Image = "icon7.jpg", Title = "Technical-Vocational Education and Training (TVET)", Description = "Description for TVET" },
            new Agenda { Image = "icon8.jpg", Title = "Technology Transfer, and Adoption/Utilization", Description = "Description for Technology Transfer" },
            new Agenda { Image = "icon9.jpg", Title = "Technical Assistance and Advisory Services", Description = "Description for Technical Assistance" },
            new Agenda { Image = "icon10.jpg", Title = "Parents’ Empowerment thru Social Development (PESODEV)", Description = "Description for PESODEV" },
            new Agenda { Image = "icon11.jpg", Title = "Gender and Development", Description = "Description for Gender and Development" },
            new Agenda { Image = "icon12.jpg", Title = "Disaster Risk Reduction and Management and Disaster Preparedness and Response / Climate Change Adoption (DRRM and DPR / CCA)", Description = "Description for DRRM and DPR / CCA" }
        };

        return View();
    }
}

public class Agenda
{
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
