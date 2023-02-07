using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_edemaere.Models
{
    public class Calculator
    {

        // Validation in the model to ensure input between 0 and 100
        [Range(0,100)]
        public float Assignments { get; set; }
        [Range(0, 100)]
        public float GrpProject { get; set; }
        [Range(0, 100)]
        public float Quizzes { get; set; }
        [Range(0, 100)]
        public float Midterm { get; set; }
        [Range(0, 100)]
        public float Final { get; set; }
        [Range(0, 100)]
        public float Intex { get; set; }

        // Set defaults for calculated variables. When user submits, these will be updated
        public float overallPercent { get; set; } = 0f;
        public string letterGrade { get; set; } = "E";

    }

}