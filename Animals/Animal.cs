using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public   string Name { get; protected set; }
        public string FavoriteFood { get; protected set; }
        public virtual string ExplainMyself()
        {
            return $"I am {this.Name} and my fav food is {this.FavoriteFood}";
        }
    }
}
