namespace Tests.Domain.Entities.Base
{
    public class Test
    {
        public Guid Id {get; set;}

        public string Topic { get; set; } = "IT";

        public int TestTime { get; set; }

        public string Name {get; set;} = string.Empty;
    }
}