using Dapper;
using EShop.Domain.Domain;
using EShop.Service.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class BookService:IBookService
    {
        private readonly string _connectionString;

        public BookService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OnlineLibraryDBConnectionString") ?? throw new System.ArgumentNullException(nameof(configuration));
        }

        public IEnumerable<SportsEvents> GetPartnerBooks()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var books = connection.Query("SELECT * FROM Books");

                List<SportsEvents> localBooks = new List<SportsEvents>();

                foreach (var book in books)
                {
                    var kniga = new SportsEvents
                    {
                        Id = book.Id,
                        Name = book.Title
                    };
                    localBooks.Add(kniga);
                }

                return localBooks;
            }
        }
    }
}
