
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace mobile
{
    public abstract class animal
    {
        public abstract string species();
        public abstract int legs();
        public abstract string food();
        public abstract string gender();
        public virtual string tail()
        {
            return "yes";
        }
        public virtual string wildanddomestic()
        {
            return "wild";
        }
    }

    public class Dog : animal
    {
        public override string species()
        {
            return "bulldog";
        }
        public override int legs()
        {
            return 4;
        }
        public override string food()
        {
            return "fish";
        }
        public override string gender()
        {
            return "male";
        }
        public override string tail()
        {
            return "no";
        }
        public override string wildanddomestic()
        {
            return "domestic";
        }

    }
    public class cat : animal
    {
        public override string species()
        {
            string species = "Street";
            return "Street";
            
        }
        public override int legs()
        {
            return 8;
        }
        public override string food()
        {
            return "fish fry";
        }
        public override string gender()
        {
            return "female";
        }
        public override string tail()
        {
            return "yes";
        }
        public override string wildanddomestic()
        {
            return "Wild";
        }

    }
    

    public class executeanimal
    {
        static void Main(string[] args)
        {

             cat obj = new cat();
            Type type = typeof(cat);
            var members = type.GetMembers();
            var props = type.GetProperty();
            var method = type.GetMethod();

        }
    }
   
    
}
