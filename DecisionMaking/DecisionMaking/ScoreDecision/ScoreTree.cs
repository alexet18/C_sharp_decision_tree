using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class ScoreTree
    {
        private ScoreNode root;
        private String hypothesis;
        

        public ScoreTree()
        {
            
        }

        public ScoreTree(String hypothesis)
        {
            this.hypothesis = hypothesis;
        
        }

        public ScoreNode getRoot()
        {
            return this.root;
        }

        public String getHypothesis()
        {
            return this.hypothesis;
        }

        public void setRoot(ScoreNode root)
        {
            this.root = root;
        }

        public void setHypothesis(String hypothesis)
        {
            this.hypothesis = hypothesis;
        }

        public void addNode(ScoreNode n)
        {
            
        }

    }
}
