using System.ComponentModel.DataAnnotations;


namespace StudentProjectAPI.ClientModels.Students
{
    public class StudentRequestModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Group { get; set; }

        [Required]
        public string Institute { get; set; }

        [Required]
        public string Department { get; set; }
    }
}
