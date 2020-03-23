using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConsoleTables;

namespace Repository_Pattern
{
    public class BookRepository : BaseRepository<Book>
    {
        public override void Create(Book Book)
        {
            var QueryString = " INSERT INTO Books (Book_Name, Book_Author, Book_Price) " +
                              " VALUES (@Book_Name, @Book_Author, @Book_Price); ";

            using SqlCommand Command = new SqlCommand(QueryString, Connection);

            SqlParameter Book_Name_Para = new SqlParameter("@Book_Name", SqlDbType.VarChar);
            Book_Name_Para.Value = Book.Name;
            Command.Parameters.Add(Book_Name_Para);

            SqlParameter Book_Author_Para = new SqlParameter("@Book_Author", SqlDbType.VarChar);
            Book_Author_Para.Value = Book.Author;
            Command.Parameters.Add(Book_Author_Para);

            SqlParameter Book_Price_Para = new SqlParameter("@Book_Price", SqlDbType.Int);
            Book_Price_Para.Value = Book.Price;
            Command.Parameters.Add(Book_Price_Para);

            Connection.Open();
            Command.ExecuteNonQuery();
        }

        public override void Delete(Book Book)
        {
            var QueryString = " DELETE FROM Books WHERE Book_ID = @Book_ID; ";

            using SqlCommand Command = new SqlCommand(QueryString, Connection);

            SqlParameter Book_ID_Para = new SqlParameter("@Book_ID", SqlDbType.Int);
            Book_ID_Para.Value = Book.ID;
            Command.Parameters.Add(Book_ID_Para);

            Connection.Open();
            Command.ExecuteNonQuery();
        }

        public override void Read()
        {
            var QueryString = " SELECT * FROM Books; ";
            List<Book> BookList = new List<Book>();

            using SqlCommand Command = new SqlCommand(QueryString, Connection);
            
            Connection.Open();
            using SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ID = (int)Reader["Book_ID"];
                string Name = (string)Reader["Book_Name"];
                string Author = (string)Reader["Book_Author"];
                int Price = (int)Reader["Book_Price"];
                BookList.Add(new Book(ID, Name, Author, Price));
            }

            ConsoleTable Books_Table = new ConsoleTable("ID", "Name", "Author", "Price");

            foreach (var item in BookList)
            {
                Books_Table.AddRow(item.ID, item.Name, item.Author, item.Price);
            }

            Books_Table.Write();
        }

        public override void Update(Book Book)
        {
            var QueryString = " UPDATE Books " +
                              " SET " +
                              "     Book_Name = @Book_Name, " +
                              "     Book_Author = @Book_Author, " +
                              "     Book_Price = @Book_Price " +
                              " WHERE Book_ID = @BooK_ID; ";

            using SqlCommand Command = new SqlCommand(QueryString, Connection);

            SqlParameter Book_ID_Para = new SqlParameter("@Book_ID", SqlDbType.Int);
            Book_ID_Para.Value = Book.ID;
            Command.Parameters.Add(Book_ID_Para);

            SqlParameter Book_Name_Para = new SqlParameter("@Book_Name", SqlDbType.VarChar);
            Book_Name_Para.Value = Book.Name;
            Command.Parameters.Add(Book_Name_Para);

            SqlParameter Book_Author_Para = new SqlParameter("@Book_Author", SqlDbType.VarChar);
            Book_Author_Para.Value = Book.Author;
            Command.Parameters.Add(Book_Author_Para);

            SqlParameter Book_Price_Para = new SqlParameter("@Book_Price", SqlDbType.Int);
            Book_Price_Para.Value = Book.Price;
            Command.Parameters.Add(Book_Price_Para);

            Connection.Open();
            Command.ExecuteNonQuery();
        }
    }
}
