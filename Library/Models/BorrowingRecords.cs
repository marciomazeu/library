namespace Library.Models
{
    public class BorrowingRecords
    {

        public int BookId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string BookTitle { get; set; } 
        public string BookDescription { get; set; } = string.Empty;
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime BorrowDateDelivery { get; set; } = DateTime.Now;
    }
}
