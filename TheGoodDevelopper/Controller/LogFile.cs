using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            catch (OutOfMemoryException oOMEx)
            {
                throw new Exception("Out of memory!", oOMEx);
            }
            catch (ArgumentOutOfRangeException argOOREx)
            {
                throw new Exception("Out of memory!", argOOREx);
            }
            catch (ArgumentNullException argNullEx)
            {
                throw new Exception("Out of memory!", argNullEx);
            }
            catch (ArgumentException argEx)
            {
                throw new Exception("Out of memory!", argEx);
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                throw new Exception("Out of memory!", fileNotFoundEx);
            }
            catch (DirectoryNotFoundException dirNotFoundEx)
            {
                throw new Exception("Out of memory!", dirNotFoundEx);
            }
            catch (IOException IOEx)
            {
                throw new Exception("Out of memory!", IOEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Out of memory!", ex);
            }
            finally
            {
                reader?.Close();
            }
        }

        //overrides Object.ToString()
        public override string ToString()
        {
            return Log.ToString();
        }
    }
}
