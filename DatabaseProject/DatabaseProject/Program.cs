using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseProject
{
    class Program
    {

        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                int options = 0;

                Console.WriteLine("Select a option: 1. Create, 2. Read, 3. Update, 4. Delete");
                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Create.CreateTable();
                        break;
                    case 2:
                        Read.ReadTable();
                        break;
                    case 3:
                        Update.UpdateTable();
                        break;
                    case 4:
                        Delete.DeleteTable();
                        break;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }

    class Create
    {
        //Game game1 = new Game("Tetris1", "Board Game1", "Simple Game1", "Average1");
        //Game game1 = new Game("tictoe", "Board Game", "X or 0 game", "boring");
        //Game game1 = new Game("MHW", "Fighting", "online game", "excellent");
        
        public static void CreateTable()
        {
            Game game1 = new Game("uncharted", "RPG", "long game", "very good");
            string insertString = string.Format("INSERT INTO Games (GameName, genre, GameType, reivew) VALUES ('{0}', '{1}', '{2}', '{3}')", game1.Name, game1.Genre, game1.Type, game1.Review);
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand insertcommand = new SqlCommand(insertString, conn);
                insertcommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    class Read
    {
        public static void ReadTable()
        {
            string readstring = string.Format("SELECT * FROM Games");
            Console.WriteLine(readstring);
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand readCommand = new SqlCommand(readstring, conn);
                readCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    class Update
    {
        public static void UpdateTable()
        {
            string updatestring = string.Format("UPDATE Games SET GameName = 'MonsterWorld' WHERE GameName = 'MHW'");
            Console.WriteLine(updatestring);
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand updateCommand = new SqlCommand(updatestring, conn);
                updateCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    class Delete
    {
        public static void DeleteTable()
        {
            string deletestring = string.Format("DELETE FROM Games WHERE GameName = '#'");
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand(deletestring, conn);
                deleteCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    class Game
    {
        string name = "";
        string genre = "";
        string type = "";
        string review = "";

        public Game(string name, string genre, string type, string review)
        {
            this.name = name;
            this.genre = genre;
            this.type = type;
            this.review = review;
        }

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Type { get => type; set => type = value; }
        public string Review { get => review; set => review = value; }
    }
}
