using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Utils
{
    public abstract class COMPortBase
    {
        protected SerialPort _serialPort;

        protected string _portName;

        protected Encoding _encoding;

        public void Open()
        {
            if (!SerialPort.GetPortNames().Any((string x) => x == _portName))
            {
                return;
            }
            Close();
            if (_portName == null)
            {
                return;
            }
            _serialPort = new SerialPort(_portName)
            {
                BaudRate = 9600,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None
            };
            if (_encoding != null)
            {
                _serialPort.Encoding = _encoding;
            }
            if (_serialPort == null || _serialPort.IsOpen)
            {
                return;
            }
            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                Helper.ShowNotifyIcon(ex.Message);
            }
        }

        public virtual void AddDataReceived(SerialDataReceivedEventHandler dataReceived)
        {
            if (_serialPort != null)
            {
                _serialPort.DataReceived += dataReceived;
            }
        }

        public virtual void RemoveDataReceived(SerialDataReceivedEventHandler dataReceived)
        {
            if (_serialPort != null)
            {
                _serialPort.DataReceived -= dataReceived;
            }
        }

        public void Close()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        public void Dispose()
        {
            if (_serialPort != null)
            {
                _serialPort.Dispose();
            }
        }

        public bool IsOpen()
        {
            if (_serialPort == null)
            {
                return false;
            }
            return _serialPort.IsOpen;
        }
    }
}
