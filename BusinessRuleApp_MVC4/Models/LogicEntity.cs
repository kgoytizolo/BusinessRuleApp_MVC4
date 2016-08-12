namespace BusinessRuleApp_MVC4.Models
{
    public class LogicEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Application ApplicationAssigned { get; set; }
    }
}