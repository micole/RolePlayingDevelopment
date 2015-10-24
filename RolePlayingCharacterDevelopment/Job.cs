using RolePlayingCityDevelopment;

namespace RolePlayingCharacterDevelopment
{
    public enum JobTitle
    {
        NoTitle,
        Owner,
        Cook,
        Patron,
        Captain
    }

    public class Job
    {
        public JobTitle jobTitle { get; set; }
        public Building location { get; set; }


        //TODO: Remove this, I don't want people to be able to generate buildings
        //At least, I don't think I do.
        public Job()
        {
            jobTitle = JobTitle.NoTitle;
            location = new Building();
        }
    }
}