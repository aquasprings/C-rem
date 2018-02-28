using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ICandidateOperation object = new CandidateOperation();
            
            case 3:
            Console.WriteLine("Enter Position:");
            int flag = 0;
            string Position = Console.ReadLine().ToUpper();
            if(Position=="ASET" || Position=="ASE"|| Position=="SE"||Position=="ITA")
            {
                flag = 1; int t = 0;
                t = object.CountList(Position);

                if (t == 0)
                {
                    Console.WriteLine("Sorry!NO Record Found");

                }
                else
                {
                    Console.WriteLine("No of can in " +Position+"is :" + t);
                }

            }

            case 4:

            Console.WriteLine("Enter Candidate Id-");
            candidateId = Convert.ToInt32(Console.ReadLine());
            flag = object.delete(candidateId);

            if (flag == 1)
            {
                Console.WriteLine("Candidate details with CandidateId" + candidateId + "Successfully Deleted");
            }
            else
            {
                Console.WriteLine("CandidateID is not in the list!");
            }
            break;

case 3:
                            Console.WriteLine("Enter the job position from ASET,ASE,SE,ITA");
            string jobpos2 = Console.ReadLine();
            int nos = clis.NumberofStudents(jobpos2);
            Console.WriteLine("The number of candidates registered for " + jobpos2 + "is " + nos);
            break;

case 4:
                            Console.WriteLine("Enter the candidate id");
            int id = Convert.ToInt32(Console.ReadLine());
            clis.CancelRegistration(id);
            if (clis.K)
            {
                Console.WriteLine("Deleted Successfully");
            }
            else
                Console.WriteLine("Candidate Id is not in the list");
            break;



        }
    }while(select<5 && select >0);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Class1
    {

        public int CountList(string Pos)
        {
            int count = 0;
            foreach (ICandidate I in lst)
            {
                if (I.Position.Equals(Pos))
                {
                    count++;
                }

            }
            return count;
        }



        public int delete(int id)
        {
            int flag = 0;
            foreach (ICandidate obj in lst)
            {
                if (obj.Candidate_ID == id)
                {
                    flag = 1;
                    lst.Remove(obj);
                    break;
                }


            }
            return flag;
        }
    }
    bool m = false;
    public int NumberofStudents(string jobpos)
    {
        foreach (ICandidate ca1 in cl)
        {
            if (ca1.Jobpos == jobpos)
            {
                count++;
                m = true;
            }
        }
        return count;
    }
    bool k = false;

    public bool K
    {
        get
        {
            return k;
        }

        set
        {
            k = value;
        }
    }

    public bool M
    {
        get
        {
            return m;
        }

        set
        {
            m = value;
        }
    }



    public void CancelRegistration(int id)
    {
        foreach (ICandidate ca2 in cl)
        {
            if (ca2.CandId == id)
            {
                cl.Remove(ca2);
                k = true;
            }

        }
    }

}
