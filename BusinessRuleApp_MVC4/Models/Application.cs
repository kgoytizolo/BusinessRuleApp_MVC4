namespace BusinessRuleApp_MVC4.Models
{
    public class Application
    {
        public enum ProgrammingLanguage
        {
            VisualNet,
            Java,
            JavaScript,
            Php
        };

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProgrammingLanguage ProgrLanguage { get; set; } 

    }
}