using System;
using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player
    {
        [Required(ErrorMessage = "Please Enter Your Name!")]
        public string FirstName { get; set; }
        [Range (1, 9, ErrorMessage = "Choose a number between 1 and 9!")]
        public int Luck { get; set; }
    }
}