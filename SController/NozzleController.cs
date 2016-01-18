using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Threading;

namespace SController
{

    interface INozzleController
    {
        void SetDestination(Point point); 
    }

 


    class ComNozzleController : INozzleController
    {
     
        public ComNozzleController()
        {
             new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    string cmd = null;
                    lock (_lockObject)
                    {
                        if (_queue.Count > 0)
                        {
                            cmd = _queue.First();
                            _queue.RemoveAt(0);
                        }
                    }

                    if (cmd != null)
                    {
                        if (!ComPortManager.Instance.ActivePort.IsOpen)
                        {
                            _onCmdExecuted("Opening port: " + ComPortManager.Instance.ActivePort.PortName);
                            ComPortManager.Instance.ActivePort.Open();
                            _onCmdExecuted("Open finished");
                        }
                        ComPortManager.Instance.ActivePort.WriteLine(cmd);
                        _onCmdExecuted.Invoke(cmd);
                    }
                    Thread.Sleep(100);
                    
                }

            }).Start();
        }

        private readonly Object _lockObject = new Object();

        
        private List<String> _queue = new List<String>();
        private static Action<string> _onCmdExecuted;


        public void SetDestination(Point point)
        {
            
                lock (_lockObject)
                {
                    _queue= new List<String>() { String.Format("G0 X{0} Y{1} Z10", point.X, point.Y)};
                    
                }
            
       
           

        }


        public void SetExecutionListener(Action<string> action)
        {
            _onCmdExecuted = action;
        }
    }
}
