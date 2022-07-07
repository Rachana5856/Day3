using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace DisposeandFinalize
{
    class Program : IDisposable
    {
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(Boolean disposing)
        {
            if (disposed) return;

            if(disposing)
            {
                Console.WriteLine("Freeing Managed Resourses");
            }
            Console.WriteLine("Freeing UnManaged Resourses");
            disposed=true;
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.Dispose();
            BaseClassWithSafeHandle bc = new BaseClassWithSafeHandle();
            bc.Dispose();
            Console.ReadLine();
        }
    }
}
