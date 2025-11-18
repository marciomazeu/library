using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BorrowingRecords
    {
        private DateTime? borrowDateDelivery;

        public int Id { get; set; }

        public int BookId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string BookName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Type the title of the book")]
        public required string BookTitle { get; set; }
        [Required(ErrorMessage = "Type the description of the book")]
        public string BookDescription { get; set; } = string.Empty;
        public int PersonId { get; set; }
        [Required(ErrorMessage = "Type the name of the person")]
        public required string PersonName { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime BorrowDateDelivery { get; set; }
        public bool IsBorrowed { get; set; } = false;
    }
}
