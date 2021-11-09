using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webbshop.Data;
using Webbshop.Models;

namespace Webbshop.Pages
{
    public class AdminAddGameModel : PageModel
    {

        public void OnGet()
        {
        }

        //public void OnPost()
        //{
        //    Data.GameManager.NewGame(Name, Price, AgeRestriction, Description, Stock, Genre, ReleaseDate, Studio, CriticScore, ImageURL);
        //    Data.GameManager.GetGames();
        //}

    }
}
