using System;
using System.Net.WebSockets;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Study.LabWork1.Features
{
    public class Tree
    {

        public double value;
        public int childenAmount;
        public List<Tree> children;


        public Tree(double val)
        {
            value = val;
            childenAmount = 0;
        }
        public Tree(double val, int amt, List<Tree> child){
            value = val;
            childenAmount = amt;
            if (amt > 0) {
                children = child;
            };
        }

        public Tree(double val, int amt, List<double> child)
        {
            value = val;
            childenAmount = amt;
            children = new List<Tree>();
            if (amt > 0)
            {
                for (int i = 0; i < childenAmount; i++)
                {
                    Tree tmp = new Tree(child[i]);
                    children.Add(tmp);
                }
            }

        }
        
        public void print(int order = 0)
        {
            for (int i = 0; i < order;i++) Console.Write("|");
            Console.WriteLine("- " + value);
            for (int i = 0; i < childenAmount; i++) children[i].print(order + 1);
            
        }

        public static explicit operator Tree(double d) => new Tree(d);

    }


    }
