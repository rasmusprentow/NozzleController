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

        private  AbstractBoardDrawer boardDrawer;
        private AbstractBoardDrawer preciseBoardDrawer;
        private int _innerBoxSixe = 100;
        public MainForm()
        {
            InitializeComponent();

            boardDrawer = new BoardDrawer(pBox, new Size(_innerBoxSixe,_innerBoxSixe));
            preciseBoardDrawer = new UpScaledBoardDrawer(pBoxPrecise);
            boardDrawer.DrawBoard();
            preciseBoardDrawer.DrawBoard();

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

       
            
            if (Control.ModifierKeys == Keys.Shift)
            {
               // SetCursor(pBox.Left + pBox.Width / 2, pBox.Top + pBox.Height / 2);
           //   SetCursor((int)(realX - deltaX), (int)(realY - deltaY));
              //  SetCursor(lastPosX, lastPosY); 
              //  SetCursor(realX, realY);
                //SetCursor(centerX + ((int)largeDeltaX), centerY + ((int)largeDeltaY));
                this.boardDrawer.MarkerPosition = new Point(e.X, e.Y);
               // this._nozzle.SetDestination(new Point(e.X, e.Y));
                this.UpdateCoordinates();
                
            }
          

          
            
        }

        
        private void UpdateCoordinates()
        {
            var realSize = new Size(1000, 1000);
            
            
            
            
            //var preciseBoxRealSize = new Size((int) ((realSize.Width /(float) this.pBox.Width) * this._innerBoxSixe), (int)((realSize.Height / (float)this.pBox.Height) * this._innerBoxSixe)) ;
            var p = this.boardDrawer.MarkerPosition;
            var precisePoint = this.preciseBoardDrawer.MarkerPosition;


            var offSetPoint = ToRealPoint(precisePoint, new Size(_innerBoxSixe, _innerBoxSixe), this.pBoxPrecise);
            var finalPosition = new Point(p.X + offSetPoint.X - _innerBoxSixe / 2, p.Y + offSetPoint.Y - _innerBoxSixe / 2);


            var realPosition = ToRealPoint(finalPosition, realSize, this.pBox);


            this.textBoxX.Text = realPosition.X.ToString();
            this.textBoxY.Text = realPosition.Y.ToString();


            this._nozzle.SetDestination(realPosition);
          //  350*X = 100 
          //      X = 1000/350
        }

        private Point ToRealPoint(Point p, Size realSize, PictureBox pBox)
        {
            Point realPosition = new Point((int) (p.X*((double) realSize.Width/pBox.Width)),
                (int) (p.Y*((double) realSize.Height/pBox.Height)));
            return new Point(realPosition.X <= realSize.Width ? realPosition.X : realSize.Width, realPosition.Y <= realSize.Height ? realPosition.Y : realSize.Height);
        }

        private void pBoxPrecise_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                // SetCursor(pBox.Left + pBox.Width / 2, pBox.Top + pBox.Height / 2);
                //   SetCursor((int)(realX - deltaX), (int)(realY - deltaY));
                //  SetCursor(lastPosX, lastPosY); 
                //  SetCursor(realX, realY);
                //SetCursor(centerX + ((int)largeDeltaX), centerY + ((int)largeDeltaY));
                this.preciseBoardDrawer.MarkerPosition = new Point(e.X, e.Y);
                this.UpdateCoordinates();

            }
        }



       
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
