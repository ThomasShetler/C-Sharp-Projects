using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beautifulLambda
{
    class employee
    {
        private string first;
        private string last;
        private int id;
        public employee(string first, string last, int id)
        {
            first = this.first;
            last = this.last;
            id = this.id;
        }
        public string First
        {
            get { return first; }
            set { first = value; }
        }
        public string Last
        {
            get { return last; }
            set { last = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private List<employee> employeeList = new List<employee>();
        
         
    }

}
