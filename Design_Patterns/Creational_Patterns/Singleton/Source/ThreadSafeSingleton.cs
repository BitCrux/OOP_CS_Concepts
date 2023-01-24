using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Singleton.Source
{
    //https://csharpindepth.com/articles/singleton

    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object padlock = new object();
        private string _data;
        public string Data
        {
            get { return _data; }
        }

        // Constructor is 'private'
        private ThreadSafeSingleton(string data)
        {
            _data = data;
        }
        public static ThreadSafeSingleton Instance(string data)
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton(data);
                }
                return _instance;
            }
        }
    }
    //This implementation is thread-safe.The thread takes out a lock on a shared object, and then checks whether 
    //or not the instance has been created before creating the instance.This takes care of the memory barrier 
    //issue(as locking makes sure that all reads occur logically after the lock acquire, and unlocking makes sure
    //that all writes occur logically before the lock release) and ensures that only one thread will create an 
    //instance(as only one thread can be in that part of the code at a time - by the time the second thread enters 
    //it, the first thread will have created the instance, so the expression will evaluate to false). 
    //Unfortunately, performance suffers as a lock is acquired every time the instance is requested.
}
