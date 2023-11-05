namespace portfolio.api
{
    public class KnowledgeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string KnowledgeCategory { get; set; }
        public Guid KnowledgeCategoryId { get; set; }
    }
    public class KnowledgeList
    {
        public List<KnowledgeDto> _knowledges { get; }

        // public KnowledgeList()
        // {
        //     _knowledges = SetTestData();
        // }

        // private List<KnowledgeDto> SetTestData()
        // {
        //     List<KnowledgeDto> Knowledges = new List<KnowledgeDto>();

        //     KnowledgeDto test = new KnowledgeDto() { _id = Guid.NewGuid(), _name = "DotNet" };

        //     Knowledges.Add(new KnowledgeDto() { ID = Guid.NewGuid(), _name = "DotNet" });
        //     Knowledges.Add(new KnowledgeDto() { _id = Guid.NewGuid(), _name = "Java" });
        //     Knowledges.Add(new KnowledgeDto() { _id = Guid.NewGuid(), _name = "Python" });
        //     Knowledges.Add(new KnowledgeDto() { _id = Guid.NewGuid(), _name = "JavaScript" });
        //     Knowledges.Add(new KnowledgeDto() { _id = Guid.NewGuid(), _name = "HTML" });
        //     Knowledges.Add(new KnowledgeDto() { _id = Guid.NewGuid(), _name = "CSS" });
        //     Knowledges.Add(new KnowledgeDto() { _id = Guid.NewGuid(), _name = "SQL" });
        //     Knowledges.Add(new KnowledgeDto() { _id = Guid.NewGuid(), _name = "MVC" });
        //     Knowledges.Add(new KnowledgeDto() { _id = Guid.NewGuid(), _name = "API" });
        //     return Knowledges;
        // }

    }
}