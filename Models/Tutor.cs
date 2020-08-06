namespace Tutor_Appointments_MVC.Models
{
    //Tutor information
    public class Tutor
    {
        //Tutor id
        public int Id { get; set; }

        //Tutor name
        public string Name { get; set; }

        //Tutor email
        public string TutorEmail { get; set; }

        //Tutor mobile
        public string Mobile { get; set; }

        //Tutor faculty information
        public int FacultyId { get; set; }

        public Faculty Faculty { get; set; }

    }
}
