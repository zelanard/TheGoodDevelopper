using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodDevelopper.Controller;
using TheGoodDevelopper.Exceptions;
using TheGoodDevelopper.View;

namespace TheGoodDevelopper.Model
{
    /// <summary>
    /// Controls the Log
    /// </summary>
    internal class LogController
    {
        private LogFile _logfile;
        private LogDisplay _logdisplay;

        /// <summary>
        /// Construct the log controller.
        /// </summary>
        public LogController()
        {
            try
            {
                Logdisplay = new LogDisplay();
                Logfile = new LogFile(@"D:\Skole\Source\Opgaver\TheGoodDevelopper\TheGoodDevelopper\Data\LogFile.txt");
            }
            catch (Exception ex)
            {
                Logdisplay = new LogDisplay();
                Logdisplay.DisplayLog(ex.Message);
            }
        }
        
        /// <summary>
        /// get/set LogFile
        /// </summary>
        internal LogFile Logfile
        {
            get
            {
                return _logfile;
            }

            set
            {
                _logfile = value;
            }
        }

        /// <summary>
        /// get/set LogDisplay
        /// </summary>
        internal LogDisplay Logdisplay
        {
            get
            {
                return _logdisplay;
            }

            set
            {
                _logdisplay = value;
            }
        }

        /// <summary>
        /// Start the log controller.
        /// </summary>
        internal void Start()
        {
            Logdisplay.DisplayLineCount(Logfile.Lines);
            try
            {
                Logdisplay.DisplayLog(Logfile.ToString());
            }catch (LogNotFoundException ex)
            {
                Logdisplay.DisplayLog(ex.Message);
            }
            
            Logdisplay.WaitForAnyKey();
        }
    }
}
