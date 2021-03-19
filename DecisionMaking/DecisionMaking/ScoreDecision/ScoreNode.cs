using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class ScoreNode
    {
        private int key;
        private String data;
        private double score0;
        private double score1;
        ScoreNode left = null;
        ScoreNode right = null;

        public ScoreNode(int key)
        {
            this.score0 = 0;
            this.score1 = 0;
            this.key = key;
        }

     
        public ScoreNode(String data)
        {
            this.data = data;
          
        }

        public String getData()
        {
            return this.data;
        }

        public void setData(String data)
        {
            this.data = data;
        }

        public double getScore0()
        {
            return this.score0;
        }

        public void setScore0(double score)
        {
            this.score0 = score;
        }

        public double getScore1()
        {
            return this.score1;
        }

        public void setScore1(double score)
        {
            this.score1 = score;
        }

        public ScoreNode getLeft()
        {
            return this.left;
        }

        public ScoreNode getRight()
        {
            return this.right;
        }

        public void setLeft(ScoreNode left)
        {
            this.left = left;
        }

        public void setRight(ScoreNode right)
        {
            this.right = right;
        }

        public String getNodeText()
        {
           return this.key.ToString() + "\n" + "0: "  + this.score0.ToString() + "\n" + "1: " + this.score1.ToString();
        }


    }
}
