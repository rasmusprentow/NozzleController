using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SController
{
    public partial class MainForm : Form
    {

        private BoardDrawer boardDrawer;
     

        public MainForm()
        {
            InitializeComponent();

            boardDrawer = new BoardDrawer(pBox);
            boardDrawer.SetOnRedraw( new UpScaledBoardDrawer(pBoxPrecise).RedrawCallback);

            boardDrawer.DrawBoard();


            // Comport initializer
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            this.portComboBox.DataSource = ports;
            this.portComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ComPortManager.Instance.ActivePort.PortName = this.portComboBox.SelectedValue.ToString();

            // Baudrate initializer
            int[] baudrates = new[] { 9600 } ;
            this.baudRateComboBox.DataSource = baudrates;
            this.baudRateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ComPortManager.Instance.ActivePort.BaudRate = int.Parse( this.baudRateComboBox.SelectedValue.ToString() );

            _nozzle = new ComNozzleController();
            _nozzle.SetExecutionListener((s) =>
            {
                this.Invoke( new MethodInvoker(() =>
                {
                    this.cmdLog.AppendText(s + "\n");
                }));

            });
        }



        private int CenterX()
        {
            return this.pBox.Width / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetCursor(pBox.Left + pBox.Width / 2, pBox.Top + pBox.Height / 2);
            centerX = pBox.Left + pBox.Width / 2; 
            centerY = pBox.Top + pBox.Height / 2;
            largeDeltaX = largeDeltaY = 0f;
           
//            SetCursor(pBox.Left + pBox.Width / 2, pBox.Top + pBox.Height / 2);
        }



        private int lastPosX = 0;
        private int lastPosY = 0;
        private int centerX = 0;
        private int centerY = 0; 

        private float largeDeltaX = 0f;
        private float largeDeltaY = 0f;
        private ComNozzleController _nozzle;


        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {

        //    float mod = 1f;
        //    var realX = pBox.Left + e.X + 1;
        //    var realY = pBox.Top + e.Y + 1;
     
           // var realPoint = this.PointToClient(new Point(e.X, e.Y));
        
        //    // SetCursor(pBox.Left + pBox.Width / 2, pBox.Top + pBox.Height / 2);
        //    float deltaX = (lastPosX - realX) * (mod);
        //    float deltaY = (lastPosY - realY) * (mod);
        //    largeDeltaX += deltaX;
        //    largeDeltaY += deltaY;
        //
        //    this.textBoxX.Text = e.X.ToString() + " : " + largeDeltaX + " : " + deltaX* 100;
        //    this.textBoxY.Text = e.Y.ToString() + " : " + largeDeltaY + " : " + deltaY* 100;
        //
        //
        //    lastPosX = realX;
        //    lastPosY = realY;

            //this.Cursor = new Cursor(Cursor.Current.Handle);
            
            if (Control.ModifierKeys == Keys.Shift)
            {
               // SetCursor(pBox.Left + pBox.Width / 2, pBox.Top + pBox.Height / 2);
           //   SetCursor((int)(realX - deltaX), (int)(realY - deltaY));
              //  SetCursor(lastPosX, lastPosY); 
              //  SetCursor(realX, realY);
                //SetCursor(centerX + ((int)largeDeltaX), centerY + ((int)largeDeltaY));
                this.boardDrawer.MarkerPosition = new Point(e.X, e.Y);
                this._nozzle.SetDestination(new Point(e.X, e.Y));
                this.textBoxX.Text = e.X.ToString();
                this.textBoxY.Text = e.Y.ToString();
                
            }
          

          
            
        }

        private void SetCursor(int x, int y)
        {
        
            var point = this.PointToScreen(new Point(x, y));
      

            SetCursorPos(point.X, point.Y);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComPortManager.Instance.ActivePort.PortName = (this.portComboBox.SelectedValue.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



    }
}
