namespace DesignPatterns
{
    public abstract class AnimalToy
    {
        public string Name { get; set; }
        protected AnimalToy(string name1)
        {
            Name = name1;
        }
    }
}