using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        //отвечает за храннеие, проверку достоверности и подтверждение ответа на приглашение
        [Required(ErrorMessage = "Enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter email")]
        [EmailAddress(ErrorMessage = "Enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Srecify whether you'll attend")]
        public bool? WillAttend { get; set; } //true,false,null
    }
}
