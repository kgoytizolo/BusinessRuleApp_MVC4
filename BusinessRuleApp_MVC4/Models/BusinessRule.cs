using System;
using System.Collections.Generic;

namespace BusinessRuleApp_MVC4.Models
{
    public class BusinessRule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BusinessRuleType RuleType { get; set; }
        public List<LogicEntity> AssociatedClasses { get; set; }
        public string ConditionsJsonFile { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string userCreation { get; set; }
        public string userLastUpdate { get; set; }
    }
}