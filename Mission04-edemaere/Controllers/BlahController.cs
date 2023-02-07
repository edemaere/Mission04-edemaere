using Microsoft.AspNetCore.Mvc;
using Mission04_edemaere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_edemaere.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }


        [HttpGet]
        public IActionResult Calculator()
        {
            return View("Calculator", new Calculator());
        }


        [HttpPost]
        public IActionResult Calculator(Calculator model)
        {

            // Calculate correct grade weight based on syllabus
            float assignments = model.Assignments * 0.5f;
            float grpProject = model.GrpProject * 0.1f;
            float quizzes = model.Quizzes * 0.1f;
            float midterm = model.Midterm * 0.1f;
            float final = model.Final * 0.1f;
            float intex = model.Intex * 0.1f;

            //Calculate overall percentage by summing percentages
            model.overallPercent = (assignments +grpProject + quizzes + midterm + final + intex);

            // If the total percent is from 0 - 100
            if ((model.overallPercent >= 0) && (model.overallPercent <= 100))
            {

                // Calculate letter grade based on overall percent
                if (model.overallPercent < 60) { model.letterGrade = "E"; }
                else if (model.overallPercent < 64) { model.letterGrade = "D-"; }
                else if (model.overallPercent < 67) { model.letterGrade = "D"; }
                else if (model.overallPercent < 70) { model.letterGrade = "D+"; }
                else if (model.overallPercent < 74) { model.letterGrade = "C-"; }
                else if (model.overallPercent < 77) { model.letterGrade = "C"; }
                else if (model.overallPercent < 80) { model.letterGrade = "C+"; }
                else if (model.overallPercent < 84) { model.letterGrade = "B-"; }
                else if (model.overallPercent < 87) { model.letterGrade = "B"; }
                else if (model.overallPercent < 90) { model.letterGrade = "B+"; }
                else if (model.overallPercent < 94) { model.letterGrade = "A-"; }
                else { model.letterGrade = "A"; }
            }
            else
            {
                model.overallPercent = 0f;
                model.letterGrade = "E";
            }

            return View(model);
        }
    }
}
