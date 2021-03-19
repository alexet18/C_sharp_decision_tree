using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking.Onicescu
{
    class Criteria
    {
        private String name;
        private double k;
        private double value;


        public Criteria(String name, double k, double value)
        {
            this.name = name;
            this.k = k;
            this.value = value;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public double getK()
        {
            return this.k;
        }

        public void setK(double k)
        {
            this.k = k;
        }

        public double getValue()
        {
            return this.value;
        }
        public void setValue(double value)
        {
            this.value = value;
        }

    }
}
