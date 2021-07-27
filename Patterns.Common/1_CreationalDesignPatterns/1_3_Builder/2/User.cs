namespace Patterns.Common._1_CreationalDesignPatterns._1_3_Builder._2
{
    public class User
    {
        private string name;
        private string username;
        private long age;
        private string city;

        public User(string name, string username, long age, string city)
        {
            this.name = name;
            this.username = username;
            this.age = age;
            this.city = city;
        }
    }
}
