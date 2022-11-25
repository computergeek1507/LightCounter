using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using NLog;

namespace LightCounter
{
	public partial class MainForm : Form
	{
		private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
		public static ListBoxLog _listBoxLog;

		readonly string _appDataFolder = string.Format("{0}{1}{2}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Path.DirectorySeparatorChar, "Emgu_Test");

		ToolTip _frameToolTip;
		AppSettings _appSettings;

		readonly E131OutputManager _e131OutputManager;

		public MainForm()
		{
			InitializeComponent();

			_listBoxLog = new ListBoxLog(logListBox);
			_frameToolTip = new ToolTip();
			_frameToolTip.AutoPopDelay = 5000;
			_frameToolTip.InitialDelay = 1000;
			_frameToolTip.ReshowDelay = 500;
			_frameToolTip.ShowAlways = true;

			if (!(Directory.Exists(_appDataFolder)))
			{
				Directory.CreateDirectory(_appDataFolder);
			}

            _appSettings = new AppSettings();
			LoadSettings();

			_e131OutputManager = new E131OutputManager(_appSettings);
            videoPropertyGrid.SelectedObject = _appSettings;
            _e131OutputManager.MessageSent += Logger_EventLogged;
			_e131OutputManager.CurrentNodeSent += E131_SetNodeValue;
		}

		private void Logger_EventLogged(object sender, string e)
		{
			_listBoxLog.Log( e);
		}

		private void Logger_EventLogged(object sender, LoggerEventArgs e)
		{
			_listBoxLog.Log(e.LogLevel, e.Message);
		}

		private void E131_SetNodeValue(object sender, int e)
		{

		}		

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void videoPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{

			SaveSettings();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		void LoadSettings()
		{
			var settingFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//LightCounter_settings.xml";
			//var settingFile = _appDataFolder + Path.DirectorySeparatorChar + "settings.xml";

			try
			{
				if (File.Exists(settingFile))//see if file exists
				{
					XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
					FileStream reader = new FileStream(settingFile, FileMode.Open);
                    _appSettings = (AppSettings)serializer.Deserialize(reader);
					reader.Close();
				}
			}
			catch (Exception ex)
			{
				_listBoxLog.Log(Level.Warning, ex.Message);
			}
		}

		void SaveSettings()
		{
			var settingFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//LightCounter_settings.xml";
			//var settingFile = _appDataFolder + Path.DirectorySeparatorChar + "settings.xml";
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
				TextWriter writer = new StreamWriter(settingFile);
				serializer.Serialize(writer, _appSettings);
				writer.Close();
			}
			catch (Exception ex)
			{
				_listBoxLog.Log(Level.Warning, ex.Message);
			}
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
            _e131OutputManager.OutputLight(0);
        }

        private void numericUpDownPixel_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownPixel.Value);
			_e131OutputManager.OutputLight(count);
        }
		private void IncreasePixelNumber(decimal amount)
        {
			var val = numericUpDownPixel.Value;
			val = val + amount;
			Math.Max(0, val);
            Math.Min(numericUpDownPixel.Maximum, val);
            numericUpDownPixel.Value = val;
        }

        private void buttonMinusOne_Click(object sender, EventArgs e)
        {
			IncreasePixelNumber(-1);
        }

        private void buttonMinusTen_Click(object sender, EventArgs e)
        {
            IncreasePixelNumber(-10);
        }

        private void buttonMinusFifty_Click(object sender, EventArgs e)
        {
            IncreasePixelNumber(-50);
        }

        private void buttonPlusOne_Click(object sender, EventArgs e)
        {
            IncreasePixelNumber(1);
        }

        private void buttonPlusTen_Click(object sender, EventArgs e)
        {
            IncreasePixelNumber(10);
        }

        private void buttonPlusFifty_Click(object sender, EventArgs e)
        {
            IncreasePixelNumber(50);
        }
    }
}
