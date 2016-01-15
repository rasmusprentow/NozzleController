using System;
using System.Collections.Generic;
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

        public void SetActiveComport(string comport) {
            this.portName = comport;
        }

        public void SetBaudRate(string baudRate)
        {
            this.baudRate = baudRate;
        }

    }
}
