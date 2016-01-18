using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SController
{
    class ComPortManager
    {

        private static ComPortManager _instance;

        public static ComPortManager Instance { get {
            if( _instance == null) {
                _instance = new ComPortManager();
            }
            return _instance;
        }}


        private string portName;
        private string baudRate;
        private static Action<string> _onCmdExecuted;

        public ComPortManager()
        {
            ActivePort = new SerialPort();
        }

        public SerialPort ActivePort { get; set; }



       
    }
}
