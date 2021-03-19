using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking.Onicescu
{
    class OnicescuDecision
    {
        private String name;
        private List<Options> options;

        public OnicescuDecision()
        {
            options = new List<Options>();
        }

        public void addOption(Options option)
        {
            this.options.Add(option);
        }

        public Options getOption(int index)
        {
            return this.options.ElementAt(index);
        }
    }
}
