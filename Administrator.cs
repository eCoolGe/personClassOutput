using static System.Console;

namespace DopZ_PZ_10
{
    internal class Administator : Person
    {
        protected string laboratory;

        public Administator(string firstname, DateOnly birthday, string laboratory) : base(firstname, birthday)
        {
            base.firstname = firstname;
            base.birthday = birthday;
            this.laboratory = laboratory;
        }

        public string Laboratory
        {
            get { return laboratory; }
            set { laboratory = value; }
        }

        public new void Print()
        {
            base.Print();
            WriteLine($"Лаборатория = {laboratory}");
        }
    }
}
