using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class LibraryRepository
    {
        public void BorrowBook(int bookId, int studentId)
        {
            using (SqlConnection conn = new SqlConnection("connectionString"))
            {
                conn.Open();

                // Check if the book is available
                string checkAvailabilityQuery = "SELECT AvailableCopies FROM Books WHERE BookId = @BookId";
                SqlCommand checkCmd = new SqlCommand(checkAvailabilityQuery, conn);
                checkCmd.Parameters.AddWithValue("@BookId", bookId);
                int availableCopies = (int)checkCmd.ExecuteScalar();

                if (availableCopies > 0)
                {
                    // Insert into BorrowRecords
                    string borrowQuery = "INSERT INTO BorrowRecords (BookId, StudentId, BorrowDate) VALUES (@BookId, @StudentId, GETDATE())";
                    SqlCommand borrowCmd = new SqlCommand(borrowQuery, conn);
                    borrowCmd.Parameters.AddWithValue("@BookId", bookId);
                    borrowCmd.Parameters.AddWithValue("@StudentId", studentId);
                    borrowCmd.ExecuteNonQuery();

                    // Update AvailableCopies in Books
                    string updateCopiesQuery = "UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookId = @BookId";
                    SqlCommand updateCmd = new SqlCommand(updateCopiesQuery, conn);
                    updateCmd.Parameters.AddWithValue("@BookId", bookId);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    Console.WriteLine("No copies available for this book.");
                }
            }
        }
        public void ReturnBook(int borrowId)
        {
            using (SqlConnection conn = new SqlConnection("connectionString"))
            {
                conn.Open();

                // Get BorrowDate and calculate days late
                string getBorrowDateQuery = "SELECT BorrowDate, BookId FROM BorrowRecords WHERE BorrowId = @BorrowId";
                SqlCommand getCmd = new SqlCommand(getBorrowDateQuery, conn);
                getCmd.Parameters.AddWithValue("@BorrowId", borrowId);

                using (SqlDataReader reader = getCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DateTime borrowDate = reader.GetDateTime(0);
                        int bookId = reader.GetInt32(1);
                        int daysLate = (DateTime.Now - borrowDate).Days - 14;

                        // If late, insert fine
                        if (daysLate > 0)
                        {
                            string fineQuery = "INSERT INTO LibraryFines (BorrowId, FineAmount) VALUES (@BorrowId, @FineAmount)";
                            SqlCommand fineCmd = new SqlCommand(fineQuery, conn);
                            fineCmd.Parameters.AddWithValue("@BorrowId", borrowId);
                            fineCmd.Parameters.AddWithValue("@FineAmount", daysLate * 1.5); // Example fine rate
                            fineCmd.ExecuteNonQuery();
                        }

                        // Update BorrowRecord as returned
                        string returnQuery = "UPDATE BorrowRecords SET Returned = 1, ReturnDate = GETDATE() WHERE BorrowId = @BorrowId";
                        SqlCommand returnCmd = new SqlCommand(returnQuery, conn);
                        returnCmd.Parameters.AddWithValue("@BorrowId", borrowId);
                        returnCmd.ExecuteNonQuery();

                        // Update AvailableCopies in Books
                        string updateBookQuery = "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookId = @BookId";
                        SqlCommand updateBookCmd = new SqlCommand(updateBookQuery, conn);
                        updateBookCmd.Parameters.AddWithValue("@BookId", bookId);
                        updateBookCmd.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
