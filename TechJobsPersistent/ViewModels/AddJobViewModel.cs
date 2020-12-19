using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job Name is Required")]
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public int SkillId { get; set; }
        public List<SelectListItem> Skills { get; set; }


        public AddJobViewModel(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add
                (
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                ); ;
            }
        }

        public AddJobViewModel(List<Skill> skills)
        {
            Skills = new List<SelectListItem>();

            foreach (var skill in skills)
            {
                Skills.Add
                (
                    new SelectListItem
                    {
                        Value = skill.Id.ToString(),
                        Text = skill.Name
                    }
                ); ;
            }
        }


        public AddJobViewModel()
        {
        }
    }
}
