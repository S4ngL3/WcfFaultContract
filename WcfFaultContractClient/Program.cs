using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfFaultContractClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1.Service1Client client = new Service1.Service1Client();

            // attemp to execute without catch exception
            /* An unhandled exception of type 'System.ServiceModel.FaultException' occurred in mscorlib.dll*/
            //client.Divide(1, 0);

            try
            {
                client.Divide(1, 0);
            }
            catch(FaultException ex)
            {
                Console.WriteLine("Error:=> " + ex.Message);
                client.Abort();
            }

            /*
            try
            {
                client.Divide(1, 0);
            }
            catch (FaultException<Service1.MathFault> e)
            {
                Console.WriteLine("FaultException<MathFault>: Math fault while doing " + e.Detail.Operation + ". Problem: " + e.Detail.ProblemType);
                client.Abort();
            }
            */
            client.Close();
            Console.ReadLine();
        }
    }
}
