using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLAP_Document_Upload_Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new Documents.DOCUMENT()
            {
                DOC_APPLICANT_ID = "546264t4t"
            };
            var client = new Documents.DocumentsClient();
            var response = client.Store(doc);

            Console.WriteLine("Status: {0}", response.Status);
            Console.WriteLine("Message: {0}", response.Status);
        }
    }
}
