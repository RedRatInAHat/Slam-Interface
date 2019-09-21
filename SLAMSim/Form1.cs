using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace SLAMSim
{
    public partial class Form1 : Form
    {
        ScriptEngine engine;
        ScriptScope scope;
        int clientID;

        public Form1()
        {
            InitializeComponent();
            engine = Python.CreateEngine();
            scope = engine.CreateScope();

            var libs = new[] {
                "PythonScripts/AddModules",
                "C:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\Common7\\IDE\\Extensions\\Microsoft\\Python Tools for Visual Studio\\2.2",
                "C:\\Program Files (x86)\\IronPython 2.7\\Lib",
                "C:\\Program Files (x86)\\IronPython 2.7\\DLLs",
                "C:\\Program Files (x86)\\IronPython 2.7",
                "C:\\Program Files (x86)\\IronPython 2.7\\lib\\site-packages",
                "C:\\Python27\\Lib"
            };
            engine.SetSearchPaths(libs);

            clientID = -1;
        }

        private void Button_start_VREP_Click(object sender, EventArgs e)
        {
            engine.ExecuteFile("PythonScripts/VREP_connection.py", scope);

            dynamic start_VREP = scope.GetVariable("Start_VREP");

            clientID = start_VREP();

            if (clientID == -1)
                Temp_richBox.Text += "Подключение не было установлено. \n";
            else
                Temp_richBox.Text += clientID;

        }

        private void Button_stop_VREP_Click(object sender, EventArgs e)
        {
            if (clientID != -1)
            {
                engine.ExecuteFile("PythonScripts/VREP_connection.py", scope);
                dynamic stop_VREP = scope.GetVariable("Stop_VREP");

                stop_VREP(clientID);
            }
        }
    }
}
