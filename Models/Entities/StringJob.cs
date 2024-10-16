namespace StringingStore.Models.Entities
{
    public class StringJob
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RacketModel { get; set; }
        public string StringPattern { get; set; }
        public string StringName { get; set; }
        public int Tension { get; set; }
    }
}
