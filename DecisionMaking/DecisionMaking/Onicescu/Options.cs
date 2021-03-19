using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking.Onicescu
{
    class Options
    {
        private String name;
        private List<Criteria> criteriaList;


        public Options(String name)
        {
            this.name = name;
            criteriaList = new List<Criteria>();
        }

        public void addCriteria(Criteria criteria)
        {
            criteriaList.Add(criteria);
        }



    }
}
