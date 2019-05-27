using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CohortId { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Slack handle")]
        public string SlackHandle { get; set; }

        public Cohort Cohort { get; set; }

        public List<Exercise> AssignedExercises { get; set; } = new List<Exercise>();
    }
}