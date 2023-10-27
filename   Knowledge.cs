using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.api
{
    public class Knowledge
    {
        public Guid _id{get;set;}
        public string _name{get;set;}
    }
    public class Knowledges
    {
        public List<Knowledge> _knowledges { get; }

        public Knowledges()
        {
            _knowledges = SetTestData();
        }

        private List<Knowledge> SetTestData()
        {
            List<Knowledge> Knowledges = new List<Knowledge>();

Knowledge test = new Knowledge() {_id=Guid.NewGuid(), _name ="DotNet"};

            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="DotNet"});
            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="Java"});
            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="Python"});
            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="JavaScript"});
            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="HTML"});
            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="CSS"});
            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="SQL"});
            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="MVC"});
            Knowledges.Add(new Knowledge() {_id=Guid.NewGuid(), _name ="API"});
            return Knowledges;
        }

    }
}