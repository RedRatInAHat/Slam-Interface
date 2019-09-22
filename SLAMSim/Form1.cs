using System;
using System.Drawing;
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
                "C:\\Python27\\Lib",
                "C:/Python27/Lib/site-packages"
            };
            engine.SetSearchPaths(libs);

            clientID = -1;
        }

        private void Button_start_VREP_Click(object sender, EventArgs e)
        {
            c_start_VREP();
        }

        private void Button_stop_VREP_Click(object sender, EventArgs e)
        {
            c_stop_VREP();
        }

        private void Button_camera_connection_Click(object sender, EventArgs e)
        {
            if (clientID != 1)
            {
                get_RGB();
            }
        }

        private void c_start_VREP()
        {
            engine.ExecuteFile("PythonScripts/VREP_connection.py", scope);

            dynamic start_VREP = scope.GetVariable("Start_VREP");

            clientID = start_VREP();

            if (clientID == -1)
                Temp_richBox.Text += "Подключение не было установлено. \n";
            else
                Temp_richBox.Text += clientID + "\n";
        }

        private void c_stop_VREP()
        {
            if (clientID != -1)
            {
                engine.ExecuteFile("PythonScripts/VREP_connection.py", scope);
                dynamic stop_VREP = scope.GetVariable("Stop_VREP");

                stop_VREP(clientID);
            }
        }

        private void get_RGB()
        {
            int width = 640, height = 480;
            Bitmap rgb_image = new Bitmap(width, height);

            engine.ExecuteFile("PythonScripts/VREP_camera.py", scope);
            dynamic get_rgb_from_kinect = scope.GetVariable("get_rgb_from_kinect");

            int[] rgb_list = get_rgb_from_kinect(clientID);

            Temp_richBox.Text += rgb_list.Length + "\n\n";

            if (rgb_list[0] != 1)
            {
                int x = 0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        rgb_image.SetPixel(j, i, Color.FromArgb(rgb_list[x++], rgb_list[x++], rgb_list[x++]));
                        //if (rgb_list[x++] > 0)
                        //{
                        //    Temp_richBox.Text += rgb_list[x - 1] + " ";
                        //    er++;
                        //}
                        //if (rgb_list[x++] > 0)
                        //{
                        //    Temp_richBox.Text += rgb_list[x - 1] + " ";
                        //    er++;
                        //}
                        //if (rgb_list[x++] > 0)
                        //{
                        //    Temp_richBox.Text += rgb_list[x - 1] + " ";
                        //    er++;
                        //}

                    }
                }


                rgb_pb.Image = rgb_image;
            }
        }
    }
}
