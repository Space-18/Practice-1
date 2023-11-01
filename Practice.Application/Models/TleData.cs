namespace Practice.Application.Models
{
    public class TleData
    {
        public List<Member>? Member { get; set; } = new();
    }

    public class Member
    {
        public string? Name { get; set; }
    }
}
