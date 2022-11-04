namespace GreetMe_MVC.Interfaces
{
    public interface IComponent
    {

        public int Position { get; set; }
        public string getData();

        public string getDataDouble();

    }
}
