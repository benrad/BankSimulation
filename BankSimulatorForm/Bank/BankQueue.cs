using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorForm {
    class BankQueue {
        private BlockingCollection<Transaction> queue;

        public BankQueue(int capacity) {
            queue = new BlockingCollection<Transaction>(capacity);
        }

        public void Enqueue(Transaction transaction) {
            Debug.Print("Transaction enqueued, count = {0}", queue.Count.ToString());
            queue.Add(transaction);
        }

        public Transaction Dequeue() {
            Debug.Print("Transaction dequeued");
            return queue.Take();
        }    
    }
}