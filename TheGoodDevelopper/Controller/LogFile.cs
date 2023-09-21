using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodDevelopper.Exceptions;

namespace TheGoodDevelopper.Controller
{
    /// <summary>
    /// <c>LogFile</c> Handles a log file.
    /// </summary>
    internal class LogFile
    {
        private int _lines;
        private StringBuilder _log;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public LogFile(string path)
        {
            _log = new StringBuilder();
            ReadFile(path);
        }

        /// <summary>
        /// get/set the number of lines in the log file.
        /// </summary>
        public int Lines
        {
            get
            {
                return _lines;
            }

            private set
            {
                _lines = value;
            }
        }

        /// <summary>
        /// get/set Log StringVuilder
        /// </summary>
        public StringBuilder Log
        {
            get
            {
                return _log;
            }

            private set
            {
                _log = value;
            }
        }

        /// <summary>
        /// Reads the file and loads the data into the properties.
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="Exception"></exception>
        private void ReadFile(string path)
        {
            string errMessage = "Error {0}: Failed to handle file. Please forward this message to support!";
            string line;
            StreamReader reader = null; //init the reader to 0 to be sure we can use reader?.close() later.

            try
            {
                reader = new StreamReader(path);
                while ((line = reader.ReadLine()) != null)
                {
                    Lines++;
                    Log.AppendLine(line);
                }
            }
            catch (OutOfMemoryException ex)
            {
                throw new OutOfMemoryException(string.Format(errMessage, "001"));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new ArgumentOutOfRangeException(string.Format(errMessage, "002"));
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException(string.Format(errMessage, "003"));
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(string.Format(errMessage, "004"));
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(string.Format(errMessage, "005"));
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(string.Format(errMessage, "006"));
            }
            catch (IOException ex)
            {
                throw new IOException(string.Format(errMessage, "007"));
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format(errMessage, "008"));
            }
            finally
            {
                reader?.Close();
            }
        }

        //overrides Object.ToString()
        public override string ToString()
        {
            string errMessage = "Error {0}: Log file is not set!";
            Log = null;
            if (Log == null)
            {
                throw new LogNotFoundException(string.Format(errMessage, "009"));
            }
            return Log.ToString();
        }
    }
}
