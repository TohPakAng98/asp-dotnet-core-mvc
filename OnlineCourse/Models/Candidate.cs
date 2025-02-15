using System.ComponentModel.DataAnnotations;

namespace Models;

public class Candidate
{
    [Required(ErrorMessage = "E-mail is required.")]
    public String? Email { get; set; } = String.Empty;

    [Required(ErrorMessage = "First Name is required.")]
    public String? FirstName { get; set; } = String.Empty;

    [Required(ErrorMessage = "Last Name is required.")]
    public String? LastName { get; set; } = String.Empty;

    public String? FullName => $"{FirstName} {LastName.ToUpper()}";

    public int? Age { get; set; }
    public String? SelectedCourse { get; set; } = String.Empty;
    public DateTime ApplyDate { get; set; }

    public Candidate()
    {
        ApplyDate = DateTime.Now;
    }
}