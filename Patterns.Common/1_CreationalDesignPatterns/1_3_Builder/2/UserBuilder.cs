namespace Patterns.Common._1_CreationalDesignPatterns._1_3_Builder._2
{
    public class UserBuilder
    {
        private string name;
        private string username;
        private long age;
        private string city;

        public UserBuilder Name(string name)
        {
            this.name = name;
            return this;
        }
    }
}
