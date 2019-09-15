using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static int CreateUser( string name, string title, string author, string review)
        {
            UserModel data = new UserModel
            {
                Name = name,
                Title = title,
                Author = author,
                Review = review
            };
            string sql = @"insert into dbo.[UserTable] (Name, Title, Author, Review)
                            values( @Name, @Title, @Author, @Review);";
            return SqlDataAccess.SaveData(sql,data);
        }
        public static List<UserModel> LoadUsers()
        {
            string sql = @"select Id, Name, Title, Author, Review
                            from dbo.[UserTable];";

            return SqlDataAccess.LoadData<UserModel>(sql);
        }
    }
}
