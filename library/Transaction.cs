namespace library
{
    internal class Transaction
    {
        public string TransactionID { get; set; }
        public string MemberID { get; set; }
        public string LibraryItemID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Transaction(string transactionID, string memberID, string itemID)
        {
            TransactionID = transactionID;
            MemberID = memberID;
            LibraryItemID = itemID;
            BorrowDate = DateTime.Now;
            ReturnDate = null;
        }
    }
}
