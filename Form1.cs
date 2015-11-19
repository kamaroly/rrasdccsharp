using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialComms
{
    public partial class MainWindows : Form
    {
        SerialPort serialPort = new SerialPort();
        internal delegate void SerialDataReceivedEventHandlerDelegate(
           object sender, SerialDataReceivedEventArgs e);

        internal delegate void SerialPinChangedEventHandlerDelegate(
                 object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;
      
        public MainWindows()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initiate available ports
            this.initializeAvailableComports();

            // initiate available BaudRate
            this.initializeBaudRate();

            // initiate Handshaking
            this.initiateHandShaking();
            this.initiateStopBits();
            this.initiateParity();
        }

        /**
         * Show avaiable com port
         */
        private void btnShowPorts_Click(object sender, EventArgs e)
        {
            // Show available ports
            this.initializeAvailableComports();

            // Show available BaudRate
            this.initializeBaudRate();
        }

        /**
         * This shows all the devices that appear as com ports
         */
        public void initializeAvailableComports()
        {
            string[] availableComPorts = null; // Stores the available com ports on this computer
            int index = 1;
            string comPortName = null;

            // Make sure that we clean the rich text box

            // Attempt to get available ports on this computer
            comboBoxListPorts.Items.Clear();
            
            availableComPorts = SerialPort.GetPortNames();
            do
            {
                index += 1;
                comboBoxListPorts.Items.Add(availableComPorts[index]);
            }
            while (!((availableComPorts[index] == comPortName || (availableComPorts.GetUpperBound(0) == index))));

            //want to get first out, Just doing some ordering 
            if (index == availableComPorts.GetUpperBound(0))
            {
                comPortName = availableComPorts[0];
            }
            // Display the first element and show it in the
            // com box 
            comboBoxListPorts.Text = comPortName;
        }

        /**
         * The baud rate is the amount of possible events that can happen in a second. 
         * It is displays usually as a number of bit per second, the possible number
         * that can be used are 300, 600, 1200, 2400, 9600, 14400, 19200, 38400,
         * 57600, and 115200 (these come from the UAR 8250 chip is used, if a 16650
         * the additional rates of 230400, 460800 and 921600) .
         */
        public void initializeBaudRate()
        {
            comboBoxBaudRate.Items.Add(300);
            comboBoxBaudRate.Items.Add(600);
            comboBoxBaudRate.Items.Add(1200);
            comboBoxBaudRate.Items.Add(2400);
            comboBoxBaudRate.Items.Add(9600);
            comboBoxBaudRate.Items.Add(14400);
            comboBoxBaudRate.Items.Add(19200);
            comboBoxBaudRate.Items.Add(38400);
            comboBoxBaudRate.Items.Add(57600);
            comboBoxBaudRate.Items.Add(115200);
            comboBoxBaudRate.Items.ToString();
            //get first item print in text
            comboBoxBaudRate.Text = comboBoxBaudRate.Items[0].ToString();
        }

        /**
         * The Handshaking property is used when a full set of connections
         * are used (such as the grey 9 way D-types that litter my desk).
         * 
         * If the Handshake property is set to None the DTR and RTS pins 
         * are then freed up for the common use of Power, the PC on 
         * which this is being typed gives +10.99 volts on the DTR 
         * pin & +10.99 volts again on the RTS pin if set to true. 
         * If set to false it gives -9.95 volts on the DTR,
         * -9.94 volts on the RTS. These values are between +3
         * to +25 and -3 to -25 volts this give a dead zone 
         * to allow for noise immunity.
         */
        public void initiateHandShaking()
        {
            comboBoxHandShaking.Items.Add("None");
            comboBoxHandShaking.Items.Add("XOnXOff");
            comboBoxHandShaking.Items.Add("RequestToSend");
            comboBoxHandShaking.Items.Add("RequestToSendXOnXOff");
            comboBoxHandShaking.Text = comboBoxHandShaking.Items[0].ToString();

        }
        //Stop Bits
        public void initiateStopBits()
        {
            //Stop Bits
            comboBoxBits.Items.Add("One");
            comboBoxBits.Items.Add("OnePointFive");
            comboBoxBits.Items.Add("Two");
            //get the first item print in the text
            comboBoxBits.Text = comboBoxBits.Items[0].ToString();
        }
        //Parity 
        public void initiateParity()
        {
            //Parity 
            comboBoxParity.Items.Add("None");
            comboBoxParity.Items.Add("Even");
            comboBoxParity.Items.Add("Mark");
            comboBoxParity.Items.Add("Odd");
            comboBoxParity.Items.Add("Space");

            //get the first item print in the text

            comboBoxParity.Text = comboBoxParity.Items[0].ToString();

        }

        internal void PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            SerialPinChange SerialPinChange1 = 0;
            bool signalState = false;
            SerialPinChange1 = e.EventType;
            lblCTSStatus.BackColor = Color.Green;
            lblDSRStatus.BackColor = Color.Green;
            lblRIStatus.BackColor = Color.Green;
            lblBreakStatus.BackColor = Color.Green;

            switch (SerialPinChange1)
            {
                case SerialPinChange.Break:
                    lblBreakStatus.BackColor = Color.Red;
                    //MessageBox.Show("Break is Set");
                    break;
                case SerialPinChange.CDChanged:
                    signalState = serialPort.CtsHolding;
                    //  MessageBox.Show("CD = " + signalState.ToString());
                    break;
                case SerialPinChange.CtsChanged:
                    signalState = serialPort.CDHolding;
                    lblCTSStatus.BackColor = Color.Red;
                    //MessageBox.Show("CTS = " + signalState.ToString());
                    break;
                case SerialPinChange.DsrChanged:
                    signalState = serialPort.DsrHolding;
                    lblDSRStatus.BackColor = Color.Red;
                    // MessageBox.Show("DSR = " + signalState.ToString());
                    break;
                case SerialPinChange.Ring:
                    lblRIStatus.BackColor = Color.Red;
                    //MessageBox.Show("Ring Detected");
                    break;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            
            if (labelPortState.Text == "Closed")
            {
                labelPortState.Text = "Open";
                serialPort.PortName = Convert.ToString(comboBoxListPorts.Text);
                serialPort.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort.DataBits = Convert.ToInt16(comboBoxBits.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxBits.Text);
                serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBoxBits.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                serialPort.Open();
            }
            else if (labelPortState.Text == "Open")
            {
                labelPortState.Text = "Closed";
                serialPort.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPortState_Click(object sender, EventArgs e)
        {
            if (btnPortState.Text == "Closed")
            {
                btnPortState.Text = "Open";
            }
            else if (btnPortState.Text == "Open")
            {
                btnPortState.Text = "Closed";
                serialPort.Close();
            }
        }

        /**
         * OPEN THE PORT
         */
        private void openPort()
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = Convert.ToString(comboBoxListPorts.Text);
                serialPort.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxBits.Text);
                serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBoxHandShaking.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                serialPort.Open();
            }
        }
        /**
         * Close serial port
         */
        private void closePort()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }


        private void SetText(string text)
        {
            richTextResponse.Text = text;
        }

        private void buttonSendCommand_Click(object sender, EventArgs e)
        {


            string command = "c6"; // command to be sent
            // RtypeTTypeMRC,TIN,Date TIME, Rnumber,TaxRate1,TaxrRate2,TaxRate3,TaxRate4,Amount1,Amount2,Amount3,Amount4,Tax1,Tax2,Tax3,Tax4
            // "nstes01012345,100600570,17/07/2013 09:29:37,1,0.00,18.00,0.00,0.00,11.00,12.00,0.00,0.00,0.00,1.83,0.00,0.00";
            string data = richTextCommand.Text;
            string request = this.getSdcRequest(data, command);
            this.openPort();
            string response = this.communicateToSdc(request); //richTextCommand.Text
            this.SetText(response);
            this.closePort();
        }

        public string getSdcId()
        {
            string request = this.getSdcRequest("", "E5");

            string response = this.communicateToSdc(request);

            return response;
        }
        /**
         * Method to send request to SDC
         */
        public string communicateToSdc(string commandString)
        {
            // Writing bytes to serial port
            byte[] bytes = commandString.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
            serialPort.Write(bytes, 0, bytes.Length);

            System.Threading.Thread.Sleep(10); // Wait 1 millsecond for the answer 

            // Read response from the serial ports
            int responsebytes = serialPort.BytesToRead;
            byte[] buffer = new byte[responsebytes];
            serialPort.Read(buffer, 0, responsebytes);

            // returns the position of end of data <01><LEN><SEQ><CMD><DATA><04><STATUS><05><BCC><03> 
            int dataRange = Array.IndexOf(buffer, (byte)4) - 4;
            if (dataRange > 0)
            {
                byte[] cleanData = new ArraySegment<byte>(buffer, 4, dataRange).ToArray();
                cleanData = this.Decode(cleanData);
                return System.Text.Encoding.UTF8.GetString(cleanData, 0, dataRange);   
            }
            
            // From byte array to string
            return System.Text.Encoding.UTF8.GetString(buffer, 0, responsebytes);      
        }

      
        /**
         * Get SDC request method
         * @Author Kamaro Lambert
         * @param string data //  RtypeTTypeMRC,TIN,Date TIME, Rnumber,TaxRate1,TaxrRate2,TaxRate3,TaxRate4,Amount1,Amount2,Amount3,Amount4,Tax1,Tax2,Tax3,Tax4
         *                    // Example : "nstes01012345,100600570,17/07/2013 09:29:37,1,0.00,18.00,0.00,0.00,11.00,12.00,0.00,0.00,0.00,1.83,0.00,0.00"
         * @param string command // Command to sdc example c6
         */
        private string getSdcRequest(string data="", string command="")
        {
            string sequence = "22"; // Sequence to send
            string commandLength;   // Length of the command
            string commandBcc;      // CheckSum of the command
            string request;

            // Make sure ALL are in  caps
            data = data.ToUpper();        
            data = this.getHexData(data);
            command = command.ToUpper();

            request =  sequence + " " + command.ToUpper() + " " + data + " 05";

            // Get the length of the byte hex to be sent
            commandLength = this.getLength(data);

            // Add length to the request
            request = commandLength + " " + request;
            
            // Get checksum(BCC) of this command
            commandBcc = this.getBcc(request);  

            // For example to look for serial number you have to pass "01 24 20 E5 05 30 31 32 3E 03" OR 
            // SDC Status "01 24 20 E7 05 30 31 33 30 03"
            return request = "01" + " " + request + " " + commandBcc + " 03";
        }

        /**ret
         * Method to generate command to be sent to SDC
         */
        private string getHexData(string dataString)
        {
          // First you'll need to get it into a byte[], so do this:
          byte[] bytes = Encoding.Default.GetBytes(dataString);

          //and then you can get the string:
          string hexString = BitConverter.ToString(bytes);
           
          // now, that's going to return a string with dashes (-) in it so you can then simply use this:
          return hexString.Replace("-", " ").ToUpper();
        }

        /**
         * Number of bytes from <01> (excluded) to <05> (included) plus a fixed offset
         * 20h Length: 1 byte;
         * 
         * @Author Lambert Kamaro
         */
        private string getLength(string data)
        {     
            // Find the length by counting the data and adding length itsself, 
            // sequence,command,Post amble 05 (TOTAL=4)
            //, and 20h which is 32 in decimal which is 36 in total
            int length = 36;
 
            if (!string.IsNullOrWhiteSpace(data))
            {
                // Make sure that data is in capital letter 
                data = data.ToUpper();
                byte[] bytes = data.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
                length += bytes.Length;
            }

            byte[] lengthArray = BitConverter.GetBytes(length);
            lengthArray = this.Decode(lengthArray);
            string hex = BitConverter.ToString(lengthArray);

            return hex.ToUpper();
        }

           /**
           * @Author Kamaro Lambert
           * Method to get the BCC or the HEX to send to SDC
           * ===============================================
           * Check sum (0000h-FFFFh)
           * Length: 4 bytes; value: 30h - 3Fh
           * The check sum is formed by the bytes following <01> (without it) to <05>
           * included, by summing (adding) the values of the bytes. Each digit is sent as
           * an ASCII code.
           * =============================================== 
           * @param string $string sum of hex bytes between 01 excluded and 05 included
           * @return string
           */
        private string getBcc(string dataWithLengthAndCommand)
        {
            // First make sure the string is in capital
            string[] dataArray = dataWithLengthAndCommand.Split(' ');
            
            // This will hold the sum of values of the bytes
            int checkSum = 0; 
      
            // Summing (adding) the values of the bytes
            foreach(string hexBit in dataArray)
            {
                 int asciiValue = Convert.ToInt32(hexBit, 16);
                 checkSum += asciiValue;
            }

            // Getting the ascii value of each digit in the response because as per
            // the technical specification we need to get the ascii value before
            // we convert it back to the HEX
            byte[] asciiBytes = Encoding.ASCII.GetBytes(checkSum.ToString());
            
            // Since the BCC string needs to be 4 Digits, if the asciibytes
            // Doesn't reach 4 digits, compliment it by add missing bytes
            // we just need to add 30 because 30 is the ascii value of 0

            string checkSumString = "";
            // Prefixing missing bcc byte to the response
            if (asciiBytes.Length < 4)
            {
                for (int count = 0; count < 4 - asciiBytes.Length; count++)
                {
                    checkSumString += " 30";
                }
            }

            // Let's calculate the Hex value for the BCC now
            foreach(int bccValue in asciiBytes)
            {
                checkSumString +=" "+bccValue.ToString("X");
            }

            return checkSumString.TrimStart().ToUpper();     
        }

        /**
         * Remove 00 data from this array
         */
        public byte[] Decode(byte[] packet)
        {
            var i = packet.Length - 1;
            while (packet[i] == 0)
            {
                --i;
            }
            var temp = new byte[i + 1];
            Array.Copy(packet, temp, i + 1);
            return temp;
        }
    }
}
