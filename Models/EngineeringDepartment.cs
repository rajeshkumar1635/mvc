namespace mvc_app.Models
{
    public class EngineeringDepartment
    {
        public string[] CurrentSoftwareProjects { get; set; }

        public EngineeringDepartment()
        {
            CurrentSoftwareProjects = ["Project A - AI Integration",
                "Project B - Cloud Migration",
                "Project C - Mobile App Development",
                "Project D - Data Analytics Platform"];
                  
        }
    }
}