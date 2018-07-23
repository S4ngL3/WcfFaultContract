using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFaultContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int Add(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public int Divide(int n1, int n2)
        {
            return n1 / n2;

            //try
            //{
            //    return n1 / n2;
            //}
            //catch (DivideByZeroException)
            //{
            //    MathFault mf = new MathFault();
            //    mf.Operation = "division";
            //    mf.ProblemType = "divide by zero";
            //    throw new FaultException<MathFault>(mf);
            //}
        }

        public int Multiply(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int n1, int n2)
        {
            throw new NotImplementedException();
        }
    }
}
